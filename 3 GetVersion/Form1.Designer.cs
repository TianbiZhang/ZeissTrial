namespace ZeissTrial
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetCZEMApiVersion = new System.Windows.Forms.Button();
            this.buttonInitialiseCZEMApi = new System.Windows.Forms.Button();
            this.buttonGetBeamPosnLimits = new System.Windows.Forms.Button();
            this.buttonXBeamScan = new System.Windows.Forms.Button();
            this.buttonSetMag = new System.Windows.Forms.Button();
            this.textBoxEnterMag = new System.Windows.Forms.TextBox();
            this.labelEnterMag = new System.Windows.Forms.Label();
            this.labelPreamble = new System.Windows.Forms.Label();
            this.labelSetMagPrompt = new System.Windows.Forms.Label();
            this.labelXBeamScan = new System.Windows.Forms.Label();
            this.buttonXYBeamScan = new System.Windows.Forms.Button();
            this.labelCloseControls = new System.Windows.Forms.Label();
            this.buttonCloseControl = new System.Windows.Forms.Button();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.textBoxStageZ = new System.Windows.Forms.TextBox();
            this.textBoxStageY = new System.Windows.Forms.TextBox();
            this.textBoxStageX = new System.Windows.Forms.TextBox();
            this.textBoxHighCurrent = new System.Windows.Forms.TextBox();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.textBoxApertureSize = new System.Windows.Forms.TextBox();
            this.textBoxDetectorChannel = new System.Windows.Forms.TextBox();
            this.textBoxDetectorType = new System.Windows.Forms.TextBox();
            this.textBoxWD = new System.Windows.Forms.TextBox();
            this.textBoxPixelSize = new System.Windows.Forms.TextBox();
            this.textBoxMag = new System.Windows.Forms.TextBox();
            this.textBoxScanrate = new System.Windows.Forms.TextBox();
            this.textBoxSpotMode = new System.Windows.Forms.TextBox();
            this.textBoxIprobe = new System.Windows.Forms.TextBox();
            this.textBoxActualCurrent = new System.Windows.Forms.TextBox();
            this.textBoxActualkv = new System.Windows.Forms.TextBox();
            this.textBoxRunupstate = new System.Windows.Forms.TextBox();
            this.textBoxVacStatus = new System.Windows.Forms.TextBox();
            this.textBoxInit = new System.Windows.Forms.TextBox();
            this.labelScanProgressBar = new System.Windows.Forms.Label();
            this.progressBarScan = new System.Windows.Forms.ProgressBar();
            this.groupBoxDebugUpperRight = new System.Windows.Forms.GroupBox();
            this.buttonMagMap = new System.Windows.Forms.Button();
            this.buttonXScanGrabPixelValue = new System.Windows.Forms.Button();
            this.groupBoxInitialize = new System.Windows.Forms.GroupBox();
            this.buttonInitializeRemote = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonRefreshParams = new System.Windows.Forms.Button();
            this.groupBoxFrameGrab = new System.Windows.Forms.GroupBox();
            this.labelFrameGrabFileNamePart2 = new System.Windows.Forms.Label();
            this.labelFrameGrabFileName = new System.Windows.Forms.Label();
            this.textBoxFrameGrabFileName = new System.Windows.Forms.TextBox();
            this.buttonGrabPixelValue = new System.Windows.Forms.Button();
            this.textBoxFrameGrabDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowseFrameGrab = new System.Windows.Forms.Button();
            this.buttonGrabImage2File = new System.Windows.Forms.Button();
            this.folderBrowserFrameGrab = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSpotModeSwitch = new System.Windows.Forms.Button();
            this.groupBoxRefreshNotify = new System.Windows.Forms.GroupBox();
            this.buttonSetNotify = new System.Windows.Forms.Button();
            this.textBoxSetNotify = new System.Windows.Forms.TextBox();
            this.groupBoxDEDInit = new System.Windows.Forms.GroupBox();
            this.buttonDEDTrial2 = new System.Windows.Forms.Button();
            this.buttonDEDTrial1 = new System.Windows.Forms.Button();
            this.buttonDEDShowThBias = new System.Windows.Forms.Button();
            this.textBoxDEDConsole = new System.Windows.Forms.TextBox();
            this.groupBoxUtils = new System.Windows.Forms.GroupBox();
            this.buttonDEDTemperatureRead = new System.Windows.Forms.Button();
            this.buttonDEDBiasSweep = new System.Windows.Forms.Button();
            this.buttonCheckDEDConnection = new System.Windows.Forms.Button();
            this.buttonDEDThSweep = new System.Windows.Forms.Button();
            this.buttonPIXETVersion = new System.Windows.Forms.Button();
            this.groupBoxDEDSingleFrame = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDEDSingleTrialCapture = new System.Windows.Forms.Button();
            this.buttonDEDSingleCapture = new System.Windows.Forms.Button();
            this.buttonDEDSingleSaveBrowse = new System.Windows.Forms.Button();
            this.textBoxDEDDirectory = new System.Windows.Forms.TextBox();
            this.labelDEDSingleSaveHint = new System.Windows.Forms.Label();
            this.textBoxDEDSingleIdentifier = new System.Windows.Forms.TextBox();
            this.labelDEDSingleIdentifier = new System.Windows.Forms.Label();
            this.textBoxDEDSingleFrameTime = new System.Windows.Forms.TextBox();
            this.labelDEDSingleFrameTime = new System.Windows.Forms.Label();
            this.textBoxDEDSingleIntFrameCount = new System.Windows.Forms.TextBox();
            this.labelDEDSingleIntFrameCount = new System.Windows.Forms.Label();
            this.labelDEDSingleBias = new System.Windows.Forms.Label();
            this.textBoxDEDSingleBias = new System.Windows.Forms.TextBox();
            this.labelDEDSingleTh = new System.Windows.Forms.Label();
            this.textBoxDEDSingleTh = new System.Windows.Forms.TextBox();
            this.labelDEDConsole = new System.Windows.Forms.Label();
            this.groupBoxDEDGridCapture = new System.Windows.Forms.GroupBox();
            this.buttonDEDGridRecParams = new System.Windows.Forms.Button();
            this.labelDEDSelectedRanges = new System.Windows.Forms.Label();
            this.textBoxDEDSelectedYMax = new System.Windows.Forms.TextBox();
            this.textBoxDEDSelectedYMin = new System.Windows.Forms.TextBox();
            this.textBoxDEDSelectedXMax = new System.Windows.Forms.TextBox();
            this.textBoxDEDSelectedXMin = new System.Windows.Forms.TextBox();
            this.buttonDEDSelectedGrid = new System.Windows.Forms.Button();
            this.buttonDEDFullFrameGrid = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.groupBoxParams.SuspendLayout();
            this.groupBoxDebugUpperRight.SuspendLayout();
            this.groupBoxInitialize.SuspendLayout();
            this.groupBoxFrameGrab.SuspendLayout();
            this.groupBoxRefreshNotify.SuspendLayout();
            this.groupBoxDEDInit.SuspendLayout();
            this.groupBoxUtils.SuspendLayout();
            this.groupBoxDEDSingleFrame.SuspendLayout();
            this.groupBoxDEDGridCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetCZEMApiVersion
            // 
            this.buttonGetCZEMApiVersion.Location = new System.Drawing.Point(6, 17);
            this.buttonGetCZEMApiVersion.Name = "buttonGetCZEMApiVersion";
            this.buttonGetCZEMApiVersion.Size = new System.Drawing.Size(93, 32);
            this.buttonGetCZEMApiVersion.TabIndex = 1;
            this.buttonGetCZEMApiVersion.Text = "Get API Version";
            this.buttonGetCZEMApiVersion.UseVisualStyleBackColor = true;
            this.buttonGetCZEMApiVersion.Click += new System.EventHandler(this.buttonGetCZEMApiVersion_Click);
            // 
            // buttonInitialiseCZEMApi
            // 
            this.buttonInitialiseCZEMApi.Location = new System.Drawing.Point(14, 19);
            this.buttonInitialiseCZEMApi.Name = "buttonInitialiseCZEMApi";
            this.buttonInitialiseCZEMApi.Size = new System.Drawing.Size(120, 23);
            this.buttonInitialiseCZEMApi.TabIndex = 0;
            this.buttonInitialiseCZEMApi.Text = "Initialise API";
            this.buttonInitialiseCZEMApi.UseVisualStyleBackColor = true;
            this.buttonInitialiseCZEMApi.Click += new System.EventHandler(this.buttonInitialiseCZEMApi_Click);
            // 
            // buttonGetBeamPosnLimits
            // 
            this.buttonGetBeamPosnLimits.Location = new System.Drawing.Point(6, 55);
            this.buttonGetBeamPosnLimits.Name = "buttonGetBeamPosnLimits";
            this.buttonGetBeamPosnLimits.Size = new System.Drawing.Size(93, 36);
            this.buttonGetBeamPosnLimits.TabIndex = 2;
            this.buttonGetBeamPosnLimits.Text = "Get Spot Posn Limits";
            this.buttonGetBeamPosnLimits.UseVisualStyleBackColor = true;
            this.buttonGetBeamPosnLimits.Click += new System.EventHandler(this.buttonGetBeamPosnLimits_Click);
            // 
            // buttonXBeamScan
            // 
            this.buttonXBeamScan.Location = new System.Drawing.Point(6, 97);
            this.buttonXBeamScan.Name = "buttonXBeamScan";
            this.buttonXBeamScan.Size = new System.Drawing.Size(93, 36);
            this.buttonXBeamScan.TabIndex = 3;
            this.buttonXBeamScan.Text = "Perform X Beam Scan";
            this.buttonXBeamScan.UseVisualStyleBackColor = true;
            this.buttonXBeamScan.Click += new System.EventHandler(this.buttonXBeamScan_Click);
            // 
            // buttonSetMag
            // 
            this.buttonSetMag.Location = new System.Drawing.Point(151, 362);
            this.buttonSetMag.Name = "buttonSetMag";
            this.buttonSetMag.Size = new System.Drawing.Size(59, 20);
            this.buttonSetMag.TabIndex = 4;
            this.buttonSetMag.Text = "Set Mag";
            this.buttonSetMag.UseVisualStyleBackColor = true;
            this.buttonSetMag.Click += new System.EventHandler(this.buttonSetMag_Click);
            // 
            // textBoxEnterMag
            // 
            this.textBoxEnterMag.Location = new System.Drawing.Point(43, 362);
            this.textBoxEnterMag.Name = "textBoxEnterMag";
            this.textBoxEnterMag.Size = new System.Drawing.Size(102, 20);
            this.textBoxEnterMag.TabIndex = 5;
            this.textBoxEnterMag.Text = "Enter Mag here";
            // 
            // labelEnterMag
            // 
            this.labelEnterMag.AutoSize = true;
            this.labelEnterMag.Location = new System.Drawing.Point(34, 385);
            this.labelEnterMag.Name = "labelEnterMag";
            this.labelEnterMag.Size = new System.Drawing.Size(148, 13);
            this.labelEnterMag.TabIndex = 6;
            this.labelEnterMag.Text = "Pixel size (nm) ~ 123800/Mag";
            // 
            // labelPreamble
            // 
            this.labelPreamble.AutoSize = true;
            this.labelPreamble.Location = new System.Drawing.Point(26, 15);
            this.labelPreamble.Name = "labelPreamble";
            this.labelPreamble.Size = new System.Drawing.Size(447, 13);
            this.labelPreamble.TabIndex = 8;
            this.labelPreamble.Text = "ZeissTrial API control by Tianbi Zhang, 2022 based on SmartSEM API programming ex" +
    "amples";
            // 
            // labelSetMagPrompt
            // 
            this.labelSetMagPrompt.AutoSize = true;
            this.labelSetMagPrompt.Location = new System.Drawing.Point(34, 346);
            this.labelSetMagPrompt.Name = "labelSetMagPrompt";
            this.labelSetMagPrompt.Size = new System.Drawing.Size(154, 13);
            this.labelSetMagPrompt.TabIndex = 10;
            this.labelSetMagPrompt.Text = "Set Magnification and step size";
            // 
            // labelXBeamScan
            // 
            this.labelXBeamScan.AutoSize = true;
            this.labelXBeamScan.Location = new System.Drawing.Point(423, 158);
            this.labelXBeamScan.Name = "labelXBeamScan";
            this.labelXBeamScan.Size = new System.Drawing.Size(129, 13);
            this.labelXBeamScan.TabIndex = 11;
            this.labelXBeamScan.Text = "Please ensure spot mode!";
            // 
            // buttonXYBeamScan
            // 
            this.buttonXYBeamScan.Location = new System.Drawing.Point(117, 54);
            this.buttonXYBeamScan.Name = "buttonXYBeamScan";
            this.buttonXYBeamScan.Size = new System.Drawing.Size(92, 37);
            this.buttonXYBeamScan.TabIndex = 13;
            this.buttonXYBeamScan.Text = "Perform XY Beam Scan";
            this.buttonXYBeamScan.UseVisualStyleBackColor = true;
            this.buttonXYBeamScan.Click += new System.EventHandler(this.buttonXYBeamScan_Click);
            // 
            // labelCloseControls
            // 
            this.labelCloseControls.AutoSize = true;
            this.labelCloseControls.Location = new System.Drawing.Point(26, 584);
            this.labelCloseControls.Name = "labelCloseControls";
            this.labelCloseControls.Size = new System.Drawing.Size(236, 13);
            this.labelCloseControls.TabIndex = 16;
            this.labelCloseControls.Text = "Please close controls before closing the window!";
            // 
            // buttonCloseControl
            // 
            this.buttonCloseControl.Location = new System.Drawing.Point(29, 600);
            this.buttonCloseControl.Name = "buttonCloseControl";
            this.buttonCloseControl.Size = new System.Drawing.Size(92, 32);
            this.buttonCloseControl.TabIndex = 17;
            this.buttonCloseControl.Text = "Close Control";
            this.buttonCloseControl.UseVisualStyleBackColor = true;
            this.buttonCloseControl.Click += new System.EventHandler(this.buttonCloseControl_Click);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.textBoxStageZ);
            this.groupBoxParams.Controls.Add(this.textBoxStageY);
            this.groupBoxParams.Controls.Add(this.textBoxStageX);
            this.groupBoxParams.Controls.Add(this.textBoxHighCurrent);
            this.groupBoxParams.Controls.Add(this.textBoxContrast);
            this.groupBoxParams.Controls.Add(this.textBoxBrightness);
            this.groupBoxParams.Controls.Add(this.textBoxApertureSize);
            this.groupBoxParams.Controls.Add(this.textBoxDetectorChannel);
            this.groupBoxParams.Controls.Add(this.textBoxDetectorType);
            this.groupBoxParams.Controls.Add(this.textBoxWD);
            this.groupBoxParams.Controls.Add(this.textBoxPixelSize);
            this.groupBoxParams.Controls.Add(this.textBoxMag);
            this.groupBoxParams.Controls.Add(this.textBoxScanrate);
            this.groupBoxParams.Controls.Add(this.textBoxSpotMode);
            this.groupBoxParams.Controls.Add(this.textBoxIprobe);
            this.groupBoxParams.Controls.Add(this.textBoxActualCurrent);
            this.groupBoxParams.Controls.Add(this.textBoxActualkv);
            this.groupBoxParams.Controls.Add(this.textBoxRunupstate);
            this.groupBoxParams.Controls.Add(this.textBoxVacStatus);
            this.groupBoxParams.Controls.Add(this.textBoxInit);
            this.groupBoxParams.Location = new System.Drawing.Point(29, 410);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(521, 170);
            this.groupBoxParams.TabIndex = 18;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "SEM Parameters and Status";
            // 
            // textBoxStageZ
            // 
            this.textBoxStageZ.Location = new System.Drawing.Point(393, 135);
            this.textBoxStageZ.Name = "textBoxStageZ";
            this.textBoxStageZ.ReadOnly = true;
            this.textBoxStageZ.Size = new System.Drawing.Size(120, 20);
            this.textBoxStageZ.TabIndex = 30;
            // 
            // textBoxStageY
            // 
            this.textBoxStageY.Location = new System.Drawing.Point(264, 135);
            this.textBoxStageY.Name = "textBoxStageY";
            this.textBoxStageY.ReadOnly = true;
            this.textBoxStageY.Size = new System.Drawing.Size(120, 20);
            this.textBoxStageY.TabIndex = 29;
            // 
            // textBoxStageX
            // 
            this.textBoxStageX.Location = new System.Drawing.Point(135, 135);
            this.textBoxStageX.Name = "textBoxStageX";
            this.textBoxStageX.ReadOnly = true;
            this.textBoxStageX.Size = new System.Drawing.Size(120, 20);
            this.textBoxStageX.TabIndex = 28;
            // 
            // textBoxHighCurrent
            // 
            this.textBoxHighCurrent.Location = new System.Drawing.Point(6, 135);
            this.textBoxHighCurrent.Name = "textBoxHighCurrent";
            this.textBoxHighCurrent.ReadOnly = true;
            this.textBoxHighCurrent.Size = new System.Drawing.Size(120, 20);
            this.textBoxHighCurrent.TabIndex = 27;
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Location = new System.Drawing.Point(393, 106);
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.ReadOnly = true;
            this.textBoxContrast.Size = new System.Drawing.Size(119, 20);
            this.textBoxContrast.TabIndex = 15;
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Location = new System.Drawing.Point(393, 77);
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.ReadOnly = true;
            this.textBoxBrightness.Size = new System.Drawing.Size(119, 20);
            this.textBoxBrightness.TabIndex = 14;
            // 
            // textBoxApertureSize
            // 
            this.textBoxApertureSize.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxApertureSize.Location = new System.Drawing.Point(264, 106);
            this.textBoxApertureSize.Name = "textBoxApertureSize";
            this.textBoxApertureSize.Size = new System.Drawing.Size(120, 20);
            this.textBoxApertureSize.TabIndex = 13;
            // 
            // textBoxDetectorChannel
            // 
            this.textBoxDetectorChannel.Location = new System.Drawing.Point(393, 48);
            this.textBoxDetectorChannel.Name = "textBoxDetectorChannel";
            this.textBoxDetectorChannel.ReadOnly = true;
            this.textBoxDetectorChannel.Size = new System.Drawing.Size(120, 20);
            this.textBoxDetectorChannel.TabIndex = 12;
            // 
            // textBoxDetectorType
            // 
            this.textBoxDetectorType.Location = new System.Drawing.Point(393, 19);
            this.textBoxDetectorType.Name = "textBoxDetectorType";
            this.textBoxDetectorType.ReadOnly = true;
            this.textBoxDetectorType.Size = new System.Drawing.Size(120, 20);
            this.textBoxDetectorType.TabIndex = 11;
            // 
            // textBoxWD
            // 
            this.textBoxWD.Location = new System.Drawing.Point(264, 77);
            this.textBoxWD.Name = "textBoxWD";
            this.textBoxWD.ReadOnly = true;
            this.textBoxWD.Size = new System.Drawing.Size(120, 20);
            this.textBoxWD.TabIndex = 10;
            // 
            // textBoxPixelSize
            // 
            this.textBoxPixelSize.Location = new System.Drawing.Point(264, 48);
            this.textBoxPixelSize.Name = "textBoxPixelSize";
            this.textBoxPixelSize.ReadOnly = true;
            this.textBoxPixelSize.Size = new System.Drawing.Size(120, 20);
            this.textBoxPixelSize.TabIndex = 9;
            // 
            // textBoxMag
            // 
            this.textBoxMag.Location = new System.Drawing.Point(264, 19);
            this.textBoxMag.Name = "textBoxMag";
            this.textBoxMag.ReadOnly = true;
            this.textBoxMag.Size = new System.Drawing.Size(120, 20);
            this.textBoxMag.TabIndex = 8;
            // 
            // textBoxScanrate
            // 
            this.textBoxScanrate.Location = new System.Drawing.Point(135, 106);
            this.textBoxScanrate.Name = "textBoxScanrate";
            this.textBoxScanrate.ReadOnly = true;
            this.textBoxScanrate.Size = new System.Drawing.Size(120, 20);
            this.textBoxScanrate.TabIndex = 7;
            // 
            // textBoxSpotMode
            // 
            this.textBoxSpotMode.Location = new System.Drawing.Point(135, 77);
            this.textBoxSpotMode.Name = "textBoxSpotMode";
            this.textBoxSpotMode.ReadOnly = true;
            this.textBoxSpotMode.Size = new System.Drawing.Size(120, 20);
            this.textBoxSpotMode.TabIndex = 6;
            // 
            // textBoxIprobe
            // 
            this.textBoxIprobe.Location = new System.Drawing.Point(135, 48);
            this.textBoxIprobe.Name = "textBoxIprobe";
            this.textBoxIprobe.ReadOnly = true;
            this.textBoxIprobe.Size = new System.Drawing.Size(120, 20);
            this.textBoxIprobe.TabIndex = 5;
            this.textBoxIprobe.TextChanged += new System.EventHandler(this.textBoxIprobe_TextChanged);
            // 
            // textBoxActualCurrent
            // 
            this.textBoxActualCurrent.Location = new System.Drawing.Point(135, 19);
            this.textBoxActualCurrent.Name = "textBoxActualCurrent";
            this.textBoxActualCurrent.ReadOnly = true;
            this.textBoxActualCurrent.Size = new System.Drawing.Size(120, 20);
            this.textBoxActualCurrent.TabIndex = 4;
            // 
            // textBoxActualkv
            // 
            this.textBoxActualkv.Location = new System.Drawing.Point(6, 106);
            this.textBoxActualkv.Name = "textBoxActualkv";
            this.textBoxActualkv.ReadOnly = true;
            this.textBoxActualkv.Size = new System.Drawing.Size(120, 20);
            this.textBoxActualkv.TabIndex = 3;
            // 
            // textBoxRunupstate
            // 
            this.textBoxRunupstate.Location = new System.Drawing.Point(6, 77);
            this.textBoxRunupstate.Name = "textBoxRunupstate";
            this.textBoxRunupstate.ReadOnly = true;
            this.textBoxRunupstate.Size = new System.Drawing.Size(120, 20);
            this.textBoxRunupstate.TabIndex = 2;
            // 
            // textBoxVacStatus
            // 
            this.textBoxVacStatus.Location = new System.Drawing.Point(6, 48);
            this.textBoxVacStatus.Name = "textBoxVacStatus";
            this.textBoxVacStatus.ReadOnly = true;
            this.textBoxVacStatus.Size = new System.Drawing.Size(120, 20);
            this.textBoxVacStatus.TabIndex = 1;
            // 
            // textBoxInit
            // 
            this.textBoxInit.Location = new System.Drawing.Point(6, 20);
            this.textBoxInit.Name = "textBoxInit";
            this.textBoxInit.ReadOnly = true;
            this.textBoxInit.Size = new System.Drawing.Size(120, 20);
            this.textBoxInit.TabIndex = 0;
            // 
            // labelScanProgressBar
            // 
            this.labelScanProgressBar.AutoSize = true;
            this.labelScanProgressBar.Location = new System.Drawing.Point(337, 346);
            this.labelScanProgressBar.Name = "labelScanProgressBar";
            this.labelScanProgressBar.Size = new System.Drawing.Size(96, 13);
            this.labelScanProgressBar.TabIndex = 26;
            this.labelScanProgressBar.Text = "Scanning Progress";
            // 
            // progressBarScan
            // 
            this.progressBarScan.Location = new System.Drawing.Point(340, 363);
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(201, 19);
            this.progressBarScan.TabIndex = 25;
            // 
            // groupBoxDebugUpperRight
            // 
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonMagMap);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonXScanGrabPixelValue);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonXBeamScan);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonGetBeamPosnLimits);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonGetCZEMApiVersion);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonXYBeamScan);
            this.groupBoxDebugUpperRight.Location = new System.Drawing.Point(331, 35);
            this.groupBoxDebugUpperRight.Name = "groupBoxDebugUpperRight";
            this.groupBoxDebugUpperRight.Size = new System.Drawing.Size(220, 147);
            this.groupBoxDebugUpperRight.TabIndex = 19;
            this.groupBoxDebugUpperRight.TabStop = false;
            this.groupBoxDebugUpperRight.Text = "Quick Testing/Debugging Tools";
            // 
            // buttonMagMap
            // 
            this.buttonMagMap.Location = new System.Drawing.Point(117, 17);
            this.buttonMagMap.Name = "buttonMagMap";
            this.buttonMagMap.Size = new System.Drawing.Size(92, 31);
            this.buttonMagMap.TabIndex = 5;
            this.buttonMagMap.Text = "Mag Map";
            this.buttonMagMap.UseVisualStyleBackColor = true;
            this.buttonMagMap.Click += new System.EventHandler(this.buttonMagMap_Click);
            // 
            // buttonXScanGrabPixelValue
            // 
            this.buttonXScanGrabPixelValue.Enabled = false;
            this.buttonXScanGrabPixelValue.Location = new System.Drawing.Point(117, 97);
            this.buttonXScanGrabPixelValue.Name = "buttonXScanGrabPixelValue";
            this.buttonXScanGrabPixelValue.Size = new System.Drawing.Size(92, 36);
            this.buttonXScanGrabPixelValue.TabIndex = 4;
            this.buttonXScanGrabPixelValue.Text = "X Beam Scan + Pixel Grab";
            this.buttonXScanGrabPixelValue.UseVisualStyleBackColor = true;
            this.buttonXScanGrabPixelValue.Click += new System.EventHandler(this.buttonXScanGrabPixelValue_Click);
            // 
            // groupBoxInitialize
            // 
            this.groupBoxInitialize.Controls.Add(this.buttonInitializeRemote);
            this.groupBoxInitialize.Controls.Add(this.buttonInitialiseCZEMApi);
            this.groupBoxInitialize.Location = new System.Drawing.Point(29, 35);
            this.groupBoxInitialize.Name = "groupBoxInitialize";
            this.groupBoxInitialize.Size = new System.Drawing.Size(272, 49);
            this.groupBoxInitialize.TabIndex = 20;
            this.groupBoxInitialize.TabStop = false;
            this.groupBoxInitialize.Text = "Please initialize the SmartSEM API first";
            // 
            // buttonInitializeRemote
            // 
            this.buttonInitializeRemote.Location = new System.Drawing.Point(140, 19);
            this.buttonInitializeRemote.Name = "buttonInitializeRemote";
            this.buttonInitializeRemote.Size = new System.Drawing.Size(120, 23);
            this.buttonInitializeRemote.TabIndex = 1;
            this.buttonInitializeRemote.Text = "Initialize Remote";
            this.buttonInitializeRemote.UseVisualStyleBackColor = true;
            this.buttonInitializeRemote.Click += new System.EventHandler(this.buttonInitializeRemote_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(127, 600);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(92, 32);
            this.buttonQuit.TabIndex = 21;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonRefreshParams
            // 
            this.buttonRefreshParams.Location = new System.Drawing.Point(14, 15);
            this.buttonRefreshParams.Name = "buttonRefreshParams";
            this.buttonRefreshParams.Size = new System.Drawing.Size(120, 24);
            this.buttonRefreshParams.TabIndex = 22;
            this.buttonRefreshParams.Text = "Refresh Parameters";
            this.buttonRefreshParams.UseVisualStyleBackColor = true;
            this.buttonRefreshParams.Click += new System.EventHandler(this.buttonRefreshParams_Click);
            // 
            // groupBoxFrameGrab
            // 
            this.groupBoxFrameGrab.Controls.Add(this.labelFrameGrabFileNamePart2);
            this.groupBoxFrameGrab.Controls.Add(this.labelFrameGrabFileName);
            this.groupBoxFrameGrab.Controls.Add(this.textBoxFrameGrabFileName);
            this.groupBoxFrameGrab.Controls.Add(this.buttonGrabPixelValue);
            this.groupBoxFrameGrab.Controls.Add(this.textBoxFrameGrabDirectory);
            this.groupBoxFrameGrab.Controls.Add(this.buttonBrowseFrameGrab);
            this.groupBoxFrameGrab.Controls.Add(this.buttonGrabImage2File);
            this.groupBoxFrameGrab.Location = new System.Drawing.Point(331, 190);
            this.groupBoxFrameGrab.Name = "groupBoxFrameGrab";
            this.groupBoxFrameGrab.Size = new System.Drawing.Size(219, 142);
            this.groupBoxFrameGrab.TabIndex = 23;
            this.groupBoxFrameGrab.TabStop = false;
            this.groupBoxFrameGrab.Text = "Grab Current Frame";
            // 
            // labelFrameGrabFileNamePart2
            // 
            this.labelFrameGrabFileNamePart2.AutoSize = true;
            this.labelFrameGrabFileNamePart2.Location = new System.Drawing.Point(156, 53);
            this.labelFrameGrabFileNamePart2.Name = "labelFrameGrabFileNamePart2";
            this.labelFrameGrabFileNamePart2.Size = new System.Drawing.Size(27, 13);
            this.labelFrameGrabFileNamePart2.TabIndex = 7;
            this.labelFrameGrabFileNamePart2.Text = "(.tiff)";
            // 
            // labelFrameGrabFileName
            // 
            this.labelFrameGrabFileName.AutoSize = true;
            this.labelFrameGrabFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelFrameGrabFileName.Location = new System.Drawing.Point(6, 52);
            this.labelFrameGrabFileName.Name = "labelFrameGrabFileName";
            this.labelFrameGrabFileName.Size = new System.Drawing.Size(84, 13);
            this.labelFrameGrabFileName.TabIndex = 6;
            this.labelFrameGrabFileName.Text = "Frame file name:";
            // 
            // textBoxFrameGrabFileName
            // 
            this.textBoxFrameGrabFileName.Location = new System.Drawing.Point(91, 49);
            this.textBoxFrameGrabFileName.Name = "textBoxFrameGrabFileName";
            this.textBoxFrameGrabFileName.Size = new System.Drawing.Size(62, 20);
            this.textBoxFrameGrabFileName.TabIndex = 5;
            this.textBoxFrameGrabFileName.Text = "Frame";
            // 
            // buttonGrabPixelValue
            // 
            this.buttonGrabPixelValue.Enabled = false;
            this.buttonGrabPixelValue.Location = new System.Drawing.Point(9, 109);
            this.buttonGrabPixelValue.Name = "buttonGrabPixelValue";
            this.buttonGrabPixelValue.Size = new System.Drawing.Size(202, 28);
            this.buttonGrabPixelValue.TabIndex = 4;
            this.buttonGrabPixelValue.Text = "Grab pixel grayscale to a text file";
            this.buttonGrabPixelValue.UseVisualStyleBackColor = true;
            this.buttonGrabPixelValue.Click += new System.EventHandler(this.buttonGrabPixelValue_Click);
            // 
            // textBoxFrameGrabDirectory
            // 
            this.textBoxFrameGrabDirectory.Location = new System.Drawing.Point(9, 21);
            this.textBoxFrameGrabDirectory.Name = "textBoxFrameGrabDirectory";
            this.textBoxFrameGrabDirectory.Size = new System.Drawing.Size(135, 20);
            this.textBoxFrameGrabDirectory.TabIndex = 3;
            // 
            // buttonBrowseFrameGrab
            // 
            this.buttonBrowseFrameGrab.Location = new System.Drawing.Point(150, 21);
            this.buttonBrowseFrameGrab.Name = "buttonBrowseFrameGrab";
            this.buttonBrowseFrameGrab.Size = new System.Drawing.Size(61, 20);
            this.buttonBrowseFrameGrab.TabIndex = 2;
            this.buttonBrowseFrameGrab.Text = "Browse...";
            this.buttonBrowseFrameGrab.UseVisualStyleBackColor = true;
            this.buttonBrowseFrameGrab.Click += new System.EventHandler(this.buttonBrowseFrameGrab_Click);
            // 
            // buttonGrabImage2File
            // 
            this.buttonGrabImage2File.Location = new System.Drawing.Point(9, 77);
            this.buttonGrabImage2File.Name = "buttonGrabImage2File";
            this.buttonGrabImage2File.Size = new System.Drawing.Size(201, 28);
            this.buttonGrabImage2File.TabIndex = 0;
            this.buttonGrabImage2File.Text = "Quick Grab Current Frame";
            this.buttonGrabImage2File.UseVisualStyleBackColor = true;
            this.buttonGrabImage2File.Click += new System.EventHandler(this.buttonGrabImage2File_Click);
            // 
            // folderBrowserFrameGrab
            // 
            this.folderBrowserFrameGrab.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // buttonSpotModeSwitch
            // 
            this.buttonSpotModeSwitch.Location = new System.Drawing.Point(216, 362);
            this.buttonSpotModeSwitch.Name = "buttonSpotModeSwitch";
            this.buttonSpotModeSwitch.Size = new System.Drawing.Size(85, 36);
            this.buttonSpotModeSwitch.TabIndex = 24;
            this.buttonSpotModeSwitch.Text = "Spot Mode On/Off";
            this.buttonSpotModeSwitch.UseVisualStyleBackColor = true;
            this.buttonSpotModeSwitch.Click += new System.EventHandler(this.buttonSpotModeSwitch_Click);
            // 
            // groupBoxRefreshNotify
            // 
            this.groupBoxRefreshNotify.Controls.Add(this.buttonSetNotify);
            this.groupBoxRefreshNotify.Controls.Add(this.buttonRefreshParams);
            this.groupBoxRefreshNotify.Location = new System.Drawing.Point(29, 86);
            this.groupBoxRefreshNotify.Name = "groupBoxRefreshNotify";
            this.groupBoxRefreshNotify.Size = new System.Drawing.Size(272, 47);
            this.groupBoxRefreshNotify.TabIndex = 25;
            this.groupBoxRefreshNotify.TabStop = false;
            this.groupBoxRefreshNotify.Text = "Manual/Automatic Parameter Refresh";
            // 
            // buttonSetNotify
            // 
            this.buttonSetNotify.Location = new System.Drawing.Point(140, 17);
            this.buttonSetNotify.Name = "buttonSetNotify";
            this.buttonSetNotify.Size = new System.Drawing.Size(120, 22);
            this.buttonSetNotify.TabIndex = 23;
            this.buttonSetNotify.Text = "Auto Refresh (Notify)";
            this.buttonSetNotify.UseVisualStyleBackColor = true;
            this.buttonSetNotify.Click += new System.EventHandler(this.buttonSetNotify_Click);
            // 
            // textBoxSetNotify
            // 
            this.textBoxSetNotify.Location = new System.Drawing.Point(29, 133);
            this.textBoxSetNotify.Multiline = true;
            this.textBoxSetNotify.Name = "textBoxSetNotify";
            this.textBoxSetNotify.ReadOnly = true;
            this.textBoxSetNotify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSetNotify.Size = new System.Drawing.Size(272, 208);
            this.textBoxSetNotify.TabIndex = 24;
            // 
            // groupBoxDEDInit
            // 
            this.groupBoxDEDInit.Controls.Add(this.buttonDEDTrial2);
            this.groupBoxDEDInit.Controls.Add(this.buttonDEDTrial1);
            this.groupBoxDEDInit.Controls.Add(this.buttonDEDShowThBias);
            this.groupBoxDEDInit.Location = new System.Drawing.Point(584, 35);
            this.groupBoxDEDInit.Name = "groupBoxDEDInit";
            this.groupBoxDEDInit.Size = new System.Drawing.Size(240, 153);
            this.groupBoxDEDInit.TabIndex = 26;
            this.groupBoxDEDInit.TabStop = false;
            this.groupBoxDEDInit.Text = "DED Controls";
            // 
            // buttonDEDTrial2
            // 
            this.buttonDEDTrial2.Location = new System.Drawing.Point(128, 107);
            this.buttonDEDTrial2.Name = "buttonDEDTrial2";
            this.buttonDEDTrial2.Size = new System.Drawing.Size(96, 26);
            this.buttonDEDTrial2.TabIndex = 2;
            this.buttonDEDTrial2.Text = "Trial2";
            this.buttonDEDTrial2.UseVisualStyleBackColor = true;
            this.buttonDEDTrial2.Click += new System.EventHandler(this.buttonDEDTrial2_Click);
            // 
            // buttonDEDTrial1
            // 
            this.buttonDEDTrial1.Location = new System.Drawing.Point(11, 106);
            this.buttonDEDTrial1.Name = "buttonDEDTrial1";
            this.buttonDEDTrial1.Size = new System.Drawing.Size(97, 29);
            this.buttonDEDTrial1.TabIndex = 1;
            this.buttonDEDTrial1.Text = "Trial1";
            this.buttonDEDTrial1.UseVisualStyleBackColor = true;
            this.buttonDEDTrial1.Click += new System.EventHandler(this.buttonDEDTrial1_Click);
            // 
            // buttonDEDShowThBias
            // 
            this.buttonDEDShowThBias.Location = new System.Drawing.Point(11, 55);
            this.buttonDEDShowThBias.Name = "buttonDEDShowThBias";
            this.buttonDEDShowThBias.Size = new System.Drawing.Size(98, 37);
            this.buttonDEDShowThBias.TabIndex = 0;
            this.buttonDEDShowThBias.Text = "Check Th. and Bias";
            this.buttonDEDShowThBias.UseVisualStyleBackColor = true;
            this.buttonDEDShowThBias.Click += new System.EventHandler(this.buttonDEDShowThBias_Click);
            // 
            // textBoxDEDConsole
            // 
            this.textBoxDEDConsole.Location = new System.Drawing.Point(584, 219);
            this.textBoxDEDConsole.Multiline = true;
            this.textBoxDEDConsole.Name = "textBoxDEDConsole";
            this.textBoxDEDConsole.ReadOnly = true;
            this.textBoxDEDConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDEDConsole.Size = new System.Drawing.Size(240, 361);
            this.textBoxDEDConsole.TabIndex = 27;
            // 
            // groupBoxUtils
            // 
            this.groupBoxUtils.Controls.Add(this.buttonDEDTemperatureRead);
            this.groupBoxUtils.Controls.Add(this.buttonDEDBiasSweep);
            this.groupBoxUtils.Controls.Add(this.buttonCheckDEDConnection);
            this.groupBoxUtils.Controls.Add(this.buttonDEDThSweep);
            this.groupBoxUtils.Controls.Add(this.buttonPIXETVersion);
            this.groupBoxUtils.Location = new System.Drawing.Point(843, 36);
            this.groupBoxUtils.Name = "groupBoxUtils";
            this.groupBoxUtils.Size = new System.Drawing.Size(337, 152);
            this.groupBoxUtils.TabIndex = 28;
            this.groupBoxUtils.TabStop = false;
            this.groupBoxUtils.Text = "DED Utilities";
            // 
            // buttonDEDTemperatureRead
            // 
            this.buttonDEDTemperatureRead.Location = new System.Drawing.Point(122, 54);
            this.buttonDEDTemperatureRead.Name = "buttonDEDTemperatureRead";
            this.buttonDEDTemperatureRead.Size = new System.Drawing.Size(90, 36);
            this.buttonDEDTemperatureRead.TabIndex = 4;
            this.buttonDEDTemperatureRead.Text = "Read Temperature";
            this.buttonDEDTemperatureRead.UseVisualStyleBackColor = true;
            this.buttonDEDTemperatureRead.Click += new System.EventHandler(this.DEDTemperatureRead_Click);
            // 
            // buttonDEDBiasSweep
            // 
            this.buttonDEDBiasSweep.Location = new System.Drawing.Point(122, 97);
            this.buttonDEDBiasSweep.Name = "buttonDEDBiasSweep";
            this.buttonDEDBiasSweep.Size = new System.Drawing.Size(90, 33);
            this.buttonDEDBiasSweep.TabIndex = 3;
            this.buttonDEDBiasSweep.Text = "Bias Sweep";
            this.buttonDEDBiasSweep.UseVisualStyleBackColor = true;
            this.buttonDEDBiasSweep.Click += new System.EventHandler(this.buttonDEDBiasSweep_Click);
            // 
            // buttonCheckDEDConnection
            // 
            this.buttonCheckDEDConnection.Location = new System.Drawing.Point(6, 54);
            this.buttonCheckDEDConnection.Name = "buttonCheckDEDConnection";
            this.buttonCheckDEDConnection.Size = new System.Drawing.Size(92, 37);
            this.buttonCheckDEDConnection.TabIndex = 2;
            this.buttonCheckDEDConnection.Text = "Check DED Connections";
            this.buttonCheckDEDConnection.UseVisualStyleBackColor = true;
            this.buttonCheckDEDConnection.Click += new System.EventHandler(this.buttonCheckDEDConnection_Click);
            // 
            // buttonDEDThSweep
            // 
            this.buttonDEDThSweep.Location = new System.Drawing.Point(6, 97);
            this.buttonDEDThSweep.Name = "buttonDEDThSweep";
            this.buttonDEDThSweep.Size = new System.Drawing.Size(92, 33);
            this.buttonDEDThSweep.TabIndex = 1;
            this.buttonDEDThSweep.Text = "Thres. Sweep";
            this.buttonDEDThSweep.UseVisualStyleBackColor = true;
            this.buttonDEDThSweep.Click += new System.EventHandler(this.buttonDEDThSweep_Click);
            // 
            // buttonPIXETVersion
            // 
            this.buttonPIXETVersion.Location = new System.Drawing.Point(6, 17);
            this.buttonPIXETVersion.Name = "buttonPIXETVersion";
            this.buttonPIXETVersion.Size = new System.Drawing.Size(92, 31);
            this.buttonPIXETVersion.TabIndex = 0;
            this.buttonPIXETVersion.Text = "PIXET Version";
            this.buttonPIXETVersion.UseVisualStyleBackColor = true;
            this.buttonPIXETVersion.Click += new System.EventHandler(this.buttonPIXETVersion_Click);
            // 
            // groupBoxDEDSingleFrame
            // 
            this.groupBoxDEDSingleFrame.Controls.Add(this.label1);
            this.groupBoxDEDSingleFrame.Controls.Add(this.buttonDEDSingleTrialCapture);
            this.groupBoxDEDSingleFrame.Controls.Add(this.buttonDEDSingleCapture);
            this.groupBoxDEDSingleFrame.Controls.Add(this.buttonDEDSingleSaveBrowse);
            this.groupBoxDEDSingleFrame.Controls.Add(this.textBoxDEDDirectory);
            this.groupBoxDEDSingleFrame.Controls.Add(this.labelDEDSingleSaveHint);
            this.groupBoxDEDSingleFrame.Controls.Add(this.textBoxDEDSingleIdentifier);
            this.groupBoxDEDSingleFrame.Controls.Add(this.labelDEDSingleIdentifier);
            this.groupBoxDEDSingleFrame.Controls.Add(this.textBoxDEDSingleFrameTime);
            this.groupBoxDEDSingleFrame.Controls.Add(this.labelDEDSingleFrameTime);
            this.groupBoxDEDSingleFrame.Controls.Add(this.textBoxDEDSingleIntFrameCount);
            this.groupBoxDEDSingleFrame.Controls.Add(this.labelDEDSingleIntFrameCount);
            this.groupBoxDEDSingleFrame.Controls.Add(this.labelDEDSingleBias);
            this.groupBoxDEDSingleFrame.Controls.Add(this.textBoxDEDSingleBias);
            this.groupBoxDEDSingleFrame.Controls.Add(this.labelDEDSingleTh);
            this.groupBoxDEDSingleFrame.Controls.Add(this.textBoxDEDSingleTh);
            this.groupBoxDEDSingleFrame.Location = new System.Drawing.Point(843, 203);
            this.groupBoxDEDSingleFrame.Name = "groupBoxDEDSingleFrame";
            this.groupBoxDEDSingleFrame.Size = new System.Drawing.Size(337, 256);
            this.groupBoxDEDSingleFrame.TabIndex = 29;
            this.groupBoxDEDSingleFrame.TabStop = false;
            this.groupBoxDEDSingleFrame.Text = "Single Pattern Grab";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "(Not available in grid grab)";
            // 
            // buttonDEDSingleTrialCapture
            // 
            this.buttonDEDSingleTrialCapture.Location = new System.Drawing.Point(161, 209);
            this.buttonDEDSingleTrialCapture.Name = "buttonDEDSingleTrialCapture";
            this.buttonDEDSingleTrialCapture.Size = new System.Drawing.Size(138, 27);
            this.buttonDEDSingleTrialCapture.TabIndex = 14;
            this.buttonDEDSingleTrialCapture.Text = "Trial Capture";
            this.buttonDEDSingleTrialCapture.UseVisualStyleBackColor = true;
            this.buttonDEDSingleTrialCapture.Click += new System.EventHandler(this.buttonDEDSingleTrialCapture_Click);
            // 
            // buttonDEDSingleCapture
            // 
            this.buttonDEDSingleCapture.Location = new System.Drawing.Point(11, 209);
            this.buttonDEDSingleCapture.Name = "buttonDEDSingleCapture";
            this.buttonDEDSingleCapture.Size = new System.Drawing.Size(134, 27);
            this.buttonDEDSingleCapture.TabIndex = 13;
            this.buttonDEDSingleCapture.Text = "DED Capture";
            this.buttonDEDSingleCapture.UseVisualStyleBackColor = true;
            this.buttonDEDSingleCapture.Click += new System.EventHandler(this.buttonDEDSingleCapture_Click);
            // 
            // buttonDEDSingleSaveBrowse
            // 
            this.buttonDEDSingleSaveBrowse.Location = new System.Drawing.Point(152, 153);
            this.buttonDEDSingleSaveBrowse.Name = "buttonDEDSingleSaveBrowse";
            this.buttonDEDSingleSaveBrowse.Size = new System.Drawing.Size(91, 22);
            this.buttonDEDSingleSaveBrowse.TabIndex = 12;
            this.buttonDEDSingleSaveBrowse.Text = "Browse...";
            this.buttonDEDSingleSaveBrowse.UseVisualStyleBackColor = true;
            this.buttonDEDSingleSaveBrowse.Click += new System.EventHandler(this.buttonDEDSingleSaveBrowse_Click);
            // 
            // textBoxDEDDirectory
            // 
            this.textBoxDEDDirectory.Location = new System.Drawing.Point(11, 155);
            this.textBoxDEDDirectory.Name = "textBoxDEDDirectory";
            this.textBoxDEDDirectory.ShortcutsEnabled = false;
            this.textBoxDEDDirectory.Size = new System.Drawing.Size(135, 20);
            this.textBoxDEDDirectory.TabIndex = 11;
            // 
            // labelDEDSingleSaveHint
            // 
            this.labelDEDSingleSaveHint.AutoSize = true;
            this.labelDEDSingleSaveHint.Location = new System.Drawing.Point(8, 182);
            this.labelDEDSingleSaveHint.Name = "labelDEDSingleSaveHint";
            this.labelDEDSingleSaveHint.Size = new System.Drawing.Size(317, 13);
            this.labelDEDSingleSaveHint.TabIndex = 10;
            this.labelDEDSingleSaveHint.Text = "Pattern will be saved as \"identifier_th_bias_frames_frametime.h5\".";
            // 
            // textBoxDEDSingleIdentifier
            // 
            this.textBoxDEDSingleIdentifier.Location = new System.Drawing.Point(148, 122);
            this.textBoxDEDSingleIdentifier.Name = "textBoxDEDSingleIdentifier";
            this.textBoxDEDSingleIdentifier.Size = new System.Drawing.Size(47, 20);
            this.textBoxDEDSingleIdentifier.TabIndex = 9;
            this.textBoxDEDSingleIdentifier.Text = "Spot1";
            // 
            // labelDEDSingleIdentifier
            // 
            this.labelDEDSingleIdentifier.AutoSize = true;
            this.labelDEDSingleIdentifier.Location = new System.Drawing.Point(8, 125);
            this.labelDEDSingleIdentifier.Name = "labelDEDSingleIdentifier";
            this.labelDEDSingleIdentifier.Size = new System.Drawing.Size(130, 13);
            this.labelDEDSingleIdentifier.TabIndex = 8;
            this.labelDEDSingleIdentifier.Text = "Spot Identifier (e.g. Spot1)";
            // 
            // textBoxDEDSingleFrameTime
            // 
            this.textBoxDEDSingleFrameTime.Location = new System.Drawing.Point(148, 97);
            this.textBoxDEDSingleFrameTime.Name = "textBoxDEDSingleFrameTime";
            this.textBoxDEDSingleFrameTime.Size = new System.Drawing.Size(47, 20);
            this.textBoxDEDSingleFrameTime.TabIndex = 7;
            this.textBoxDEDSingleFrameTime.Text = "0.002";
            // 
            // labelDEDSingleFrameTime
            // 
            this.labelDEDSingleFrameTime.AutoSize = true;
            this.labelDEDSingleFrameTime.Location = new System.Drawing.Point(8, 100);
            this.labelDEDSingleFrameTime.Name = "labelDEDSingleFrameTime";
            this.labelDEDSingleFrameTime.Size = new System.Drawing.Size(76, 13);
            this.labelDEDSingleFrameTime.TabIndex = 6;
            this.labelDEDSingleFrameTime.Text = "Frame Time (s)";
            // 
            // textBoxDEDSingleIntFrameCount
            // 
            this.textBoxDEDSingleIntFrameCount.Location = new System.Drawing.Point(148, 71);
            this.textBoxDEDSingleIntFrameCount.Name = "textBoxDEDSingleIntFrameCount";
            this.textBoxDEDSingleIntFrameCount.Size = new System.Drawing.Size(47, 20);
            this.textBoxDEDSingleIntFrameCount.TabIndex = 5;
            this.textBoxDEDSingleIntFrameCount.Text = "20";
            // 
            // labelDEDSingleIntFrameCount
            // 
            this.labelDEDSingleIntFrameCount.AutoSize = true;
            this.labelDEDSingleIntFrameCount.Location = new System.Drawing.Point(8, 74);
            this.labelDEDSingleIntFrameCount.Name = "labelDEDSingleIntFrameCount";
            this.labelDEDSingleIntFrameCount.Size = new System.Drawing.Size(44, 13);
            this.labelDEDSingleIntFrameCount.TabIndex = 4;
            this.labelDEDSingleIntFrameCount.Text = "Frames ";
            // 
            // labelDEDSingleBias
            // 
            this.labelDEDSingleBias.AutoSize = true;
            this.labelDEDSingleBias.Location = new System.Drawing.Point(8, 49);
            this.labelDEDSingleBias.Name = "labelDEDSingleBias";
            this.labelDEDSingleBias.Size = new System.Drawing.Size(70, 13);
            this.labelDEDSingleBias.TabIndex = 3;
            this.labelDEDSingleBias.Text = "Bias (V, 0-50)";
            // 
            // textBoxDEDSingleBias
            // 
            this.textBoxDEDSingleBias.Location = new System.Drawing.Point(148, 46);
            this.textBoxDEDSingleBias.Name = "textBoxDEDSingleBias";
            this.textBoxDEDSingleBias.Size = new System.Drawing.Size(47, 20);
            this.textBoxDEDSingleBias.TabIndex = 2;
            this.textBoxDEDSingleBias.Text = "50";
            // 
            // labelDEDSingleTh
            // 
            this.labelDEDSingleTh.AutoSize = true;
            this.labelDEDSingleTh.Location = new System.Drawing.Point(8, 26);
            this.labelDEDSingleTh.Name = "labelDEDSingleTh";
            this.labelDEDSingleTh.Size = new System.Drawing.Size(109, 13);
            this.labelDEDSingleTh.TabIndex = 1;
            this.labelDEDSingleTh.Text = "Threshold (keV, 3-60)";
            // 
            // textBoxDEDSingleTh
            // 
            this.textBoxDEDSingleTh.Location = new System.Drawing.Point(148, 23);
            this.textBoxDEDSingleTh.Name = "textBoxDEDSingleTh";
            this.textBoxDEDSingleTh.Size = new System.Drawing.Size(47, 20);
            this.textBoxDEDSingleTh.TabIndex = 0;
            this.textBoxDEDSingleTh.Text = "24.50";
            // 
            // labelDEDConsole
            // 
            this.labelDEDConsole.AutoSize = true;
            this.labelDEDConsole.Location = new System.Drawing.Point(592, 203);
            this.labelDEDConsole.Name = "labelDEDConsole";
            this.labelDEDConsole.Size = new System.Drawing.Size(106, 13);
            this.labelDEDConsole.TabIndex = 30;
            this.labelDEDConsole.Text = "DED Output Console";
            // 
            // groupBoxDEDGridCapture
            // 
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonDEDGridRecParams);
            this.groupBoxDEDGridCapture.Controls.Add(this.labelDEDSelectedRanges);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDSelectedYMax);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDSelectedYMin);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDSelectedXMax);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDSelectedXMin);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonDEDSelectedGrid);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonDEDFullFrameGrid);
            this.groupBoxDEDGridCapture.Location = new System.Drawing.Point(843, 469);
            this.groupBoxDEDGridCapture.Name = "groupBoxDEDGridCapture";
            this.groupBoxDEDGridCapture.Size = new System.Drawing.Size(336, 118);
            this.groupBoxDEDGridCapture.TabIndex = 31;
            this.groupBoxDEDGridCapture.TabStop = false;
            this.groupBoxDEDGridCapture.Text = "Grab Patterns Over a Grid";
            // 
            // buttonDEDGridRecParams
            // 
            this.buttonDEDGridRecParams.Location = new System.Drawing.Point(11, 85);
            this.buttonDEDGridRecParams.Name = "buttonDEDGridRecParams";
            this.buttonDEDGridRecParams.Size = new System.Drawing.Size(134, 27);
            this.buttonDEDGridRecParams.TabIndex = 7;
            this.buttonDEDGridRecParams.Text = "Record Parameters";
            this.buttonDEDGridRecParams.UseVisualStyleBackColor = true;
            this.buttonDEDGridRecParams.Click += new System.EventHandler(this.buttonDEDGridRecParams_Click);
            // 
            // labelDEDSelectedRanges
            // 
            this.labelDEDSelectedRanges.AutoSize = true;
            this.labelDEDSelectedRanges.Location = new System.Drawing.Point(11, 15);
            this.labelDEDSelectedRanges.Name = "labelDEDSelectedRanges";
            this.labelDEDSelectedRanges.Size = new System.Drawing.Size(326, 13);
            this.labelDEDSelectedRanges.TabIndex = 6;
            this.labelDEDSelectedRanges.Text = "Please navigate with spot mode in SmartSEM to confirm your range.";
            // 
            // textBoxDEDSelectedYMax
            // 
            this.textBoxDEDSelectedYMax.Location = new System.Drawing.Point(199, 30);
            this.textBoxDEDSelectedYMax.Name = "textBoxDEDSelectedYMax";
            this.textBoxDEDSelectedYMax.Size = new System.Drawing.Size(51, 20);
            this.textBoxDEDSelectedYMax.TabIndex = 5;
            this.textBoxDEDSelectedYMax.Text = "YMax";
            // 
            // textBoxDEDSelectedYMin
            // 
            this.textBoxDEDSelectedYMin.Location = new System.Drawing.Point(137, 30);
            this.textBoxDEDSelectedYMin.Name = "textBoxDEDSelectedYMin";
            this.textBoxDEDSelectedYMin.Size = new System.Drawing.Size(51, 20);
            this.textBoxDEDSelectedYMin.TabIndex = 4;
            this.textBoxDEDSelectedYMin.Text = "YMin";
            // 
            // textBoxDEDSelectedXMax
            // 
            this.textBoxDEDSelectedXMax.Location = new System.Drawing.Point(75, 30);
            this.textBoxDEDSelectedXMax.Name = "textBoxDEDSelectedXMax";
            this.textBoxDEDSelectedXMax.Size = new System.Drawing.Size(51, 20);
            this.textBoxDEDSelectedXMax.TabIndex = 3;
            this.textBoxDEDSelectedXMax.Text = "XMax";
            // 
            // textBoxDEDSelectedXMin
            // 
            this.textBoxDEDSelectedXMin.Location = new System.Drawing.Point(13, 30);
            this.textBoxDEDSelectedXMin.Name = "textBoxDEDSelectedXMin";
            this.textBoxDEDSelectedXMin.Size = new System.Drawing.Size(51, 20);
            this.textBoxDEDSelectedXMin.TabIndex = 2;
            this.textBoxDEDSelectedXMin.Text = "XMin";
            // 
            // buttonDEDSelectedGrid
            // 
            this.buttonDEDSelectedGrid.Location = new System.Drawing.Point(11, 52);
            this.buttonDEDSelectedGrid.Name = "buttonDEDSelectedGrid";
            this.buttonDEDSelectedGrid.Size = new System.Drawing.Size(134, 27);
            this.buttonDEDSelectedGrid.TabIndex = 1;
            this.buttonDEDSelectedGrid.Text = "Grab Over Range";
            this.buttonDEDSelectedGrid.UseVisualStyleBackColor = true;
            this.buttonDEDSelectedGrid.Click += new System.EventHandler(this.buttonDEDSelectedGrid_Click);
            // 
            // buttonDEDFullFrameGrid
            // 
            this.buttonDEDFullFrameGrid.Location = new System.Drawing.Point(161, 53);
            this.buttonDEDFullFrameGrid.Name = "buttonDEDFullFrameGrid";
            this.buttonDEDFullFrameGrid.Size = new System.Drawing.Size(138, 27);
            this.buttonDEDFullFrameGrid.TabIndex = 0;
            this.buttonDEDFullFrameGrid.Text = "Grab Over Entire Frame";
            this.buttonDEDFullFrameGrid.UseVisualStyleBackColor = true;
            this.buttonDEDFullFrameGrid.Click += new System.EventHandler(this.buttonDEDFullFrameGrid_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(436, 389);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(104, 21);
            this.buttonAbort.TabIndex = 32;
            this.buttonAbort.Text = "Abort Scan";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 650);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.groupBoxDEDGridCapture);
            this.Controls.Add(this.labelDEDConsole);
            this.Controls.Add(this.labelScanProgressBar);
            this.Controls.Add(this.groupBoxDEDSingleFrame);
            this.Controls.Add(this.groupBoxUtils);
            this.Controls.Add(this.progressBarScan);
            this.Controls.Add(this.textBoxDEDConsole);
            this.Controls.Add(this.groupBoxDEDInit);
            this.Controls.Add(this.textBoxSetNotify);
            this.Controls.Add(this.groupBoxRefreshNotify);
            this.Controls.Add(this.buttonSpotModeSwitch);
            this.Controls.Add(this.groupBoxFrameGrab);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.groupBoxInitialize);
            this.Controls.Add(this.groupBoxDebugUpperRight);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.buttonCloseControl);
            this.Controls.Add(this.labelCloseControls);
            this.Controls.Add(this.labelXBeamScan);
            this.Controls.Add(this.labelSetMagPrompt);
            this.Controls.Add(this.labelPreamble);
            this.Controls.Add(this.labelEnterMag);
            this.Controls.Add(this.textBoxEnterMag);
            this.Controls.Add(this.buttonSetMag);
            this.Name = "Form1";
            this.Text = "ZeissTrial Program";
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            this.groupBoxDebugUpperRight.ResumeLayout(false);
            this.groupBoxInitialize.ResumeLayout(false);
            this.groupBoxFrameGrab.ResumeLayout(false);
            this.groupBoxFrameGrab.PerformLayout();
            this.groupBoxRefreshNotify.ResumeLayout(false);
            this.groupBoxDEDInit.ResumeLayout(false);
            this.groupBoxUtils.ResumeLayout(false);
            this.groupBoxDEDSingleFrame.ResumeLayout(false);
            this.groupBoxDEDSingleFrame.PerformLayout();
            this.groupBoxDEDGridCapture.ResumeLayout(false);
            this.groupBoxDEDGridCapture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetCZEMApiVersion;
        private System.Windows.Forms.Button buttonInitialiseCZEMApi;
        private System.Windows.Forms.Button buttonGetBeamPosnLimits;
        private System.Windows.Forms.Button buttonXBeamScan;
        private System.Windows.Forms.Button buttonSetMag;
        private System.Windows.Forms.TextBox textBoxEnterMag;
        private System.Windows.Forms.Label labelEnterMag;
        private System.Windows.Forms.Label labelPreamble;
        private System.Windows.Forms.Label labelSetMagPrompt;
        private System.Windows.Forms.Label labelXBeamScan;
        private System.Windows.Forms.Button buttonXYBeamScan;
        private System.Windows.Forms.Label labelCloseControls;
        private System.Windows.Forms.Button buttonCloseControl;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.TextBox textBoxInit;
        private System.Windows.Forms.GroupBox groupBoxDebugUpperRight;
        private System.Windows.Forms.GroupBox groupBoxInitialize;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TextBox textBoxVacStatus;
        private System.Windows.Forms.Button buttonRefreshParams;
        private System.Windows.Forms.TextBox textBoxRunupstate;
        private System.Windows.Forms.TextBox textBoxActualkv;
        private System.Windows.Forms.TextBox textBoxActualCurrent;
        private System.Windows.Forms.TextBox textBoxIprobe;
        private System.Windows.Forms.TextBox textBoxSpotMode;
        private System.Windows.Forms.TextBox textBoxScanrate;
        private System.Windows.Forms.TextBox textBoxMag;
        private System.Windows.Forms.TextBox textBoxPixelSize;
        private System.Windows.Forms.TextBox textBoxWD;
        private System.Windows.Forms.TextBox textBoxDetectorType;
        private System.Windows.Forms.GroupBox groupBoxFrameGrab;
        private System.Windows.Forms.Button buttonGrabImage2File;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserFrameGrab;
        private System.Windows.Forms.Button buttonBrowseFrameGrab;
        private System.Windows.Forms.TextBox textBoxFrameGrabDirectory;
        private System.Windows.Forms.Button buttonGrabPixelValue;
        private System.Windows.Forms.Button buttonSpotModeSwitch;
        private System.Windows.Forms.ProgressBar progressBarScan;
        private System.Windows.Forms.Label labelScanProgressBar;
        private System.Windows.Forms.Button buttonXScanGrabPixelValue;
        private System.Windows.Forms.TextBox textBoxDetectorChannel;
        private System.Windows.Forms.TextBox textBoxApertureSize;
        private System.Windows.Forms.TextBox textBoxBrightness;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.TextBox textBoxHighCurrent;
        private System.Windows.Forms.GroupBox groupBoxRefreshNotify;
        private System.Windows.Forms.Button buttonSetNotify;
        private System.Windows.Forms.TextBox textBoxSetNotify;
        private System.Windows.Forms.Button buttonMagMap;
        private System.Windows.Forms.Button buttonInitializeRemote;
        private System.Windows.Forms.GroupBox groupBoxDEDInit;
        private System.Windows.Forms.TextBox textBoxDEDConsole;
        private System.Windows.Forms.GroupBox groupBoxUtils;
        private System.Windows.Forms.Button buttonDEDThSweep;
        private System.Windows.Forms.Button buttonPIXETVersion;
        private System.Windows.Forms.GroupBox groupBoxDEDSingleFrame;
        private System.Windows.Forms.Button buttonDEDSingleCapture;
        private System.Windows.Forms.Button buttonDEDSingleSaveBrowse;
        private System.Windows.Forms.TextBox textBoxDEDDirectory;
        private System.Windows.Forms.Label labelDEDSingleSaveHint;
        private System.Windows.Forms.TextBox textBoxDEDSingleIdentifier;
        private System.Windows.Forms.Label labelDEDSingleIdentifier;
        private System.Windows.Forms.TextBox textBoxDEDSingleFrameTime;
        private System.Windows.Forms.Label labelDEDSingleFrameTime;
        private System.Windows.Forms.TextBox textBoxDEDSingleIntFrameCount;
        private System.Windows.Forms.Label labelDEDSingleIntFrameCount;
        private System.Windows.Forms.Label labelDEDSingleBias;
        private System.Windows.Forms.TextBox textBoxDEDSingleBias;
        private System.Windows.Forms.Label labelDEDSingleTh;
        private System.Windows.Forms.TextBox textBoxDEDSingleTh;
        private System.Windows.Forms.Label labelDEDConsole;
        private System.Windows.Forms.Button buttonCheckDEDConnection;
        private System.Windows.Forms.Button buttonDEDSingleTrialCapture;
        private System.Windows.Forms.Button buttonDEDShowThBias;
        private System.Windows.Forms.Button buttonDEDBiasSweep;
        private System.Windows.Forms.TextBox textBoxStageZ;
        private System.Windows.Forms.TextBox textBoxStageY;
        private System.Windows.Forms.TextBox textBoxStageX;
        private System.Windows.Forms.GroupBox groupBoxDEDGridCapture;
        private System.Windows.Forms.Label labelDEDSelectedRanges;
        private System.Windows.Forms.TextBox textBoxDEDSelectedYMax;
        private System.Windows.Forms.TextBox textBoxDEDSelectedYMin;
        private System.Windows.Forms.TextBox textBoxDEDSelectedXMax;
        private System.Windows.Forms.TextBox textBoxDEDSelectedXMin;
        private System.Windows.Forms.Button buttonDEDSelectedGrid;
        private System.Windows.Forms.Button buttonDEDFullFrameGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDEDGridRecParams;
        private System.Windows.Forms.Label labelFrameGrabFileNamePart2;
        private System.Windows.Forms.Label labelFrameGrabFileName;
        private System.Windows.Forms.TextBox textBoxFrameGrabFileName;
        private System.Windows.Forms.Button buttonDEDTemperatureRead;
        private System.Windows.Forms.Button buttonDEDTrial2;
        private System.Windows.Forms.Button buttonDEDTrial1;
        private System.Windows.Forms.Button buttonAbort;
    }
}

