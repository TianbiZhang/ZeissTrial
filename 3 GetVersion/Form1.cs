using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Insert the API namespace. You must have added a reference to the CZEMApi ActiveX control in Visual Studio before, as described in the SmartSEM Remote API Manual.
// Set the APILib properties 'Embed Interop types" to False and 'Local copy' to True. 
using APILib;
using System.Runtime.InteropServices;// Needed for using the VariantWrapper class
using System.Threading; // Needed for sleep
using System.Threading.Tasks; // Needed for async functions
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

// The main program.
namespace ZeissTrial
{
    // Define the windows form application.
    public partial class Form1 : Form
    {
        // Create a new Api object
        Api CZEMApi = new Api();

        // Define a flag to check for initialisation later
        // Taken directly from the original API program.
        private bool apiInitialised = false;

        //---------------------Memory map access
        const UInt32 SECTION_MAP_READ = 0x0004;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenFileMapping(uint dwDesiredAccess,
                                            bool bInheritHandle,
                                            string lpName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr MapViewOfFile(IntPtr hFileMappingObject,
                                          uint dwDesiredAccess,
                                          uint dwFileOffsetHigh,
                                          uint dwFileOffsetLow,
                                          uint dwNumberOfBytesToMap);

        [DllImport("Kernel32.dll")]
        static extern bool UnmapViewOfFile(IntPtr map);

        [DllImport("kernel32.dll")]
        static extern int CloseHandle(IntPtr hObject);
        //---------------------Memory map access end

        // Define error codes - used for ReportError function
        public enum ZeissErrorCode
        {
            API_E_NO_ERROR = 0,
            
            // Failed to translate parameter into an id
            API_E_GET_TRANSLATE_FAIL = 1000,

            // Failed to get analogue value
            API_E_GET_AP_FAIL = 1001,

            // Failed to get digital value
            API_E_GET_DP_FAIL = 1002,
            // Parameter supplied is not analogue nor digital
            API_E_GET_BAD_PARAMETER = 1003,

            // Failed to translate parameter into an id
            API_E_SET_TRANSLATE_FAIL = 1004,

            // Failed to set a digital state 
            API_E_SET_STATE_FAIL = 1005,

            // Failed to set a float value
            API_E_SET_FLOAT_FAIL = 1006,

            // Value supplied is too low
            API_E_SET_FLOAT_LIMIT_LOW = 1007,

            // Value supplied is too high
            API_E_SET_FLOAT_LIMIT_HIGH = 1008,

            // Value supplied is is of wrong type
            API_E_SET_BAD_VALUE = 1009,

            // Parameter supplied is not analogue nor digital
            API_E_SET_BAD_PARAMETER = 1010,

            // Failed to translate command into an id
            API_E_EXEC_TRANSLATE_FAIL = 1011,

            // Failed to execute command=
            API_E_EXEC_CMD_FAIL = 1012,

            // Failed to execute file macro
            API_E_EXEC_MCF_FAIL = 1013,

            // Failed to execute library macro
            API_E_EXEC_MCL_FAIL = 1014,

            // Command supplied is not implemented
            API_E_EXEC_BAD_COMMAND = 1015,

            // Grab command failed
            API_E_GRAB_FAIL = 1016,

            // Get Stage position failed
            API_E_GET_STAGE_FAIL = 1017,

            // Move Stage position failed
            API_E_MOVE_STAGE_FAIL = 1018,

            // API not initialised
            API_E_NOT_INITIALISED = 1019,

            // Failed to translate parameter to an id
            API_E_NOTIFY_TRANSLATE_FAIL = 1020,

            // Set notification failed
            API_E_NOTIFY_SET_FAIL = 1021,

            // Get limits failed
            API_E_GET_LIMITS_FAIL = 1022,

            // Get multiple parameters failed
            API_E_GET_MULTI_FAIL = 1023,

            // Set multiple parameters failed
            API_E_SET_MULTI_FAIL = 1024,

            // Missing API license
            API_E_NOT_LICENSED = 1025,

            // Reserved or not implemented
            API_E_NOT_IMPLEMENTED = 1026,

            // Failed to get user name (Remoting Interface only)
            API_E_GET_USER_NAME_FAIL = 1027,

            // Failed to get user idle state (Remoting Interface only)
            API_E_GET_USER_IDLE_FAIL = 1028,

            // Failed to get the last remoting connection error string (Remoting Interface Only)
            API_E_GET_LAST_REMOTING_CONNECT_ERROR_FAIL = 1029,

            // Failed to remotely logon to the EM Server (username and password may be incorrect or EM Server is not running or User is already logged on
            API_E_EMSERVER_LOGON_FAILED = 1030,

            // Failed to start the EM Server - this may be because the Server is already running or has an internal error. 
            API_E_EMSERVER_START_FAILED = 1031,

            // The command or parameter is currently disabled (you cannot execute or set it).
            API_E_PARAMETER_IS_DISABLED = 1032,

            // Remoting incorrectly configured, use RConfigure to correct
            API_E_REMOTING_NOT_CONFIGURED = 2027,

            // Remoting did not connect to the server
            API_E_REMOTING_FAILED_TO_CONNECT = 2028,

            // Remoting could not start (unknown reason)
            API_E_REMOTING_COULD_NOT_CREATE_INTERFACE = 2029,

            // Remoting: Remote server is not running currently.
            API_E_REMOTING_EMSERVER_NOT_RUNNING = 2030,

            // Remoting: Remote server has no user logged in
            API_E_REMOTING_NO_USER_LOGGED_IN = 2031,


            // Internal Defines, although they may be useful in your own program. TRS.
            API_FIRST_REMOTING_ERROR_CODE = API_E_REMOTING_NOT_CONFIGURED,
            API_LAST_REMOTING_ERROR_CODE = API_E_REMOTING_NO_USER_LOGGED_IN,

            API_FIRST_ERROR_CODE = API_E_GET_TRANSLATE_FAIL,
            API_LAST_ERROR_CODE = API_E_REMOTING_NO_USER_LOGGED_IN
        }

        // Notification codes that the Remoting server may send to you.
        public enum ZeissNotificationCode
        {
            PARAMETER_CHANGE = 0,
            PARAMETER_XY_CHANGE = 6,
            EMSERVER_HAS_LOADED = 1111111,
            EMSERVER_HAS_EXITED = 2222222,
            EMSERVER_USER_LOGGED_ON = 3333333,
            EMSERVER_USER_LOGGED_OFF = 4444444,
            REMOTING_SERVER_EXITED = 5555555,
            EMSERVER_FIBUI_HAS_LOADED = 6666666
        }

        // Function to translate the error code to natural language.
        string ErrorToString(long lError)
        {
            string strError;
            switch ((ZeissErrorCode)lError)
            {
                case 0:
                    strError = "OK";
                    break;
                case ZeissErrorCode.API_E_GET_TRANSLATE_FAIL:
                    strError = "Failed to translate parameter into an ID";
                    break;
                case ZeissErrorCode.API_E_GET_AP_FAIL:
                    strError = "Failed to get analogue value";
                    break;
                case ZeissErrorCode.API_E_GET_DP_FAIL:
                    strError = "Failed to get digital value";
                    break;
                case ZeissErrorCode.API_E_GET_BAD_PARAMETER:
                    strError = "Parameter supplied is neither analogue nor digital";
                    break;
                case ZeissErrorCode.API_E_SET_TRANSLATE_FAIL:
                    strError = "Failed to translate parameter into an ID";
                    break;
                case ZeissErrorCode.API_E_SET_STATE_FAIL:
                    strError = "Failed to set a digital state";
                    break;
                case ZeissErrorCode.API_E_SET_FLOAT_FAIL:
                    strError = "Failed to set a float value";
                    break;
                case ZeissErrorCode.API_E_SET_FLOAT_LIMIT_LOW:
                    strError = "Value supplied is too low";
                    break;
                case ZeissErrorCode.API_E_SET_FLOAT_LIMIT_HIGH:
                    strError = "Value supplied is too high";
                    break;
                case ZeissErrorCode.API_E_SET_BAD_VALUE:
                    strError = "Value supplied is of wrong type";
                    break;
                case ZeissErrorCode.API_E_SET_BAD_PARAMETER:
                    strError = "Parameter supplied is not analogue nor digital";
                    break;
                case ZeissErrorCode.API_E_EXEC_TRANSLATE_FAIL:
                    strError = "Failed to translate command into an ID";
                    break;
                case ZeissErrorCode.API_E_EXEC_CMD_FAIL:
                    strError = "Failed to execute command";
                    break;
                case ZeissErrorCode.API_E_EXEC_MCF_FAIL:
                    strError = "Failed to execute file macro";
                    break;
                case ZeissErrorCode.API_E_EXEC_MCL_FAIL:
                    strError = "Failed to execute library macro";
                    break;
                case ZeissErrorCode.API_E_EXEC_BAD_COMMAND:
                    strError = "Command supplied is not implemented";
                    break;
                case ZeissErrorCode.API_E_GRAB_FAIL:
                    strError = "Grab command failed";
                    break;
                case ZeissErrorCode.API_E_GET_STAGE_FAIL:
                    strError = "Get Stage position failed";
                    break;
                case ZeissErrorCode.API_E_MOVE_STAGE_FAIL:
                    strError = "Move Stage position failed";
                    break;
                case ZeissErrorCode.API_E_NOT_INITIALISED:
                    strError = "API not initialised";
                    break;
                case ZeissErrorCode.API_E_NOTIFY_TRANSLATE_FAIL: // 1020L
                    strError = "Failed to translate parameter to an ID";
                    break;
                case ZeissErrorCode.API_E_NOTIFY_SET_FAIL:
                    strError = "Set notification failed";
                    break;
                case ZeissErrorCode.API_E_GET_LIMITS_FAIL:
                    strError = "Get limits failed";
                    break;
                case ZeissErrorCode.API_E_GET_MULTI_FAIL:
                    strError = "Get multiple parameters failed";
                    break;
                case ZeissErrorCode.API_E_SET_MULTI_FAIL:
                    strError = "Set multiple parameters failed";
                    break;
                case ZeissErrorCode.API_E_NOT_LICENSED:
                    strError = "Missing API license";
                    break;
                case ZeissErrorCode.API_E_NOT_IMPLEMENTED:
                    strError = "Reserved or not implemented";
                    break;
                case ZeissErrorCode.API_E_GET_USER_NAME_FAIL:
                    strError = "Failed to get user name";
                    break;
                case ZeissErrorCode.API_E_GET_USER_IDLE_FAIL:
                    strError = "Failed to get user idle state";
                    break;
                case ZeissErrorCode.API_E_GET_LAST_REMOTING_CONNECT_ERROR_FAIL:
                    strError = "Failed to get the last remoting connection error string";
                    break;
                case ZeissErrorCode.API_E_EMSERVER_LOGON_FAILED:
                    strError = "Failed to remotely logon to the EM Server. Username and password may be incorrect or EM Server is not running or User is already logged on";
                    break;
                case ZeissErrorCode.API_E_EMSERVER_START_FAILED:
                    strError = "Failed to start the EM Server. This may be because the Server is already running or has an internal error.";
                    break;
                case ZeissErrorCode.API_E_REMOTING_NOT_CONFIGURED:
                    strError = "Remoting incorrectly configured, use RConfigure to correct";
                    break;
                case ZeissErrorCode.API_E_REMOTING_FAILED_TO_CONNECT:
                    strError = "Remoting did not connect to the server";
                    break;
                case ZeissErrorCode.API_E_REMOTING_COULD_NOT_CREATE_INTERFACE:
                    strError = "Remoting could not start (unknown reason)";
                    break;
                case ZeissErrorCode.API_E_REMOTING_EMSERVER_NOT_RUNNING:
                    strError = "EMServer is not running on the remote machine";
                    break;
                case ZeissErrorCode.API_E_REMOTING_NO_USER_LOGGED_IN:
                    strError = "No user is logged into EM Server on the remote machine";
                    break;
                default:
                    strError = string.Format("Unknown error code {0}", lError);
                    break;
            }
            return strError;
        }

        //public static string pydirectory = Environment.GetEnvironmentVariables("PATH");

        // Start of the Windows form (GUI) script
        public Form1()
        {
            InitializeComponent();

            //Initialize some displayed values/status
            textBoxInit.Text = "Not initialized";
            textBoxInit.BackColor = Color.Red;
            textBoxSetNotify.Text = "No notification";
            //textBoxSetNotify.BackColor = Color.Red;

            textBoxMouseCoords.BackColor = Color.Red;


            // Set the default path for the two browsers
            string defaultpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            textBoxFrameGrabDirectory.Text = defaultpath;
            textBoxDEDDirectory.Text = defaultpath;

            //Calling Notification for updated status
            CZEMApi.Notify += new _EMApiEvents_NotifyEventHandler(CZEMApi_Notify);
            CZEMApi.NotifyWithCurrentValue += new _EMApiEvents_NotifyWithCurrentValueEventHandler(CZEMApi_NotifyWithCurrentValue);
        }

        // Preparations for the asynchronized methods.
        // Below are functions for updating the status boxes in asynchronized mode.
        // First, define the delegate method
        delegate void SetTextCallback(string text);

        // Function for updating the main notification box
        private void SetTextSetNotify(string text)
        {
            if (textBoxSetNotify.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextSetNotify);
                Invoke(d, new object[] { text });

            }
            else
                textBoxSetNotify.AppendText($"{text}\r\n");
        }

        // Function for updating the DED notification box.
        private void SetTextDEDConsole(string text)
        {
            if (textBoxDEDConsole.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextDEDConsole);
                Invoke(d, new object[] { text });
            }
            else
                textBoxDEDConsole.AppendText($"{text}\r\n");
        }

        // Define the canceller for the abort button.
        private CancellationTokenSource _canceller;

        // Define the action when the abort buttion is clicked.
        // Note: for nested loops extra steps will be needed, see for example buttonBeamXYScan_Click.
        private void buttonAbort_Click(object sender, EventArgs e)
        {
            _canceller.Cancel();
            SetTextSetNotify("\r\nProcess aborted!\r\n");
        }

        // Code executed when buttonInitialiseCZEMApi is clicked
        private void buttonInitialiseCZEMApi_Click(object sender, System.EventArgs e)
        {
            // Initalise communication between the CZEMApi OCX and EM Server
            long lReturn = CZEMApi.Initialise("");
            // long lReturn = CZEMApi.InitialiseRemoting("");

            if (lReturn == 0)
            {
                apiInitialised = true;
                textBoxInit.Text = "Initialized";
                textBoxInit.BackColor = Control.DefaultBackColor;
                MessageBox.Show("Remote API correctly initialised.");

                buttonInitializeRemote.Enabled = false;
                //btnstartserver.enabled = false;
                //txteditusername.enabled = false;
                //txteditpassword.enabled = false;
                //btnlogon.enabled = false;
                //btngetremotingerror.enabled = false;
                //btngetusername.enabled = false;
                //btngetuseridle.enabled = false;
            }
            else
            {
                textBoxInit.Text = "Not initialized";
                textBoxInit.BackColor = Color.Red;
                ReportError(lReturn, "Initialise", "Initialise COM");
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInitializeRemote_Click(object sender, EventArgs e)
        {
            textBoxInit.Text = "Trying to initialise, please wait...";
            textBoxInit.Update();

            long lReturn = CZEMApi.InitialiseRemoting();
            if (lReturn == 0)
            {
                apiInitialised = true;
                textBoxInit.Text = "Initialised Remote";
                textBoxInit.BackColor = Control.DefaultBackColor;
                buttonInitialiseCZEMApi.Enabled = false;// Disable non-remote functionallity
                
            }
            else
            {
                textBoxInit.Text = "Not Initialised";
                textBoxInit.BackColor = Color.Red;
                ReportError(lReturn, "Initialise Remoting", "Initialise COM");

                MessageBox.Show("Error initializing remote connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Code executed when buttonGetCZEMApiVersion is clicked
        private void buttonGetCZEMApiVersion_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
            {
                short iVersion = 0;
                //object iVersionnew = new VariantWrapper((float)0.0f);
                // Call GetVersion (now deprecated)
                int lReply = CZEMApi.GetVersion(ref iVersion);

                //long lReplyNew = CZEMApi.Get("SV_VERSION", ref iVersionnew);

                if (lReply == 0)
                {// Convert version number to string and show it in a message box.
                    MessageBox.Show(iVersion.ToString(), "API version");
                }
                else
                {
                    ReportError(lReply, "Get","GetAPIVersion");
                    MessageBox.Show("Access error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        internal void ReportError(string strError, string strCaller, string strComment)
        {
            if (strCaller.Length != 0 || strComment.Length != 0)
            {
                SetTextSetNotify(string.Format("{0}\r\nCaller: {1}\r\nComment: {2}", strError, strCaller, strComment));
                
            }
            else
            {
                SetTextSetNotify(strError);
            }
        }

        internal void ReportError(long lReturn, string strCaller, string strComment)
        {
            ReportError(ErrorToString(lReturn), strCaller, strComment);
        }

        internal void DisplayError(string strCaller, string strComment)
        {
            if (apiInitialised)
            {
                object objError = new VariantWrapper("");
                long lResult = CZEMApi.GetLastError(ref objError);
                if (lResult == 0)
                {
                    if (objError != null)
                    {
                        ReportError(objError.ToString(), strCaller, strComment);
                    }
                    else
                    {
                        ReportError("No error occured", strCaller, strComment);
                    }
                }
                else
                {
                    ReportError("Cannot get last error", strCaller, strComment);
                }
            }
        }

        public void Notify(string strParameter, int reason)
        {
            string strGetEMSERVERMsg = "";
            switch ((ZeissNotificationCode)reason)
            {
                case ZeissNotificationCode.PARAMETER_CHANGE: // Parameter Change
                    if (strParameter == "DP_VACSTATUS" || strParameter == "DP_RUNUPSTATE" || strParameter == "AP_ACTUALKV" || strParameter == "DP_HIGH_CURRENT"
                        || strParameter == "AP_ACTUALCURRENT" || strParameter == "AP_EXTCURRENT" || strParameter == "DP_SPOT" || strParameter == "DP_SCANRATE"
                        || strParameter == "AP_MAG" || strParameter == "AP_PIXEL_SIZE" || strParameter == "AP_WD" || strParameter == "AP_APERTURESIZE"
                        || strParameter == "DP_DETECTORTYPE" || strParameter == "DP_DETECTOR_CHANNEL" || strParameter == "AP_BRIGHTNESS" || strParameter == "AP_CONTRAST" 
                        || strParameter == "AP_STAGE_AT_X" || strParameter == "AP_STAGE_AT_Y" || strParameter == "AP_STAGE_AT_Z")
                    {
                        UpdateStatus(strParameter);
                    }
                    break;

                case ZeissNotificationCode.REMOTING_SERVER_EXITED:
                    textBoxSetNotify.Text = textBoxSetNotify.Text + "\r\n" + "Remote Server Exited";
                    strGetEMSERVERMsg = "Remote Server Exited";
                    //DisplayError("Remote Server closed", "");
                    MessageBox.Show("Remote Server Closed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    apiInitialised = false;
                    textBoxInit.Text = "Not Initialised";
                    textBoxSetNotify.Text = "No Notification";
                    textBoxInit.BackColor = Color.Red;
                    textBoxSetNotify.BackColor = Color.Red;
                    break;

                default:
                    strGetEMSERVERMsg = strParameter;
                    break;
            }

            if (strGetEMSERVERMsg.Length > 0)
            {
                if (textBoxSetNotify.Text.Length > 0)
                {
                    textBoxSetNotify.Text += "\r\n" + strGetEMSERVERMsg;
                    textBoxSetNotify.SelectionStart = textBoxSetNotify.Text.Length;
                    textBoxSetNotify.SelectionLength = 0;
                }
                else
                {
                    textBoxSetNotify.Text = strGetEMSERVERMsg;
                }
            }
        }

        public void CZEMApi_Notify(string strParameter, int reason)
        {
            Notify(strParameter, reason);
        }

        public void CZEMApi_NotifyWithCurrentValue(string strParameter, int reason, int paramid, double dLastKnownValue)
        {
            Notify(strParameter, reason);
        }

        private void buttonSetNotify_Click(object sender, EventArgs e)
        {
            if (apiInitialised)
            {
                // Vacuum
                if (CZEMApi.SetNotify("DP_VACSTATUS", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Gun / EHT state
                if (CZEMApi.SetNotify("DP_RUNUPSTATE", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // actual KV / EHT
                if (CZEMApi.SetNotify("AP_ACTUALKV", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // actual current
                if (CZEMApi.SetNotify("DP_HIGH_CURRENT", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // column type
                if (CZEMApi.SetNotify("AP_ACTUALCURRENT", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // mode
                if (CZEMApi.SetNotify("AP_EXTCURRENT", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // scan rate
                if (CZEMApi.SetNotify("DP_SPOT", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // auto function active
                if (CZEMApi.SetNotify("DP_SCANRATE", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Magnification
                if (CZEMApi.SetNotify("AP_MAG", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Working distance
                if (CZEMApi.SetNotify("AP_PIXEL_SIZE", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // probe current
                if (CZEMApi.SetNotify("AP_WD", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // detector
                if (CZEMApi.SetNotify("AP_APERTURESIZE", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // stage initialised
                if (CZEMApi.SetNotify("DP_DETECTOR_TYPE", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // stage busy?
                if (CZEMApi.SetNotify("DP_DETECTOR_CHANNEL", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // fib mode
                if (CZEMApi.SetNotify("AP_BRIGHTNESS", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // fib gun state
                if (CZEMApi.SetNotify("AP_CONTRAST", 1) != 0)
                {
                    MessageBox.Show("Error refreshing the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                textBoxSetNotify.Text = "Notification enabled";
                textBoxSetNotify.BackColor = Control.DefaultBackColor;
            }
            else
                MessageBox.Show("API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Code executed when buttonGetBeamPosnLimits is clicked
        private void buttonGetBeamPosnLimits_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
            {
                // Initialise four VariantWrapper objects to reference the parameter values
                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vMinValueY = new VariantWrapper((float)0.0f);
                object vMaxValueY = new VariantWrapper((float)0.0f);

                // Get parameter limits numeric values 
                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);

                long lReplyY = CZEMApi.GetLimits("AP_SPOT_POSN_Y", ref vMinValueY, ref vMaxValueY);

                // Show the values, or an error message in case of an error
                switch ((ZeissErrorCode)lReplyX)
                {
                    case ZeissErrorCode.API_E_NO_ERROR:
                        switch ((ZeissErrorCode)lReplyY)
                        {
                            case ZeissErrorCode.API_E_NO_ERROR:
                                MessageBox.Show("Beam position limits successfully read. X Limits: " + vMinValueX.ToString() + "-" + vMaxValueX.ToString() + ", Y Limits: " + vMinValueY.ToString() + "-" + vMaxValueY.ToString() + ".");
                                break;

                            case ZeissErrorCode.API_E_GET_TRANSLATE_FAIL:
                                MessageBox.Show("Failed to translate parameter into an id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case ZeissErrorCode.API_E_NOT_INITIALISED:
                                MessageBox.Show("API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case ZeissErrorCode.API_E_GET_LIMITS_FAIL:
                                MessageBox.Show("Get limits failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                        break;

                    case ZeissErrorCode.API_E_GET_TRANSLATE_FAIL:
                        MessageBox.Show("Failed to translate parameter into an id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case ZeissErrorCode.API_E_NOT_INITIALISED:
                        MessageBox.Show("API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case ZeissErrorCode.API_E_GET_LIMITS_FAIL:
                        MessageBox.Show("Get limits failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonXBeamScan_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
            {
                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vValueY = new VariantWrapper((float)0.0f);

                // Get parameter limits numeric values 
                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);

                long lReplyY = CZEMApi.Get("AP_SPOT_POSN_Y", ref vValueY);

                int vValueX_Max = int.Parse(vMaxValueX.ToString());

                if (lReplyX != 0)
                {
                    ReportError(lReplyX, "Get Limit", "X Beam scan");
                    return;
                }
                else
                {
                    DialogResult res = MessageBox.Show("beam position limits successfully read." +
                                    $"X Limits: {vMinValueX}-{vMaxValueX}, Y position: {vValueY}." +
                                    $"\nLine scan along X will start in 1 seconds after clicking OK. Please check SmartSEM.", "Confirm Scan", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.Cancel)
                        return;

                    object varStr = new VariantWrapper("");
                    long lReturn = CZEMApi.Get("DP_SPOT", ref varStr);
                    if (lReturn != 0)
                    {
                        //ReportError(lReturn, "buttonSpotModeSwitch", "Get Value");
                        MessageBox.Show("Error getting the spot mode state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string SpotModeState = varStr.ToString();

                    if (SpotModeState != "On")
                    {
                        object SpotStateTarget = new VariantWrapper("On"); //If spot mode is off, turn it on and refresh the corresponding display.
                        long lReturnSwitch = CZEMApi.Set("DP_SPOT", SpotStateTarget);

                        if (lReturnSwitch != 0)
                        {
                            //ReportError(lReturn, "buttonSpotModeSwitch", "Set Value");
                            MessageBox.Show("Error getting the state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }                      
                    }
                    progressBarScan.Visible = true;
                    progressBarScan.Minimum = 0;
                    progressBarScan.Maximum = vValueX_Max;
                    progressBarScan.Value = 0;
                    progressBarScan.Step = 1;

                    Thread.Sleep(1000);

                    int XPos = 0;
                    _canceller = new CancellationTokenSource();

                    await TaskEx.Run(() =>
                    {
                        do
                        {
                            object XPos_loop = new VariantWrapper(XPos.ToString());

                            long lReply_XPos = CZEMApi.Set("AP_SPOT_POSN_X", ref XPos_loop);

                            if (lReply_XPos != 0)
                            {
                                ReportError(lReply_XPos, "Set", "XbeamScan");
                                return;
                            }
                            else
                            {
                                Thread.Sleep(10);
                                XPos++;

                                progressBarScan.Invoke(new Action(() =>
                                {
                                    progressBarScan.PerformStep();
                                }));

                            }

                            if (_canceller.Token.IsCancellationRequested)
                            {
                                SetTextSetNotify("Process terminated by user (\"Abort\" pressed). ");
                                break;
                            }


                            if (XPos == vValueX_Max)
                                SetTextSetNotify("X beam scan done!\r\n");

                        } while (XPos <= vValueX_Max);

                        _canceller.Dispose();
                    });
                }

            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSetMag_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
            {
                string value = textBoxEnterMag.Text;
                // Initialise a VariantWrapper object to reference the parameter value
                object vValue = new VariantWrapper(value);

                // Set parameter value
                long lReply = CZEMApi.Set("AP_MAG", ref vValue);

                ReportError(lReply,"buttonSetMag", "Set Value");
                if(lReply == 0)
                    MessageBox.Show("Mag set to = " + value);
                // Show the value, or an error message in case of an error
                // Set() returns error 1007 (API_E_SET_FLOAT_LIMIT_LOW) if the value string does not contain a number
            }
        }

        private async void buttonXYBeamScan_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
            {
                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vMinValueY = new VariantWrapper((float)0.0f);
                object vMaxValueY = new VariantWrapper((float)0.0f);
                object vValueMag = new VariantWrapper("");
                object vValueSpotSize = new VariantWrapper("");

                // Get parameter limits numeric values 
                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);
                long lReplyY = CZEMApi.GetLimits("AP_SPOT_POSN_Y", ref vMinValueY, ref vMaxValueY);
                long lReplyMag = CZEMApi.Get("AP_Mag", ref vValueMag);
                long lReplySpotSize = CZEMApi.Get("AP_PIXEL_SIZE", ref vValueSpotSize);
                int vValueX_Max = int.Parse(vMaxValueX.ToString());
                int vValueY_Max = int.Parse(vMaxValueY.ToString());

                if (lReplyX == 0 && lReplyY == 0)
                {

                    DialogResult res = MessageBox.Show($"Frame size is {vMaxValueX}x{vMaxValueY}. Magnification{vValueMag}, " +
                        $"pixel size {vValueSpotSize} ." +
                        $"\n Full frame scan will start in 1 seconds after clicking OK. Please check SmartSEM window." +
                        $"\n Click \"cancel\" to cancel this scan", "Confirm X-Y Beam Scan",
                        MessageBoxButtons.OKCancel);
                    if (res == DialogResult.Cancel)
                        return;

                    progressBarScan.Visible = true;
                    progressBarScan.Minimum = 0;
                    progressBarScan.Maximum = (vValueX_Max) * (vValueY_Max);
                    progressBarScan.Value = 0;
                    progressBarScan.Step = 1;

                    Thread.Sleep(1000);

                    bool breakloop = false;

                    _canceller = new CancellationTokenSource();

                    await TaskEx.Run(() =>
                    {
                        for (int YPos = 0; YPos <= vValueY_Max; YPos++)
                        {
                            if (breakloop)
                                goto LoopEnd;

                            object YPos_loop = new VariantWrapper(YPos.ToString());

                            long lReply_YPos = CZEMApi.Set("AP_SPOT_POSN_Y", ref YPos_loop);

                            if (lReply_YPos != 0)
                            {
                                ReportError(lReply_YPos, "XYBeamScan_Set X", "Set Value");
                                goto LoopError;
                            }
                            // Show the value, or an error message in case of an error

                            for (int XPos = 0; XPos <= vValueX_Max; XPos++)
                            {
                                object XPos_loop = new VariantWrapper(XPos.ToString());

                                long lReply_XPos = CZEMApi.Set("AP_SPOT_POSN_X", ref XPos_loop);

                                if (lReply_XPos != 0)
                                {
                                    ReportError(lReply_XPos, "XYBeamScan_Set X", "Set Value");
                                    return;
                                }

                                progressBarScan.Invoke(new Action(() =>
                                {
                                    progressBarScan.PerformStep();
                                }));

                                if (_canceller.Token.IsCancellationRequested)
                                {
                                    breakloop = true;
                                    break;
                                }
                            }

                        }
                        _canceller.Dispose();
                    LoopEnd:
                        {
                            SetTextSetNotify("Process terminated by user (\"Abort\" pressed). \r\n");
                            return;
                        }
                    LoopError:
                        {
                            SetTextSetNotify("Process terminated due to Error. \r\n");
                            return;
                        }
                    });

                    SetTextSetNotify("Scan complete!");
                    MessageBox.Show("Scan complete!", "Scan Complete", MessageBoxButtons.OK);

                }
                else
                {
                    ReportError(lReplyX, "XYBeamScan", "Get Limits");
                    ReportError(lReplyY, "XYBeamScan", "Get Limits");
                }
            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCloseControl_Click(object sender, System.EventArgs e)
        {
            textBoxMouseCoords.BackColor = Color.Red;
            textBoxMouseCoords.Text = "Not set.";
            ButtonCoordsSet = false;
            if (apiInitialised)
            {
                // Control must be closed before it is destroyed
                long lReply = CZEMApi.ClosingControl();

                if(lReply != 0)
                    ReportError(lReply, "Close Control", "ClosingControl");
                else
                {
                    textBoxInit.Text = "Control Closed";
                    textBoxInit.BackColor = Color.Red;
                    apiInitialised = false;

                    MessageBox.Show("Control closed.");
                }

            }
            else
                MessageBox.Show("API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonQuit_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
                MessageBox.Show("API Control not disconnected yet, please close control first!", "API Control Not Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }

        public void UpdateStatus(string szParam)
        {
            object varStr = new VariantWrapper("");
            long lReturn = CZEMApi.Get(szParam, ref varStr);
            if (lReturn != 0)
            {
                //MessageBox.Show("Error refreshing parameters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReportError(lReturn, "Update Status", szParam);
                return;
            }

            if (szParam == "DP_VACSTATUS")
            {
                textBoxVacStatus.Text = "VAC status = " + varStr;
            }
            else if (szParam == "DP_RUNUPSTATE")
            {
                textBoxRunupstate.Text = "" + varStr;
            }
            else if (szParam == "AP_ACTUALKV")
            {
                textBoxActualkv.Text = "EHT " + varStr;
            }
            else if (szParam == "DP_HIGH_CURRENT")
            {
                textBoxHighCurrent.Text = "High Current = " + varStr;
            }
            else if (szParam == "AP_ACTUALCURRENT")
            {
                textBoxActualCurrent.Text = "I " + varStr;
            }
            else if (szParam == "AP_EXTCURRENT")
            {
                textBoxIprobe.Text = "Extractor I " + varStr;
            }
            else if (szParam == "DP_SPOT")
            {
                textBoxSpotMode.Text = "Spot Mode = " + varStr;
            }
            else if (szParam == "DP_SCANRATE")
            {
                textBoxScanrate.Text = "Scan Rate = " + varStr;
            }
            else if (szParam == "AP_MAG")
            {
                textBoxMag.Text = "Mag " + varStr;
            }
            else if (szParam == "AP_PIXEL_SIZE")
            {
                textBoxPixelSize.Text = "Pixel Size " + varStr;
            }
            else if (szParam == "AP_WD")
            {
                textBoxWD.Text = "WD " + varStr;
            }
            else if (szParam == "AP_APERTURESIZE")
            {
                textBoxApertureSize.Text = "Aperture " + varStr;
            }
            else if (szParam == "DP_DETECTOR_TYPE")
            {
                textBoxDetectorType.Text = "Detector =  " + varStr;
            }
            else if (szParam == "DP_DETECTOR_CHANNEL")
            {
                textBoxDetectorChannel.Text = "Detector Ch =  " + varStr;
            }
            else if (szParam == "AP_BRIGHTNESS")
            {
                textBoxBrightness.Text = "Brightness " + varStr;
            }
            else if (szParam == "AP_CONTRAST")
            {
                textBoxContrast.Text = "Contrast  " + varStr;
            }
            else if (szParam == "AP_STAGE_AT_X")
            {
                textBoxStageX.Text = "Stage X  " + varStr;
            }
            else if (szParam == "AP_STAGE_AT_Y")
            {
                textBoxStageY.Text = "Stage Y " + varStr;
            }
            else if (szParam == "AP_STAGE_AT_Z")
            {
                textBoxStageZ.Text = "Stage Z " + varStr;
            }
        }

        private void buttonRefreshParams_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
            {
                UpdateStatus("DP_VACSTATUS");
                UpdateStatus("DP_RUNUPSTATE");
                UpdateStatus("AP_ACTUALKV");
                UpdateStatus("DP_HIGH_CURRENT");
                UpdateStatus("AP_ACTUALCURRENT");
                UpdateStatus("AP_EXTCURRENT");
                UpdateStatus("DP_SPOT");
                UpdateStatus("DP_SCANRATE");
                UpdateStatus("AP_MAG");
                UpdateStatus("AP_PIXEL_SIZE");
                UpdateStatus("AP_WD");
                UpdateStatus("AP_APERTURESIZE");
                UpdateStatus("DP_DETECTOR_TYPE");
                UpdateStatus("DP_DETECTOR_CHANNEL");
                UpdateStatus("AP_BRIGHTNESS");
                UpdateStatus("AP_CONTRAST");
                UpdateStatus("AP_STAGE_AT_X");
                UpdateStatus("AP_STAGE_AT_Y");
                UpdateStatus("AP_STAGE_AT_Z");

            }
            else
                MessageBox.Show("API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxIprobe_TextChanged(object sender, System.EventArgs e)
        {

        }

        public void SEMFrameCapture(string filepath)
        {
            if (apiInitialised)
            {
                // You can save as Bitmap or Tiff but not JPEG
                // Tiff has the Zeiss header with acquisition param info

                try
                {

                    long lResult = CZEMApi.Grab(0, 0, 1024, 768, 0, filepath);
                    if (lResult != 0)
                    {
                        MessageBox.Show("Cannot grab Image to File: " + filepath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                catch (IOException)
                {
                    MessageBox.Show($"Error: the input directory is invalid. This is usually because you don't have the required" +
                        $"reading or writing privileges. Please avoid hard disk root directories (e.g. C:/).",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                MessageBox.Show("API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonGrabImage2File_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
            {
                // You can save as Bitmap or Tiff but not JPEG
                // Tiff has the Zeiss header with acquisition param info

                string ImageFileName = textBoxFrameGrabFileName.Text + ".tif";

                string strFileName = Path.Combine(textBoxFrameGrabDirectory.Text, ImageFileName);

                object unfreezestate = new VariantWrapper("Live");
                long lreplysetunfreeze = CZEMApi.Set("dp_frozen", ref unfreezestate);

                if ((ZeissErrorCode)lreplysetunfreeze != ZeissErrorCode.API_E_NO_ERROR)
                    ReportError(lreplysetunfreeze, "Grab", "Set Unfrozen state");

                long lreplyscanrate = CZEMApi.Execute("CMD_SCANRATE9");
                long lreplylineint = CZEMApi.Execute("CMD_LINE_INT");

                double lineint64 = 4;
                object lineintnum = new VariantWrapper(lineint64.ToString());
                long lreplylineintnum = CZEMApi.Set("AP_NR_COEFF", lineintnum);

                // long lreplyscanrate = 0;
                // long lreplylineint = 0;
                object freezestate = new VariantWrapper("End Frame");
                long lreplyfreeze = CZEMApi.Set("DP_FREEZE_ON", freezestate);

                if (lreplyscanrate != 0 || lreplylineint != 0 || lreplyfreeze != 0 || lreplylineintnum != 0)
                {
                    ReportError(lreplyscanrate, "SeriesGrab", "Scan rate");
                    ReportError(lreplylineint, "SeriesGrab", "Line integral");
                    ReportError(lreplyfreeze, "SeriesGrab", "freeze state");
                    ReportError(lreplylineintnum, "SeriesGrab", "noise reduction coeff");
                }

                // Read frame time in miliseconds - this goes directly to Thread.Sleep() which takes time in miliseconds.
                object vValueFrameTime = new VariantWrapper((float)0.0f);
                long lReplyFrameTime = CZEMApi.Get("AP_FRAME_TIME", ref vValueFrameTime);

                // Report if error
                if (lReplyFrameTime != 0)
                {
                    ReportError(lReplyFrameTime, "SeriesGrab", "Get frame time");
                    return;
                }

                float frametimefloat = float.Parse(vValueFrameTime.ToString());
                // Convert to integer

                int frametime = (int)Math.Round(frametimefloat, 0) + 3 * 1000; //set wait time as frame time + 20 s for enough maneuver time

                SetTextSetNotify($"Image capturing in progress... please wait for {frametime / 1000} seconds.\r\n");

                // wait for frame time
                Thread.Sleep(frametime);

                // Conduct frame grab
                SEMFrameCapture(strFileName);

                // Generate output in the console and refresh
                SetTextSetNotify($"Image grabbed to: {ImageFileName}.\r\n");

            }
            else
                MessageBox.Show("API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonBrowseFrameGrab_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBoxFrameGrabDirectory.Text = dlg.SelectedPath;
            }
        }

        private void buttonGrabPixelValue_Click(object sender, System.EventArgs e)
        {
            if (apiInitialised)
            {
                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vMinValueY = new VariantWrapper((float)0.0f);
                object vMaxValueY = new VariantWrapper((float)0.0f);

                // Get parameter limits numeric values 
                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);
                long lReplyY = CZEMApi.GetLimits("AP_SPOT_POSN_Y", ref vMinValueY, ref vMaxValueY);

                int vValueX_Max = int.Parse(vMaxValueX.ToString());
                int vValueY_Max = int.Parse(vMaxValueY.ToString());

                if ((ZeissErrorCode)lReplyX == ZeissErrorCode.API_E_NO_ERROR && (ZeissErrorCode)lReplyY == ZeissErrorCode.API_E_NO_ERROR)
                {
                    string pixelfilename = Path.Combine(textBoxFrameGrabDirectory.Text, "pixelvalues.txt");

                    DialogResult res = MessageBox.Show("This will capture pixel-by-pixel grayscale value and write line-by-line to a text file. " +
                        $"Image size: {vValueX_Max+1}x{vValueY_Max+1}." +
                        $"\nText File will be saved at: {pixelfilename}" +
                        "\nLine scan will start in 1 seconds after clicking OK. Please check SmartSEM.", "Confirm Scan", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.Cancel)
                        return;
                    
                    Thread.Sleep(1000);

                    // Progress bar control
                    progressBarScan.Visible = true;
                    progressBarScan.Minimum = 0;
                    progressBarScan.Maximum = (vValueX_Max+1) * (vValueY_Max+1) + 1;
                    progressBarScan.Value = 0;
                    progressBarScan.Step = 1;

                    // Create a list of strings to store the pixel-by-pixel grayscale values.
                    List<string> pixelvaluearray = new List<string>();

                    for (int YPos = 0; YPos <= vValueY_Max; YPos++)
                    {
                        object YPos_loop = new VariantWrapper(YPos.ToString());

                        long lReply_YPos = CZEMApi.Set("AP_SPOT_POSN_Y", ref YPos_loop);

                        // Show the value, or an error message in case of an error
                        if (lReply_YPos != 0)
                        {
                            ReportError(lReply_YPos, "buttonGrabPixelValue_Click", "Set Value");
                        }

                        for (int XPos = 0; XPos <= vValueX_Max; XPos++)
                        {
                            object XPos_loop = new VariantWrapper(XPos.ToString());
                            object spotvalue = new VariantWrapper((float)0.0f);

                            long lReply_XPos = CZEMApi.Set("AP_SPOT_POSN_X", ref XPos_loop);

                            if (lReply_XPos != 0)
                            {
                                ReportError(lReply_XPos, "buttonGrabPixelValue_Click", "Set Value");
                            }

                            long lReplyspotvalue = CZEMApi.Get("AP_SPOT", ref spotvalue);
                            if (lReplyspotvalue == 0)
                                pixelvaluearray.Add(spotvalue.ToString());
                            progressBarScan.PerformStep();

                        }
                    }
                    File.WriteAllLines(pixelfilename, pixelvaluearray);
                    progressBarScan.PerformStep();

                    MessageBox.Show("Scan Complete! File saved at:" + pixelfilename, "Scan Complete", MessageBoxButtons.OK);
                    
                }
                else
                    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // buttonSpotModeSwitch: a button to switch spot mode on/off
        private void buttonSpotModeSwitch_Click(object sender, EventArgs e)
        {
            if (apiInitialised)
            {
                object varStr = new VariantWrapper("");
                long lReturn = CZEMApi.Get("DP_SPOT", ref varStr);
                if (lReturn != 0)
                {
                    //ReportError(lReturn, "buttonSpotModeSwitch", "Get Value");
                    MessageBox.Show("Error getting the spot mode state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string SpotModeState = varStr.ToString(); //Initialize the string variable for the state. Returns "On" or "Off"

                if (SpotModeState == "On")
                {
                    object SpotStateTarget = new VariantWrapper("Off"); //If spot mode is on, turn it off and refresh the corresponding display.
                    long lReturnSwitch = CZEMApi.Set("DP_SPOT", SpotStateTarget);

                    if (lReturnSwitch != 0)
                    {
                        //ReportError(lReturn, "buttonSpotModeSwitch", "Set Value");
                        MessageBox.Show("Error setting the state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (lReturnSwitch == 0)
                    {
                        MessageBox.Show("Spot Mode switched off", "Spot Mode Switch", MessageBoxButtons.OK);
                        UpdateStatus("DP_SPOT");
                    }
                    
                }
                else
                {
                    object SpotStateTarget = new VariantWrapper("On"); //If spot mode is off, turn it on and refresh the corresponding display.
                    long lReturnSwitch = CZEMApi.Set("DP_SPOT", SpotStateTarget);

                    if (lReturnSwitch != 0)
                    {
                        //ReportError(lReturn, "buttonSpotModeSwitch", "Set Value");
                        MessageBox.Show("Error getting the state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (lReturnSwitch == 0)
                    {
                        MessageBox.Show("Spot Mode switched on", "Spot Mode Switch", MessageBoxButtons.OK);
                        UpdateStatus("DP_SPOT");
                    }
                }
            }
            else
                MessageBox.Show("API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonXScanGrabPixelValue_Click(object sender, EventArgs e)
        {
            if (apiInitialised)
            {
                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vValueY = new VariantWrapper((float)0.0f);

                // Get parameter limits numeric values 
                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);
                ReportError(lReplyX, "XScanGrabPixelValue", "Get Limits");

                long lReplyY = CZEMApi.Get("AP_SPOT_POSN_Y", ref vValueY);

                int vValueX_Max = int.Parse(vMaxValueX.ToString());
                ReportError(lReplyY, "XScanGrabPixelValue", "Set Value");

                if(lReplyY == 0)
                {
                    string pixelfilename = Path.Combine(textBoxFrameGrabDirectory.Text, "XScanPixelValues.txt");

                    DialogResult res = MessageBox.Show("Beam position limits successfully read. " +
                        $"X Limits: {vMinValueX}-{vMaxValueX}, Y Position: {vValueY}" +
                        $"\nText File will be saved at: {pixelfilename} " +
                        "\nLine scan will start in 1 seconds after clicking OK. Please check SmartSEM.", "Confirm Scan", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.No)
                        return;

                    Thread.Sleep(1000);

                    // Progress bar control
                    progressBarScan.Visible = true;
                    progressBarScan.Minimum = 0;
                    progressBarScan.Maximum = vValueX_Max + 2;
                    progressBarScan.Value = 0;
                    progressBarScan.Step = 1;

                    // Create a list of strings to store the pixel-by-pixel grayscale values.
                    List<string> pixelvaluearray = new List<string>();

                    for (int XPos = 0; XPos <= vValueX_Max; XPos++)
                    {
                        object XPos_loop = new VariantWrapper(XPos.ToString());
                        object spotvalue = new VariantWrapper((float)0.0f);
                        long lReply_XPos = CZEMApi.Set("AP_SPOT_POSN_X", ref XPos_loop);

                        ReportError(lReply_XPos, "XScanGrabPixelValue", "Set Value");

                        if (lReply_XPos == 0)
                        {
                            long lReplyspotvalue = CZEMApi.Get("AP_SPOT", ref spotvalue);
                            ReportError(lReply_XPos, "XScanGrabPixelValue-AP_SPOT", "Get Value");
                            if (lReplyspotvalue == 0)
                                pixelvaluearray.Add(spotvalue.ToString());
                            progressBarScan.PerformStep();
                        }

                    }

                    File.WriteAllLines(pixelfilename, pixelvaluearray);
                    progressBarScan.PerformStep();
                    
                    MessageBox.Show("Scan Complete! File saved at:" + pixelfilename, "Scan Complete", MessageBoxButtons.OK);
                    textBoxSetNotify.Text += "Scan Complete! File saved at:" + pixelfilename;
                    progressBarScan.Value = 0;
                }

            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private async void buttonMagMap_Click(object sender, EventArgs e)
        {
            // This function reads the pixel size at different magnifications and write it to a text file
            if (apiInitialised)
            {
                object vMagMin = new VariantWrapper((float)0.0f);
                object vMagMax = new VariantWrapper((float)0.0f);
                //object vMag = new VariantWrapper("");
                

                long lReplyGetMagLimits = CZEMApi.GetLimits("AP_MAG", ref vMagMin, ref vMagMax);

                string magmapfilename = Path.Combine(textBoxFrameGrabDirectory.Text, "magmapvalues.txt");

                int MinMag = int.Parse(vMagMin.ToString());
                //int MinMag = 100;
                //int MaxMag = 100000;
                int MaxMag = int.Parse(vMagMax.ToString());

                object vMinMag = new VariantWrapper(vMagMin.ToString());

                if((ZeissErrorCode)lReplyGetMagLimits == ZeissErrorCode.API_E_NO_ERROR)
                {
                    long lReplySetMagMin = CZEMApi.Set("AP_MAG", ref vMinMag);

                    ReportError(lReplySetMagMin, "MagmMap_SetMagMin", "Set Value");

                    if ((ZeissErrorCode)lReplySetMagMin == ZeissErrorCode.API_E_NO_ERROR)
                    {
                        DialogResult res = MessageBox.Show("Profiling of magnification and pixel size will start in 1 seconds after clicking OK. " +
                                    "Please check SmartSEM.", "Confirm Profiling", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.Cancel)
                            return;

                        Thread.Sleep(1000);
                        //// Progress bar control
                        progressBarScan.Visible = true;
                        progressBarScan.Minimum = 0;
                        progressBarScan.Maximum = 200000;
                        progressBarScan.Value = MinMag;
                        progressBarScan.Step = 20;

                        List<string> magsizearray = new List<string>();

                        _canceller = new CancellationTokenSource();

                        int Mag = MinMag;

                        await TaskEx.Run(() =>
                        {
                            do
                            {
                                object Mag_loop = new VariantWrapper(Mag.ToString());

                                long lReplySetMag = CZEMApi.Set("AP_Mag", ref Mag_loop);
                                if ((ZeissErrorCode)lReplySetMag != ZeissErrorCode.API_E_NO_ERROR)
                                {
                                    ReportError(lReplySetMag, "MagMap", "Set Value");
                                    return;
                                }

                                object vPixelSize = new VariantWrapper((float)0.0f);

                                long lReplyGetPixelSize = CZEMApi.Get("AP_PIXEL_SIZE", ref vPixelSize);

                                if (lReplyGetPixelSize == 0)
                                {
                                    magsizearray.Add(Mag_loop.ToString());
                                    magsizearray.Add(vPixelSize.ToString());
                                }

                                Thread.Sleep(20);
                                Mag += 20;

                                progressBarScan.Invoke(new Action(() =>
                                {
                                    progressBarScan.PerformStep();
                                }));

                            } while (Mag <= 200000);

                            if (Mag > 200000)
                                SetTextSetNotify("Magnification mapping complete!\r\n");

                            _canceller.Dispose();
                        });

                        File.WriteAllLines(magmapfilename, magsizearray);
                        MessageBox.Show("Scan complete! Press OK to continue.", "Scan complete", MessageBoxButtons.OK);
                        //progressBarScan.Value = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Below are functions using the DED. At the moment they are crude.
        // By simply calling the Python excecutioner to run py functions.
        // They will be replaced by more efficient or elegant scripts.
        private void buttonPIXETVersion_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\tianbi\Documents\DED_script_new\VersionCheck.py";//later replace with env variable or similar in preamble

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\tianbi\AppData\Local\Programs\Python\Python37\python.exe", fileName)
            {
                //later replace python directory with env variable or similar
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            textBoxDEDConsole.Text += output;
        }

        private void buttonDEDSingleSaveBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBoxDEDDirectory.Text = dlg.SelectedPath;
            }
        }

        private void buttonDEDThSweep_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\tianbi\Documents\DED_script_new\Threshold_trial.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\tianbi\AppData\Local\Programs\Python\Python37\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            textBoxDEDConsole.Text += output;
        }

        private void buttonCheckDEDConnection_Click(object sender, EventArgs e)
        {
            textBoxDEDConsole.Text+= "Detecting connected DEDs..." + "\r\n";

            string fileName = @"C:\Users\tianbi\Documents\DED_script_new\DeviceConnectionCheck.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\tianbi\AppData\Local\Programs\Python\Python37\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            //textBoxDEDConsole.Text += "\n";
            textBoxDEDConsole.Text += output;
        }

        private void buttonDEDSingleTrialCapture_Click(object sender, EventArgs e)
        {
            // This is a demonstration function
            // This function performs a single DED integral capture using pre-defined parameters:
            // 20 keV threshold, 10 frames integral and 0.05s per frame. 

            DialogResult res = MessageBox.Show("Trial capture will apply default parameters..." +
                "20 keV threshold, 10 frames integral and 0.05s per frame. " +
                "Event and iToT data will be recorded. " +
                "Click OK to continue.", "Trial Capture", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel)
                return;

            string fileName = @"C:\Users\tianbi\Documents\DED_script_new\TrialAcquisition.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\tianbi\AppData\Local\Programs\Python\Python37\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
                //Arguments = string.Format("D:\\script\\test.py -a {0} -b {1} ", "some param", "some other param");
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            textBoxDEDConsole.Text += output;

        }

        // Define a public function for grabbing DED frame using given DED parameters. This saves coding spaces...
        public void DEDSingleCapture(string ded_threshold, string ded_bias, string int_framecount, string int_frametime, string identifier, string directory)
        {
            string filename = @"C:\Users\tianbi\Documents\DED_script_new\IntFrameGrab.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\tianbi\AppData\Local\Programs\Python\Python37\python.exe", filename)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                //Arguments = string.Format("D:\\script\\test.py -a {0} -b {1} ", "some param", "some other param")
                //Arguments = $"\"{filename}\"\"{ded_threshold}\"\"{ded_bias}\"\"{int_framecount}\"\"{int_frametime}\"\"{identifier}\"\""
                Arguments = string.Format("{0} {1} {2} {3} {4} {5} {6}", filename, ded_threshold, ded_bias, int_framecount, int_frametime, identifier, directory)
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();
            p.WaitForExit();

            SetTextDEDConsole(error);
            SetTextDEDConsole(output);
        }

        private void buttonDEDSingleCapture_Click(object sender, EventArgs e)
        {
            // This function reads the DED settings from user inputs and performs an integral capture.
            // Currently, this is done by excecuting a python script that performs the task and grabbing the output messages to
            // the C# process (i.e. this program).

            var watch = new Stopwatch();

            watch.Start();
            
            string pathname = textBoxDEDDirectory.Text;
            
            string identifier = textBoxDEDSingleIdentifier.Text;
            string ded_threshold = textBoxDEDSingleTh.Text;
            string ded_bias = textBoxDEDSingleBias.Text;
            string int_framecount = textBoxDEDSingleIntFrameCount.Text;
            string int_frametime = textBoxDEDSingleFrameTime.Text;

            //Pattern will be saved as "identifier_th_bias_framesxframetime.h5".

            string directory = textBoxDEDDirectory.Text;

            DEDSingleCapture(ded_threshold, ded_bias, int_framecount, int_frametime, identifier, directory);

            watch.Stop();
            // add time statistics

            double estimated_time = Convert.ToInt16(int_framecount) * Convert.ToDouble(int_frametime);

            textBoxDEDConsole.Text += $"Total time: {watch.ElapsedMilliseconds} ms";

        }

        private void buttonDEDShowThBias_Click(object sender, EventArgs e)
        {
            // This function reads the threshold and bias settings of the DED and output them to the DED console.
            // Currently, this is done by excecuting a python script that performs the task and grabbing the output messages to
            // the C# process (i.e. this program).

            string fileName = @"C:\Users\tianbi\Documents\DED_script_new\ReadThBias.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\tianbi\AppData\Local\Programs\Python\Python37\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
                //Arguments = string.Format("D:\\script\\test.py -a {0} -b {1} ", "some param", "some other param");
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            textBoxDEDConsole.Text += output;
        }

        private async void buttonDEDFullFrameGrid_Click(object sender, EventArgs e)
        {
            // This function performs beam scan and DED capture over the entire visible frame.

            if (apiInitialised)
            {
                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vMinValueY = new VariantWrapper((float)0.0f);
                object vMaxValueY = new VariantWrapper((float)0.0f);
                object vValueMag = new VariantWrapper((float)0.0f);
                object vValueSpotSize = new VariantWrapper((float)0.0f);

                // Get parameter limits numeric values 
                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);
                long lReplyY = CZEMApi.GetLimits("AP_SPOT_POSN_Y", ref vMinValueY, ref vMaxValueY);
                long lReplyMag = CZEMApi.Get("AP_MAG", ref vValueMag);
                long lReplySpotSize = CZEMApi.Get("AP_PIXEL_SIZE", ref vValueSpotSize);
                int vValueX_Max = int.Parse(vMaxValueX.ToString());
                int vValueY_Max = int.Parse(vMaxValueY.ToString());

                //string identifier = textBoxDEDSingleIdentifier.Text;
                string ded_threshold = textBoxDEDSingleTh.Text;
                string ded_bias = textBoxDEDSingleBias.Text;
                string int_framecount = textBoxDEDSingleIntFrameCount.Text;
                string int_frametime = textBoxDEDSingleFrameTime.Text;

                if ((ZeissErrorCode)lReplyX == ZeissErrorCode.API_E_NO_ERROR && (ZeissErrorCode)lReplyY == ZeissErrorCode.API_E_NO_ERROR)
                {
                    MessageBox.Show("Frame Size X-Y: " + vMaxValueX.ToString() + "x" + vMaxValueY.ToString() + ". Magnification=" + vValueMag.ToString() + ", pixel/step size =" + vValueSpotSize.ToString() + " m.\n Full frame scan will start in 1 seconds after clicking OK. Please check SmartSEM window.");
                    Thread.Sleep(1000);
                    // Progress bar control
                    progressBarScan.Visible = true;
                    progressBarScan.Minimum = 0;
                    progressBarScan.Maximum = (vValueX_Max + 1) * (vValueY_Max + 1);
                    progressBarScan.Value = 0;
                    progressBarScan.Step = 1;

                    int identifier_number = 0;

                    string directory = textBoxDEDDirectory.Text;

                    bool breakloop = false;

                    _canceller = new CancellationTokenSource();

                    await TaskEx.Run(() =>
                    {
                        for (int YPos = 0; YPos <= vValueY_Max; YPos++)
                        {
                            if (breakloop)
                                goto LoopEnd;

                            object YPos_loop = new VariantWrapper(YPos.ToString());

                            long lReply_YPos = CZEMApi.Set("AP_SPOT_POSN_Y", ref YPos_loop);

                            if (lReply_YPos != 0)
                            {
                                ReportError(lReply_YPos, "XYBeamScan_Set X", "Set Value");
                                goto LoopError;
                            }
                            // Show the value, or an error message in case of an error

                            for (int XPos = 0; XPos <= vValueX_Max; XPos++)
                            {
                                object XPos_loop = new VariantWrapper(XPos.ToString());

                                long lReply_XPos = CZEMApi.Set("AP_SPOT_POSN_X", ref XPos_loop);

                                if (lReply_XPos != 0)
                                {
                                    ReportError(lReply_XPos, "XYBeamScan_Set X", "Set Value");
                                    return;
                                }

                                string identifier = "Spot" + identifier_number.ToString();

                                SetTextDEDConsole($"Capturing {identifier}");

                                DEDSingleCapture(ded_threshold, ded_bias, int_framecount, int_frametime, identifier, directory);

                                identifier_number++;

                                progressBarScan.Invoke(new Action(() =>
                                {
                                    progressBarScan.PerformStep();
                                }));

                                if (_canceller.Token.IsCancellationRequested)
                                {
                                    breakloop = true;
                                    break;
                                }
                            }

                        }
                        _canceller.Dispose();
                    LoopEnd:
                        {
                            SetTextDEDConsole("Process terminated by user (\"Abort\" pressed). \r\n");
                            return;
                        }
                    LoopError:
                        {
                            SetTextDEDConsole("Process terminated due to Error. \r\n");
                            return;
                        }
                    });

                    MessageBox.Show("Scan complete!", "Scan Complete", MessageBoxButtons.OK);
                    progressBarScan.Value = 0;
                }
                else
                    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDEDSelectedGrid_Click(object sender, EventArgs e)
        {
            // This function performs beam scan and DED capture over a user defined pixel grid. 
            // Limits of the grid and DED parameters are read from user input in text boxes.
            
            if (apiInitialised)
            {
                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vMinValueY = new VariantWrapper((float)0.0f);
                object vMaxValueY = new VariantWrapper((float)0.0f);
                object vValueMag = new VariantWrapper((float)0.0f);
                object vValueSpotSize = new VariantWrapper((float)0.0f);

                // Get parameter limits numeric values 
                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);
                long lReplyY = CZEMApi.GetLimits("AP_SPOT_POSN_Y", ref vMinValueY, ref vMaxValueY);
                long lReplyMag = CZEMApi.Get("AP_MAG", ref vValueMag);
                long lReplySpotSize = CZEMApi.Get("AP_PIXEL_SIZE", ref vValueSpotSize);
                int vValueX_Min = int.Parse(vMinValueX.ToString());
                int vValueY_Min = int.Parse(vMinValueY.ToString());
                int vValueX_Max = int.Parse(vMaxValueX.ToString());
                int vValueY_Max = int.Parse(vMaxValueY.ToString());

                
                try
                {
                    int InputXMinCheck = int.Parse(textBoxDEDSelectedXMin.Text);
                    int InputYMinCheck = int.Parse(textBoxDEDSelectedYMin.Text);
                    int InputXMaxCheck = int.Parse(textBoxDEDSelectedXMax.Text);
                    int InputYMaxCheck = int.Parse(textBoxDEDSelectedYMax.Text);

                    if (InputXMinCheck < vValueX_Min || InputYMinCheck < vValueY_Min || InputXMaxCheck > vValueX_Max || InputYMaxCheck > vValueY_Max)
                    {
                        MessageBox.Show($"Error: Please check your limit inputs. X must be within {vValueX_Min} and {vValueX_Max}," +
                            $"and Y must be within {vValueY_Min} and {vValueY_Max}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show($"Error: Your inputs are invalid. X must be within {vValueX_Min} and {vValueX_Max}," +
                            $"and Y must be within {vValueY_Min} and {vValueY_Max}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //throw new System.FormatException("The input format for one of the range parameters is wrong");
                }

                int InputXMin = int.Parse(textBoxDEDSelectedXMin.Text);
                int InputYMin = int.Parse(textBoxDEDSelectedYMin.Text);
                int InputXMax = int.Parse(textBoxDEDSelectedXMax.Text);
                int InputYMax = int.Parse(textBoxDEDSelectedYMax.Text);

                string ded_threshold = textBoxDEDSingleTh.Text;
                string ded_bias = textBoxDEDSingleBias.Text;
                string int_framecount = textBoxDEDSingleIntFrameCount.Text;
                string int_frametime = textBoxDEDSingleFrameTime.Text;

                if ((ZeissErrorCode)lReplyX == ZeissErrorCode.API_E_NO_ERROR && (ZeissErrorCode)lReplyY == ZeissErrorCode.API_E_NO_ERROR)
                {
                    DialogResult res = MessageBox.Show($"Frame Size X-Y: {InputXMax - InputXMin + 1}x{InputYMax - InputYMin + 1}. Magnification= {vValueMag}, pixel/step size ={vValueSpotSize} m." +
                        $" \n Full frame scan will start in 1 seconds after clicking OK. Please check SmartSEM window.", "Confirm Scan", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.Cancel)
                        return;

                    Thread.Sleep(1000);
                    // Progress bar control
                    //progressBarScan.Visible = true;
                    //progressBarScan.Minimum = 0;
                    //progressBarScan.Maximum = (InputXMax - InputXMin + 1) * (InputYMax - InputYMin + 1);
                    //progressBarScan.Value = 0;
                    //progressBarScan.Step = 1;                    

                    int identifier_number = 1;
                    int total_points = (InputXMax - InputXMin + 1) * (InputYMax - InputYMin + 1);
                    string directory = textBoxDEDDirectory.Text;
                    
                    _canceller = new CancellationTokenSource();
                    bool breakloop = false;

                    var watch = new Stopwatch();
                    watch.Start();

                    await TaskEx.Run(() =>
                    {
                        for (int YPos = InputYMin; YPos <= InputYMax; YPos++)
                        {
                            if (breakloop)
                                break;

                            object YPos_loop = new VariantWrapper(YPos.ToString());

                            long lReply_YPos = CZEMApi.Set("AP_SPOT_POSN_Y", ref YPos_loop);

                            if (lReply_YPos != 0)
                            {
                                ReportError(lReply_YPos, "XYBeamScan_Set X", "Set Value");
                                breakloop = true;
                                SetTextDEDConsole("Process terminated due to error. \r\n");
                                break;
                            }
                            // Show the value, or an error message in case of an error

                            for (int XPos = InputXMin; XPos <= InputXMax; XPos++)
                            {
                                object XPos_loop = new VariantWrapper(XPos.ToString());

                                long lReply_XPos = CZEMApi.Set("AP_SPOT_POSN_X", ref XPos_loop);

                                if (lReply_XPos != 0)
                                {
                                    ReportError(lReply_XPos, "XYBeamScan_Set X", "Set Value");
                                    breakloop = true;
                                    SetTextDEDConsole("Process terminated due to error. \r\n");
                                    break;
                                }

                                string identifier = "Spot" + identifier_number.ToString();

                                SetTextDEDConsole($"Capturing {identifier}");

                                DEDSingleCapture(ded_threshold, ded_bias, int_framecount, int_frametime, identifier, directory);

                                SetTextDEDConsole($"Spot {identifier_number}/{total_points} done!");
                                
                                identifier_number++;

                                progressBarScan.Invoke(new Action(() =>
                                {
                                    progressBarScan.PerformStep();
                                }));

                                Thread.Sleep(250);

                                if (_canceller.Token.IsCancellationRequested)
                                {
                                    breakloop = true;
                                    SetTextDEDConsole("Process terminated by user (\"Abort\" pressed). \r\n");
                                    break;
                                }
                            }

                        }
                        _canceller.Dispose();
                    });

                    watch.Stop();

                    SetTextDEDConsole($"Scan complete! Total time is {watch.ElapsedMilliseconds / 1000} s");
                    MessageBox.Show("Scan complete!", "Scan Complete", MessageBoxButtons.OK);
                    //progressBarScan.Value = 0;
                }
                else
                    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDEDGridRecParams_Click(object sender, EventArgs e)
        {
            // This function reads frame size, total pixels in the grid, SEM info (mag, pixel size, stage positions) and DED parameters
            // and write them line by line to a text file called Scan_Parameters.txt in the specified directory.
            // Output order is: X Min, X Max, Y Min, Y Max, total number of pixels, magnification, pixel size (in m),...
            // ... stage positions X, Y, Z (in mm), DED threshold, DED bias, DED number of frames, DED frame time.
            if (apiInitialised)
            {

                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vMinValueY = new VariantWrapper((float)0.0f);
                object vMaxValueY = new VariantWrapper((float)0.0f);

                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);
                long lReplyY = CZEMApi.GetLimits("AP_SPOT_POSN_Y", ref vMinValueY, ref vMaxValueY);

                int vValueX_Min = int.Parse(vMinValueX.ToString());
                int vValueY_Min = int.Parse(vMinValueY.ToString());
                int vValueX_Max = int.Parse(vMaxValueX.ToString());
                int vValueY_Max = int.Parse(vMaxValueY.ToString());

                int outputXMin, outputXMax, outputYMin, outputYMax;
                //int outputXMin = 0 , outputXMax = 0, outputYMin = 0, outputYMax = 0;

                DialogResult fullframescan = MessageBox.Show("Is this a full frame scan? Click \"Yes\" for full frame scan," +
                    " \"No\" for selected area scan", "Confirm Scan Type", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch ((DialogResult)fullframescan)
                {
                    case DialogResult.Yes:
                        {
                            outputXMin = vValueX_Min;
                            outputXMax = vValueX_Max;
                            outputYMin = vValueY_Min;
                            outputYMax = vValueY_Max;
                            break;
                        }
                    case DialogResult.No:
                        {
                            try
                            {
                                int InputXMinCheck = int.Parse(textBoxDEDSelectedXMin.Text);
                                int InputYMinCheck = int.Parse(textBoxDEDSelectedYMin.Text);
                                int InputXMaxCheck = int.Parse(textBoxDEDSelectedXMax.Text);
                                int InputYMaxCheck = int.Parse(textBoxDEDSelectedYMax.Text);

                                if (InputXMinCheck < vValueX_Min || InputYMinCheck < vValueY_Min || InputXMaxCheck > vValueX_Max || InputYMaxCheck > vValueY_Max)
                                {
                                    MessageBox.Show($"Error: Please check your limit inputs. X must be within {vValueX_Min} and {vValueX_Max}," +
                                        $"and Y must be within {vValueY_Min} and {vValueY_Max}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            catch (System.FormatException)
                            {
                                MessageBox.Show($"Error: Your inputs are invalid. X must be within {vValueX_Min} and {vValueX_Max}," +
                                        $"and Y must be within {vValueY_Min} and {vValueY_Max}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                                //throw new System.FormatException("The input format for one of the range parameters is wrong");
                            }

                            outputXMin = int.Parse(textBoxDEDSelectedXMin.Text);
                            outputYMin = int.Parse(textBoxDEDSelectedYMin.Text);
                            outputXMax = int.Parse(textBoxDEDSelectedXMax.Text);
                            outputYMax = int.Parse(textBoxDEDSelectedYMax.Text);
                            break;
                        }
                    case DialogResult.Cancel:
                        return;
                    default:
                        return;
                }

                int total_points = (outputXMax - outputXMin + 1) * (outputYMax - outputYMin + 1);

                object vValueMag = new VariantWrapper((float)0.0f);
                object vValueSpotSize = new VariantWrapper((float)0.0f);
                object vValueStageX = new VariantWrapper((float)0.0f);
                object vValueStageY = new VariantWrapper((float)0.0f);
                object vValueStageZ = new VariantWrapper((float)0.0f);

                // Get magnification, pixel size and stage positions 

                long lReplyMag = CZEMApi.Get("AP_MAG", ref vValueMag);
                long lReplySpotSize = CZEMApi.Get("AP_PIXEL_SIZE", ref vValueSpotSize);
                long lReplyStageX = CZEMApi.Get("AP_STAGE_AT_X", ref vValueStageX);
                long lReplyStageY = CZEMApi.Get("AP_STAGE_AT_Y", ref vValueStageY);
                long lReplyStageZ = CZEMApi.Get("AP_STAGE_AT_Z", ref vValueStageZ);

                // Read input DED parameters

                string ded_threshold = textBoxDEDSingleTh.Text;
                string ded_bias = textBoxDEDSingleBias.Text;
                string int_framecount = textBoxDEDSingleIntFrameCount.Text;
                string int_frametime = textBoxDEDSingleFrameTime.Text;

                List<string> params_array = new List<string>();
                params_array.Add(outputXMin.ToString());
                params_array.Add(outputXMax.ToString());
                params_array.Add(outputYMin.ToString());
                params_array.Add(outputYMax.ToString());
                params_array.Add(total_points.ToString());
                params_array.Add(vValueMag.ToString());
                params_array.Add(vValueSpotSize.ToString());
                params_array.Add(vValueStageX.ToString());
                params_array.Add(vValueStageY.ToString());
                params_array.Add(vValueStageZ.ToString());
                params_array.Add(ded_threshold);
                params_array.Add(ded_bias);
                params_array.Add(int_framecount);
                params_array.Add(int_frametime);

                string paramsfilename = Path.Combine(textBoxDEDDirectory.Text, "Scan_Parameters.txt");


                try
                {
                    File.WriteAllLines(paramsfilename, params_array);
                }
                catch (IOException)
                {
                    MessageBox.Show($"Error: the input directory is invalid. This is usually because you don't have the required" +
                        $"reading or writing privileges. Please avoid hard disk root directories (e.g. C:/).",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //throw new System.FormatException("The input format for one of the range parameters is wrong");
                }

                MessageBox.Show($"Parameters saved to {paramsfilename}", "File Saved");


            }
            else
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DEDTemperatureRead_Click(object sender, EventArgs e)
        {
            // This function reads the threshold and bias settings of the DED and output them to the DED console.
            // Currently, this is done by excecuting a python script that performs the task and grabbing the output messages to
            // the C# process (i.e. this program).

            string fileName = @"C:\Users\tianbi\Documents\DED_script_new\ReadTemperature.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\tianbi\AppData\Local\Programs\Python\Python37\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
                //Arguments = string.Format("D:\\script\\test.py -a {0} -b {1} ", "some param", "some other param");
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            textBoxDEDConsole.Text += output;
        }

        private async void buttonDEDSelectedGridMouse_Click(object sender, EventArgs e)
        {
            // This function performs beam scan and DED capture over a user defined pixel grid. 
            // Limits of the grid and DED parameters are read from user input in text boxes.
            if (!ButtonCoordsSet)
            {
                MessageBox.Show($"Error: mouse coordinates not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (apiInitialised)
            {
                object vMinValueX = new VariantWrapper((float)0.0f);
                object vMaxValueX = new VariantWrapper((float)0.0f);
                object vMinValueY = new VariantWrapper((float)0.0f);
                object vMaxValueY = new VariantWrapper((float)0.0f);
                object vValueMag = new VariantWrapper((float)0.0f);
                object vValueSpotSize = new VariantWrapper((float)0.0f);

                // Get parameter limits numeric values 
                long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);
                long lReplyY = CZEMApi.GetLimits("AP_SPOT_POSN_Y", ref vMinValueY, ref vMaxValueY);
                long lReplyMag = CZEMApi.Get("AP_MAG", ref vValueMag);
                long lReplySpotSize = CZEMApi.Get("AP_PIXEL_SIZE", ref vValueSpotSize);
                int vValueX_Min = int.Parse(vMinValueX.ToString());
                int vValueY_Min = int.Parse(vMinValueY.ToString());
                int vValueX_Max = int.Parse(vMaxValueX.ToString());
                int vValueY_Max = int.Parse(vMaxValueY.ToString());


                try
                {
                    int InputXMinCheck = int.Parse(textBoxDEDSelectedXMin.Text);
                    int InputYMinCheck = int.Parse(textBoxDEDSelectedYMin.Text);
                    int InputXMaxCheck = int.Parse(textBoxDEDSelectedXMax.Text);
                    int InputYMaxCheck = int.Parse(textBoxDEDSelectedYMax.Text);

                    if (InputXMinCheck < vValueX_Min || InputYMinCheck < vValueY_Min || InputXMaxCheck > vValueX_Max || InputYMaxCheck > vValueY_Max)
                    {
                        MessageBox.Show($"Error: Please check your limit inputs. X must be within {vValueX_Min} and {vValueX_Max}," +
                            $"and Y must be within {vValueY_Min} and {vValueY_Max}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show($"Error: Your inputs are invalid. X must be within {vValueX_Min} and {vValueX_Max}," +
                            $"and Y must be within {vValueY_Min} and {vValueY_Max}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //throw new System.FormatException("The input format for one of the range parameters is wrong");
                }

                int InputXMin = int.Parse(textBoxDEDSelectedXMin.Text);
                int InputYMin = int.Parse(textBoxDEDSelectedYMin.Text);
                int InputXMax = int.Parse(textBoxDEDSelectedXMax.Text);
                int InputYMax = int.Parse(textBoxDEDSelectedYMax.Text);

                int total_points = (InputXMax - InputXMin + 1) * (InputYMax - InputYMin + 1);

                if ((ZeissErrorCode)lReplyX == ZeissErrorCode.API_E_NO_ERROR && (ZeissErrorCode)lReplyY == ZeissErrorCode.API_E_NO_ERROR)
                {
                    DialogResult res = MessageBox.Show($"Frame Size X-Y: {InputXMax - InputXMin + 1}x{InputYMax - InputYMin + 1}. Magnification= {vValueMag}, pixel/step size ={vValueSpotSize} m." +
                        $" \n Full frame scan will start in 1 seconds after clicking OK. Please check SmartSEM window.", "Confirm Scan", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.Cancel)
                        return;

                    Thread.Sleep(1000);
                    // Progress bar control
                    progressBarScan.Visible = true;
                    progressBarScan.Minimum = 0;
                    progressBarScan.Maximum = (InputXMax - InputXMin + 1) * (InputYMax - InputYMin + 1);
                    progressBarScan.Value = 0;
                    progressBarScan.Step = 1;

                    int identifier_number = 1;                    
                    string directory = textBoxDEDDirectory.Text;
                    this.Cursor = new Cursor(Cursor.Current.Handle);
                    int wait_time = Convert.ToInt32(numericUpDownClickWait.Value * 1000); //miliseconds

                    _canceller = new CancellationTokenSource();
                    bool breakloop = false;

                    var watch = new Stopwatch();
                    watch.Start();

                    await TaskEx.Run(() =>
                    {
                        for (int YPos = InputYMin; YPos <= InputYMax; YPos++)
                        {
                            if (breakloop)
                                break;

                            object YPos_loop = new VariantWrapper(YPos.ToString());

                            long lReply_YPos = CZEMApi.Set("AP_SPOT_POSN_Y", ref YPos_loop);

                            if (lReply_YPos != 0)
                            {
                                ReportError(lReply_YPos, "XYBeamScan_Set X", "Set Value");
                                breakloop = true;
                                SetTextDEDConsole("Process terminated due to error. \r\n");
                                break;
                            }
                            // Show the value, or an error message in case of an error

                            for (int XPos = InputXMin; XPos <= InputXMax; XPos++)
                            {
                                object XPos_loop = new VariantWrapper(XPos.ToString());

                                long lReply_XPos = CZEMApi.Set("AP_SPOT_POSN_X", ref XPos_loop);

                                if (lReply_XPos != 0)
                                {
                                    ReportError(lReply_XPos, "XYBeamScan_Set X", "Set Value");
                                    breakloop = true;
                                    SetTextDEDConsole("Process terminated due to error. \r\n");
                                    break;
                                }

                                string identifier = "Spot" + identifier_number.ToString();

                                SetTextDEDConsole($"Capturing {identifier}");

                                ClickPosition(PositionButton, wait_time);

                                SetTextDEDConsole($"Spot {identifier_number}/{total_points} done!");

                                identifier_number++;

                                progressBarScan.Invoke(new Action(() =>
                                {
                                    progressBarScan.PerformStep();
                                }));

                                Thread.Sleep(250);

                                if (_canceller.Token.IsCancellationRequested)
                                {
                                    breakloop = true;
                                    SetTextDEDConsole("Process terminated by user (\"Abort\" pressed). \r\n");
                                    break;
                                }
                            }

                        }
                        _canceller.Dispose();
                    });

                    watch.Stop();

                    SetTextDEDConsole($"Scan complete! Total time is {watch.ElapsedMilliseconds / 1000} s");
                    MessageBox.Show("Scan complete!", "Scan Complete", MessageBoxButtons.OK);
                    //progressBarScan.Value = 0;
                }
                else
                    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Remote API not initialised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Point PositionButton = new Point(0, 0);
        bool ButtonCoordsSet = false;

        private void buttonReadCoords_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Thread.Sleep(3000);

            PositionButton.X = Cursor.Position.X;
            PositionButton.Y = Cursor.Position.Y;

            textBoxMouseCoords.Text = PositionButton.ToString();
            textBoxMouseCoords.BackColor = Color.ForestGreen;

            ButtonCoordsSet = true;

            textBoxDEDConsole.Text += "Button to click: " + PositionButton.ToString();
            textBoxDEDConsole.Text += "\r\n";
        }


        public class MyMouse : Mouse
        {

        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_MOVE = 0x0001;


        public void DoMouseClick()
        {
            //perform click            
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(100);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        int mouseclickwait = 200;
        public void ClickPosition(Point position, int waittime)
        {
            Cursor.Position = position;
            Thread.Sleep(mouseclickwait);
            DoMouseClick();
            Thread.Sleep(waittime);
        }
    }

}