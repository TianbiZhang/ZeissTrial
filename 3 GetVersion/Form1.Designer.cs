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
            this.buttonGrabPixelValue = new System.Windows.Forms.Button();
            this.groupBoxInitialize = new System.Windows.Forms.GroupBox();
            this.buttonInitializeRemote = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonRefreshParams = new System.Windows.Forms.Button();
            this.groupBoxFrameGrab = new System.Windows.Forms.GroupBox();
            this.labelSeriesGrabFileName = new System.Windows.Forms.Label();
            this.labelSeriesGrabName = new System.Windows.Forms.Label();
            this.textBoxSeriesGrabName = new System.Windows.Forms.TextBox();
            this.buttonSeriesGrab = new System.Windows.Forms.Button();
            this.labelSeriesGrabDefault = new System.Windows.Forms.Label();
            this.buttonSeriesGrabIndexReset = new System.Windows.Forms.Button();
            this.labelCurrentSeriesGrabIndex = new System.Windows.Forms.Label();
            this.numericUpDownSeriesGrab = new System.Windows.Forms.NumericUpDown();
            this.labelSeriesGrabHint = new System.Windows.Forms.Label();
            this.labelGrabDirectoryHint = new System.Windows.Forms.Label();
            this.labelFrameGrabFileNamePart2 = new System.Windows.Forms.Label();
            this.labelFrameGrabFileName = new System.Windows.Forms.Label();
            this.textBoxFrameGrabFileName = new System.Windows.Forms.TextBox();
            this.textBoxFrameGrabDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowseFrameGrab = new System.Windows.Forms.Button();
            this.buttonGrabImage2File = new System.Windows.Forms.Button();
            this.folderBrowserFrameGrab = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSpotModeSwitch = new System.Windows.Forms.Button();
            this.groupBoxRefreshNotify = new System.Windows.Forms.GroupBox();
            this.buttonSetNotify = new System.Windows.Forms.Button();
            this.textBoxSetNotify = new System.Windows.Forms.TextBox();
            this.groupBoxDEDInit = new System.Windows.Forms.GroupBox();
            this.buttonDEDTemperatureRead = new System.Windows.Forms.Button();
            this.buttonDEDThSweep = new System.Windows.Forms.Button();
            this.buttonCheckDEDConnection = new System.Windows.Forms.Button();
            this.buttonDEDShowThBias = new System.Windows.Forms.Button();
            this.buttonPIXETVersion = new System.Windows.Forms.Button();
            this.buttonStartFakeGUI = new System.Windows.Forms.Button();
            this.buttonStartDEDGUI = new System.Windows.Forms.Button();
            this.textBoxDEDConsole = new System.Windows.Forms.TextBox();
            this.groupBoxUtils = new System.Windows.Forms.GroupBox();
            this.textBoxSpotPosn = new System.Windows.Forms.TextBox();
            this.buttonReadSpotPosn = new System.Windows.Forms.Button();
            this.textBoxGUIStatus = new System.Windows.Forms.TextBox();
            this.numericUpDownClickWait = new System.Windows.Forms.NumericUpDown();
            this.textBoxMouseCoords = new System.Windows.Forms.TextBox();
            this.buttonReadCoords = new System.Windows.Forms.Button();
            this.buttonWriteDEDConsoleLog = new System.Windows.Forms.Button();
            this.buttonDEDSingleSaveBrowse = new System.Windows.Forms.Button();
            this.textBoxDEDDirectory = new System.Windows.Forms.TextBox();
            this.labelDEDConsole = new System.Windows.Forms.Label();
            this.groupBoxDEDGridCapture = new System.Windows.Forms.GroupBox();
            this.textBoxDEDGridSpaced = new System.Windows.Forms.TextBox();
            this.labelSpacedGridNotice = new System.Windows.Forms.Label();
            this.buttonSpacedGridScan = new System.Windows.Forms.Button();
            this.buttonGenSpacedGrid = new System.Windows.Forms.Button();
            this.textBoxYSpacingNum = new System.Windows.Forms.TextBox();
            this.textBoxXSpacingNum = new System.Windows.Forms.TextBox();
            this.textBoxYGridSpacing = new System.Windows.Forms.TextBox();
            this.labelXYGridSpacing = new System.Windows.Forms.Label();
            this.textBoxXGridSpacing = new System.Windows.Forms.TextBox();
            this.labelDEDSelectedRanges2 = new System.Windows.Forms.Label();
            this.textBoxDEDGridCoords = new System.Windows.Forms.TextBox();
            this.labelDEDGridSTatus = new System.Windows.Forms.Label();
            this.textBoxDEDGridRand = new System.Windows.Forms.TextBox();
            this.textBoxDEDGridReg = new System.Windows.Forms.TextBox();
            this.labelDEDBrowse = new System.Windows.Forms.Label();
            this.buttonGenRegGrid = new System.Windows.Forms.Button();
            this.buttonRandGridScan = new System.Windows.Forms.Button();
            this.buttonGenRandGrid = new System.Windows.Forms.Button();
            this.buttonDEDSelectedGridMouse = new System.Windows.Forms.Button();
            this.labelDEDSelectedRanges = new System.Windows.Forms.Label();
            this.textBoxDEDSelectedYMax = new System.Windows.Forms.TextBox();
            this.textBoxDEDSelectedYMin = new System.Windows.Forms.TextBox();
            this.textBoxDEDSelectedXMax = new System.Windows.Forms.TextBox();
            this.textBoxDEDSelectedXMin = new System.Windows.Forms.TextBox();
            this.buttonGridReset = new System.Windows.Forms.Button();
            this.buttonDEDGridRecParams = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonWriteSEMLog = new System.Windows.Forms.Button();
            this.groupBoxParams.SuspendLayout();
            this.groupBoxDebugUpperRight.SuspendLayout();
            this.groupBoxInitialize.SuspendLayout();
            this.groupBoxFrameGrab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeriesGrab)).BeginInit();
            this.groupBoxRefreshNotify.SuspendLayout();
            this.groupBoxDEDInit.SuspendLayout();
            this.groupBoxUtils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClickWait)).BeginInit();
            this.groupBoxDEDGridCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetCZEMApiVersion
            // 
            this.buttonGetCZEMApiVersion.Location = new System.Drawing.Point(9, 19);
            this.buttonGetCZEMApiVersion.Name = "buttonGetCZEMApiVersion";
            this.buttonGetCZEMApiVersion.Size = new System.Drawing.Size(93, 36);
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
            this.buttonGetBeamPosnLimits.Location = new System.Drawing.Point(9, 63);
            this.buttonGetBeamPosnLimits.Name = "buttonGetBeamPosnLimits";
            this.buttonGetBeamPosnLimits.Size = new System.Drawing.Size(93, 36);
            this.buttonGetBeamPosnLimits.TabIndex = 2;
            this.buttonGetBeamPosnLimits.Text = "Get Spot Posn Limits";
            this.buttonGetBeamPosnLimits.UseVisualStyleBackColor = true;
            this.buttonGetBeamPosnLimits.Click += new System.EventHandler(this.buttonGetBeamPosnLimits_Click);
            // 
            // buttonXBeamScan
            // 
            this.buttonXBeamScan.Location = new System.Drawing.Point(9, 106);
            this.buttonXBeamScan.Name = "buttonXBeamScan";
            this.buttonXBeamScan.Size = new System.Drawing.Size(93, 34);
            this.buttonXBeamScan.TabIndex = 3;
            this.buttonXBeamScan.Text = "Perform X Beam Scan";
            this.buttonXBeamScan.UseVisualStyleBackColor = true;
            this.buttonXBeamScan.Click += new System.EventHandler(this.buttonXBeamScan_Click);
            // 
            // buttonSetMag
            // 
            this.buttonSetMag.Location = new System.Drawing.Point(151, 381);
            this.buttonSetMag.Name = "buttonSetMag";
            this.buttonSetMag.Size = new System.Drawing.Size(59, 20);
            this.buttonSetMag.TabIndex = 4;
            this.buttonSetMag.Text = "Set Mag";
            this.buttonSetMag.UseVisualStyleBackColor = true;
            this.buttonSetMag.Click += new System.EventHandler(this.buttonSetMag_Click);
            // 
            // textBoxEnterMag
            // 
            this.textBoxEnterMag.Location = new System.Drawing.Point(43, 381);
            this.textBoxEnterMag.Name = "textBoxEnterMag";
            this.textBoxEnterMag.Size = new System.Drawing.Size(102, 20);
            this.textBoxEnterMag.TabIndex = 5;
            this.textBoxEnterMag.Text = "Enter Mag here";
            // 
            // labelEnterMag
            // 
            this.labelEnterMag.AutoSize = true;
            this.labelEnterMag.Location = new System.Drawing.Point(34, 407);
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
            this.labelSetMagPrompt.Location = new System.Drawing.Point(34, 365);
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
            this.buttonXYBeamScan.Location = new System.Drawing.Point(126, 63);
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
            this.labelCloseControls.Location = new System.Drawing.Point(26, 644);
            this.labelCloseControls.Name = "labelCloseControls";
            this.labelCloseControls.Size = new System.Drawing.Size(236, 13);
            this.labelCloseControls.TabIndex = 16;
            this.labelCloseControls.Text = "Please close controls before closing the window!";
            // 
            // buttonCloseControl
            // 
            this.buttonCloseControl.Location = new System.Drawing.Point(29, 660);
            this.buttonCloseControl.Name = "buttonCloseControl";
            this.buttonCloseControl.Size = new System.Drawing.Size(92, 32);
            this.buttonCloseControl.TabIndex = 17;
            this.buttonCloseControl.Text = "Close SEM API";
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
            this.groupBoxParams.Location = new System.Drawing.Point(29, 470);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(533, 170);
            this.groupBoxParams.TabIndex = 18;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "SEM Parameters and Status";
            // 
            // textBoxStageZ
            // 
            this.textBoxStageZ.Location = new System.Drawing.Point(400, 135);
            this.textBoxStageZ.Name = "textBoxStageZ";
            this.textBoxStageZ.ReadOnly = true;
            this.textBoxStageZ.Size = new System.Drawing.Size(120, 20);
            this.textBoxStageZ.TabIndex = 30;
            // 
            // textBoxStageY
            // 
            this.textBoxStageY.Location = new System.Drawing.Point(271, 135);
            this.textBoxStageY.Name = "textBoxStageY";
            this.textBoxStageY.ReadOnly = true;
            this.textBoxStageY.Size = new System.Drawing.Size(120, 20);
            this.textBoxStageY.TabIndex = 29;
            // 
            // textBoxStageX
            // 
            this.textBoxStageX.Location = new System.Drawing.Point(142, 135);
            this.textBoxStageX.Name = "textBoxStageX";
            this.textBoxStageX.ReadOnly = true;
            this.textBoxStageX.Size = new System.Drawing.Size(120, 20);
            this.textBoxStageX.TabIndex = 28;
            // 
            // textBoxHighCurrent
            // 
            this.textBoxHighCurrent.Location = new System.Drawing.Point(13, 135);
            this.textBoxHighCurrent.Name = "textBoxHighCurrent";
            this.textBoxHighCurrent.ReadOnly = true;
            this.textBoxHighCurrent.Size = new System.Drawing.Size(120, 20);
            this.textBoxHighCurrent.TabIndex = 27;
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Location = new System.Drawing.Point(400, 106);
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.ReadOnly = true;
            this.textBoxContrast.Size = new System.Drawing.Size(120, 20);
            this.textBoxContrast.TabIndex = 15;
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Location = new System.Drawing.Point(400, 77);
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.ReadOnly = true;
            this.textBoxBrightness.Size = new System.Drawing.Size(120, 20);
            this.textBoxBrightness.TabIndex = 14;
            // 
            // textBoxApertureSize
            // 
            this.textBoxApertureSize.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxApertureSize.Location = new System.Drawing.Point(271, 106);
            this.textBoxApertureSize.Name = "textBoxApertureSize";
            this.textBoxApertureSize.Size = new System.Drawing.Size(120, 20);
            this.textBoxApertureSize.TabIndex = 13;
            // 
            // textBoxDetectorChannel
            // 
            this.textBoxDetectorChannel.Location = new System.Drawing.Point(400, 48);
            this.textBoxDetectorChannel.Name = "textBoxDetectorChannel";
            this.textBoxDetectorChannel.ReadOnly = true;
            this.textBoxDetectorChannel.Size = new System.Drawing.Size(120, 20);
            this.textBoxDetectorChannel.TabIndex = 12;
            // 
            // textBoxDetectorType
            // 
            this.textBoxDetectorType.Location = new System.Drawing.Point(400, 20);
            this.textBoxDetectorType.Name = "textBoxDetectorType";
            this.textBoxDetectorType.ReadOnly = true;
            this.textBoxDetectorType.Size = new System.Drawing.Size(120, 20);
            this.textBoxDetectorType.TabIndex = 11;
            // 
            // textBoxWD
            // 
            this.textBoxWD.Location = new System.Drawing.Point(271, 77);
            this.textBoxWD.Name = "textBoxWD";
            this.textBoxWD.ReadOnly = true;
            this.textBoxWD.Size = new System.Drawing.Size(120, 20);
            this.textBoxWD.TabIndex = 10;
            // 
            // textBoxPixelSize
            // 
            this.textBoxPixelSize.Location = new System.Drawing.Point(271, 48);
            this.textBoxPixelSize.Name = "textBoxPixelSize";
            this.textBoxPixelSize.ReadOnly = true;
            this.textBoxPixelSize.Size = new System.Drawing.Size(120, 20);
            this.textBoxPixelSize.TabIndex = 9;
            // 
            // textBoxMag
            // 
            this.textBoxMag.Location = new System.Drawing.Point(271, 20);
            this.textBoxMag.Name = "textBoxMag";
            this.textBoxMag.ReadOnly = true;
            this.textBoxMag.Size = new System.Drawing.Size(120, 20);
            this.textBoxMag.TabIndex = 8;
            // 
            // textBoxScanrate
            // 
            this.textBoxScanrate.Location = new System.Drawing.Point(142, 106);
            this.textBoxScanrate.Name = "textBoxScanrate";
            this.textBoxScanrate.ReadOnly = true;
            this.textBoxScanrate.Size = new System.Drawing.Size(120, 20);
            this.textBoxScanrate.TabIndex = 7;
            // 
            // textBoxSpotMode
            // 
            this.textBoxSpotMode.Location = new System.Drawing.Point(142, 77);
            this.textBoxSpotMode.Name = "textBoxSpotMode";
            this.textBoxSpotMode.ReadOnly = true;
            this.textBoxSpotMode.Size = new System.Drawing.Size(120, 20);
            this.textBoxSpotMode.TabIndex = 6;
            // 
            // textBoxIprobe
            // 
            this.textBoxIprobe.Location = new System.Drawing.Point(142, 48);
            this.textBoxIprobe.Name = "textBoxIprobe";
            this.textBoxIprobe.ReadOnly = true;
            this.textBoxIprobe.Size = new System.Drawing.Size(120, 20);
            this.textBoxIprobe.TabIndex = 5;
            this.textBoxIprobe.TextChanged += new System.EventHandler(this.textBoxIprobe_TextChanged);
            // 
            // textBoxActualCurrent
            // 
            this.textBoxActualCurrent.Location = new System.Drawing.Point(142, 20);
            this.textBoxActualCurrent.Name = "textBoxActualCurrent";
            this.textBoxActualCurrent.ReadOnly = true;
            this.textBoxActualCurrent.Size = new System.Drawing.Size(120, 20);
            this.textBoxActualCurrent.TabIndex = 4;
            // 
            // textBoxActualkv
            // 
            this.textBoxActualkv.Location = new System.Drawing.Point(13, 106);
            this.textBoxActualkv.Name = "textBoxActualkv";
            this.textBoxActualkv.ReadOnly = true;
            this.textBoxActualkv.Size = new System.Drawing.Size(120, 20);
            this.textBoxActualkv.TabIndex = 3;
            // 
            // textBoxRunupstate
            // 
            this.textBoxRunupstate.Location = new System.Drawing.Point(13, 77);
            this.textBoxRunupstate.Name = "textBoxRunupstate";
            this.textBoxRunupstate.ReadOnly = true;
            this.textBoxRunupstate.Size = new System.Drawing.Size(120, 20);
            this.textBoxRunupstate.TabIndex = 2;
            // 
            // textBoxVacStatus
            // 
            this.textBoxVacStatus.Location = new System.Drawing.Point(13, 48);
            this.textBoxVacStatus.Name = "textBoxVacStatus";
            this.textBoxVacStatus.ReadOnly = true;
            this.textBoxVacStatus.Size = new System.Drawing.Size(120, 20);
            this.textBoxVacStatus.TabIndex = 1;
            // 
            // textBoxInit
            // 
            this.textBoxInit.Location = new System.Drawing.Point(13, 20);
            this.textBoxInit.Name = "textBoxInit";
            this.textBoxInit.ReadOnly = true;
            this.textBoxInit.Size = new System.Drawing.Size(120, 20);
            this.textBoxInit.TabIndex = 0;
            // 
            // labelScanProgressBar
            // 
            this.labelScanProgressBar.AutoSize = true;
            this.labelScanProgressBar.Location = new System.Drawing.Point(34, 428);
            this.labelScanProgressBar.Name = "labelScanProgressBar";
            this.labelScanProgressBar.Size = new System.Drawing.Size(96, 13);
            this.labelScanProgressBar.TabIndex = 26;
            this.labelScanProgressBar.Text = "Scanning Progress";
            // 
            // progressBarScan
            // 
            this.progressBarScan.Location = new System.Drawing.Point(37, 445);
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(173, 19);
            this.progressBarScan.TabIndex = 25;
            // 
            // groupBoxDebugUpperRight
            // 
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonMagMap);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonXBeamScan);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonGetBeamPosnLimits);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonGrabPixelValue);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonGetCZEMApiVersion);
            this.groupBoxDebugUpperRight.Controls.Add(this.buttonXYBeamScan);
            this.groupBoxDebugUpperRight.Location = new System.Drawing.Point(331, 35);
            this.groupBoxDebugUpperRight.Name = "groupBoxDebugUpperRight";
            this.groupBoxDebugUpperRight.Size = new System.Drawing.Size(232, 153);
            this.groupBoxDebugUpperRight.TabIndex = 19;
            this.groupBoxDebugUpperRight.TabStop = false;
            this.groupBoxDebugUpperRight.Text = "Quick Testing/Debugging Tools";
            // 
            // buttonMagMap
            // 
            this.buttonMagMap.Location = new System.Drawing.Point(126, 19);
            this.buttonMagMap.Name = "buttonMagMap";
            this.buttonMagMap.Size = new System.Drawing.Size(92, 36);
            this.buttonMagMap.TabIndex = 5;
            this.buttonMagMap.Text = "Mag Map";
            this.buttonMagMap.UseVisualStyleBackColor = true;
            this.buttonMagMap.Click += new System.EventHandler(this.buttonMagMap_Click);
            // 
            // buttonGrabPixelValue
            // 
            this.buttonGrabPixelValue.Enabled = false;
            this.buttonGrabPixelValue.Location = new System.Drawing.Point(126, 106);
            this.buttonGrabPixelValue.Name = "buttonGrabPixelValue";
            this.buttonGrabPixelValue.Size = new System.Drawing.Size(92, 35);
            this.buttonGrabPixelValue.TabIndex = 4;
            this.buttonGrabPixelValue.Text = "Grab pixel grayscale to a text file";
            this.buttonGrabPixelValue.UseVisualStyleBackColor = true;
            this.buttonGrabPixelValue.Click += new System.EventHandler(this.buttonGrabPixelValue_Click);
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
            this.buttonQuit.Location = new System.Drawing.Point(127, 660);
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
            this.groupBoxFrameGrab.Controls.Add(this.labelSeriesGrabFileName);
            this.groupBoxFrameGrab.Controls.Add(this.labelSeriesGrabName);
            this.groupBoxFrameGrab.Controls.Add(this.textBoxSeriesGrabName);
            this.groupBoxFrameGrab.Controls.Add(this.buttonSeriesGrab);
            this.groupBoxFrameGrab.Controls.Add(this.labelSeriesGrabDefault);
            this.groupBoxFrameGrab.Controls.Add(this.buttonSeriesGrabIndexReset);
            this.groupBoxFrameGrab.Controls.Add(this.labelCurrentSeriesGrabIndex);
            this.groupBoxFrameGrab.Controls.Add(this.numericUpDownSeriesGrab);
            this.groupBoxFrameGrab.Controls.Add(this.labelSeriesGrabHint);
            this.groupBoxFrameGrab.Controls.Add(this.labelGrabDirectoryHint);
            this.groupBoxFrameGrab.Controls.Add(this.labelFrameGrabFileNamePart2);
            this.groupBoxFrameGrab.Controls.Add(this.labelFrameGrabFileName);
            this.groupBoxFrameGrab.Controls.Add(this.textBoxFrameGrabFileName);
            this.groupBoxFrameGrab.Controls.Add(this.textBoxFrameGrabDirectory);
            this.groupBoxFrameGrab.Controls.Add(this.buttonBrowseFrameGrab);
            this.groupBoxFrameGrab.Controls.Add(this.buttonGrabImage2File);
            this.groupBoxFrameGrab.Location = new System.Drawing.Point(331, 199);
            this.groupBoxFrameGrab.Name = "groupBoxFrameGrab";
            this.groupBoxFrameGrab.Size = new System.Drawing.Size(232, 265);
            this.groupBoxFrameGrab.TabIndex = 23;
            this.groupBoxFrameGrab.TabStop = false;
            this.groupBoxFrameGrab.Text = "Grab Current Frame";
            // 
            // labelSeriesGrabFileName
            // 
            this.labelSeriesGrabFileName.AutoSize = true;
            this.labelSeriesGrabFileName.Location = new System.Drawing.Point(2, 213);
            this.labelSeriesGrabFileName.Name = "labelSeriesGrabFileName";
            this.labelSeriesGrabFileName.Size = new System.Drawing.Size(229, 13);
            this.labelSeriesGrabFileName.TabIndex = 37;
            this.labelSeriesGrabFileName.Text = "Image will be saved as \"SeriesName_index.tiff\"";
            // 
            // labelSeriesGrabName
            // 
            this.labelSeriesGrabName.AutoSize = true;
            this.labelSeriesGrabName.Location = new System.Drawing.Point(9, 160);
            this.labelSeriesGrabName.Name = "labelSeriesGrabName";
            this.labelSeriesGrabName.Size = new System.Drawing.Size(68, 13);
            this.labelSeriesGrabName.TabIndex = 36;
            this.labelSeriesGrabName.Text = "Series name:";
            // 
            // textBoxSeriesGrabName
            // 
            this.textBoxSeriesGrabName.Location = new System.Drawing.Point(84, 156);
            this.textBoxSeriesGrabName.Name = "textBoxSeriesGrabName";
            this.textBoxSeriesGrabName.Size = new System.Drawing.Size(75, 20);
            this.textBoxSeriesGrabName.TabIndex = 35;
            this.textBoxSeriesGrabName.Text = "Series1";
            // 
            // buttonSeriesGrab
            // 
            this.buttonSeriesGrab.Location = new System.Drawing.Point(9, 182);
            this.buttonSeriesGrab.Name = "buttonSeriesGrab";
            this.buttonSeriesGrab.Size = new System.Drawing.Size(208, 28);
            this.buttonSeriesGrab.TabIndex = 34;
            this.buttonSeriesGrab.Text = "Grab image at current index";
            this.buttonSeriesGrab.UseVisualStyleBackColor = true;
            this.buttonSeriesGrab.Click += new System.EventHandler(this.buttonSeriesGrab_Click);
            // 
            // labelSeriesGrabDefault
            // 
            this.labelSeriesGrabDefault.AutoSize = true;
            this.labelSeriesGrabDefault.Location = new System.Drawing.Point(7, 137);
            this.labelSeriesGrabDefault.Name = "labelSeriesGrabDefault";
            this.labelSeriesGrabDefault.Size = new System.Drawing.Size(211, 13);
            this.labelSeriesGrabDefault.TabIndex = 33;
            this.labelSeriesGrabDefault.Text = "Default settings: Scan speed 7, line int N=4";
            // 
            // buttonSeriesGrabIndexReset
            // 
            this.buttonSeriesGrabIndexReset.Location = new System.Drawing.Point(149, 114);
            this.buttonSeriesGrabIndexReset.Name = "buttonSeriesGrabIndexReset";
            this.buttonSeriesGrabIndexReset.Size = new System.Drawing.Size(68, 20);
            this.buttonSeriesGrabIndexReset.TabIndex = 32;
            this.buttonSeriesGrabIndexReset.Text = "Reset";
            this.buttonSeriesGrabIndexReset.UseVisualStyleBackColor = true;
            this.buttonSeriesGrabIndexReset.Click += new System.EventHandler(this.buttonSeriesGrabIndexReset_Click);
            // 
            // labelCurrentSeriesGrabIndex
            // 
            this.labelCurrentSeriesGrabIndex.AutoSize = true;
            this.labelCurrentSeriesGrabIndex.Location = new System.Drawing.Point(7, 118);
            this.labelCurrentSeriesGrabIndex.Name = "labelCurrentSeriesGrabIndex";
            this.labelCurrentSeriesGrabIndex.Size = new System.Drawing.Size(73, 13);
            this.labelCurrentSeriesGrabIndex.TabIndex = 31;
            this.labelCurrentSeriesGrabIndex.Text = "Current Index:";
            // 
            // numericUpDownSeriesGrab
            // 
            this.numericUpDownSeriesGrab.Location = new System.Drawing.Point(84, 114);
            this.numericUpDownSeriesGrab.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownSeriesGrab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeriesGrab.Name = "numericUpDownSeriesGrab";
            this.numericUpDownSeriesGrab.ReadOnly = true;
            this.numericUpDownSeriesGrab.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownSeriesGrab.TabIndex = 30;
            this.numericUpDownSeriesGrab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSeriesGrabHint
            // 
            this.labelSeriesGrabHint.AutoSize = true;
            this.labelSeriesGrabHint.Location = new System.Drawing.Point(6, 95);
            this.labelSeriesGrabHint.Name = "labelSeriesGrabHint";
            this.labelSeriesGrabHint.Size = new System.Drawing.Size(187, 13);
            this.labelSeriesGrabHint.TabIndex = 22;
            this.labelSeriesGrabHint.Text = "Grab a series of images with a counter";
            // 
            // labelGrabDirectoryHint
            // 
            this.labelGrabDirectoryHint.AutoSize = true;
            this.labelGrabDirectoryHint.Location = new System.Drawing.Point(6, 19);
            this.labelGrabDirectoryHint.Name = "labelGrabDirectoryHint";
            this.labelGrabDirectoryHint.Size = new System.Drawing.Size(133, 13);
            this.labelGrabDirectoryHint.TabIndex = 14;
            this.labelGrabDirectoryHint.Text = "Choose the save directory:";
            // 
            // labelFrameGrabFileNamePart2
            // 
            this.labelFrameGrabFileNamePart2.AutoSize = true;
            this.labelFrameGrabFileNamePart2.Location = new System.Drawing.Point(114, 67);
            this.labelFrameGrabFileNamePart2.Name = "labelFrameGrabFileNamePart2";
            this.labelFrameGrabFileNamePart2.Size = new System.Drawing.Size(27, 13);
            this.labelFrameGrabFileNamePart2.TabIndex = 7;
            this.labelFrameGrabFileNamePart2.Text = "(.tiff)";
            // 
            // labelFrameGrabFileName
            // 
            this.labelFrameGrabFileName.AutoSize = true;
            this.labelFrameGrabFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelFrameGrabFileName.Location = new System.Drawing.Point(6, 66);
            this.labelFrameGrabFileName.Name = "labelFrameGrabFileName";
            this.labelFrameGrabFileName.Size = new System.Drawing.Size(55, 13);
            this.labelFrameGrabFileName.TabIndex = 6;
            this.labelFrameGrabFileName.Text = "File name:";
            // 
            // textBoxFrameGrabFileName
            // 
            this.textBoxFrameGrabFileName.Location = new System.Drawing.Point(62, 63);
            this.textBoxFrameGrabFileName.Name = "textBoxFrameGrabFileName";
            this.textBoxFrameGrabFileName.Size = new System.Drawing.Size(49, 20);
            this.textBoxFrameGrabFileName.TabIndex = 5;
            this.textBoxFrameGrabFileName.Text = "Frame";
            // 
            // textBoxFrameGrabDirectory
            // 
            this.textBoxFrameGrabDirectory.Location = new System.Drawing.Point(9, 35);
            this.textBoxFrameGrabDirectory.Name = "textBoxFrameGrabDirectory";
            this.textBoxFrameGrabDirectory.Size = new System.Drawing.Size(132, 20);
            this.textBoxFrameGrabDirectory.TabIndex = 3;
            // 
            // buttonBrowseFrameGrab
            // 
            this.buttonBrowseFrameGrab.Location = new System.Drawing.Point(147, 35);
            this.buttonBrowseFrameGrab.Name = "buttonBrowseFrameGrab";
            this.buttonBrowseFrameGrab.Size = new System.Drawing.Size(71, 20);
            this.buttonBrowseFrameGrab.TabIndex = 2;
            this.buttonBrowseFrameGrab.Text = "Browse...";
            this.buttonBrowseFrameGrab.UseVisualStyleBackColor = true;
            this.buttonBrowseFrameGrab.Click += new System.EventHandler(this.buttonBrowseFrameGrab_Click);
            // 
            // buttonGrabImage2File
            // 
            this.buttonGrabImage2File.Location = new System.Drawing.Point(147, 64);
            this.buttonGrabImage2File.Name = "buttonGrabImage2File";
            this.buttonGrabImage2File.Size = new System.Drawing.Size(71, 19);
            this.buttonGrabImage2File.TabIndex = 0;
            this.buttonGrabImage2File.Text = "QuickGrab";
            this.buttonGrabImage2File.UseVisualStyleBackColor = true;
            this.buttonGrabImage2File.Click += new System.EventHandler(this.buttonGrabImage2File_Click);
            // 
            // folderBrowserFrameGrab
            // 
            this.folderBrowserFrameGrab.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // buttonSpotModeSwitch
            // 
            this.buttonSpotModeSwitch.Location = new System.Drawing.Point(216, 381);
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
            this.textBoxSetNotify.Location = new System.Drawing.Point(29, 141);
            this.textBoxSetNotify.Multiline = true;
            this.textBoxSetNotify.Name = "textBoxSetNotify";
            this.textBoxSetNotify.ReadOnly = true;
            this.textBoxSetNotify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSetNotify.Size = new System.Drawing.Size(272, 221);
            this.textBoxSetNotify.TabIndex = 24;
            // 
            // groupBoxDEDInit
            // 
            this.groupBoxDEDInit.Controls.Add(this.buttonDEDTemperatureRead);
            this.groupBoxDEDInit.Controls.Add(this.buttonDEDThSweep);
            this.groupBoxDEDInit.Controls.Add(this.buttonCheckDEDConnection);
            this.groupBoxDEDInit.Controls.Add(this.buttonDEDShowThBias);
            this.groupBoxDEDInit.Controls.Add(this.buttonPIXETVersion);
            this.groupBoxDEDInit.Location = new System.Drawing.Point(584, 35);
            this.groupBoxDEDInit.Name = "groupBoxDEDInit";
            this.groupBoxDEDInit.Size = new System.Drawing.Size(240, 153);
            this.groupBoxDEDInit.TabIndex = 26;
            this.groupBoxDEDInit.TabStop = false;
            this.groupBoxDEDInit.Text = "DED Controls";
            // 
            // buttonDEDTemperatureRead
            // 
            this.buttonDEDTemperatureRead.Enabled = false;
            this.buttonDEDTemperatureRead.Location = new System.Drawing.Point(128, 63);
            this.buttonDEDTemperatureRead.Name = "buttonDEDTemperatureRead";
            this.buttonDEDTemperatureRead.Size = new System.Drawing.Size(95, 34);
            this.buttonDEDTemperatureRead.TabIndex = 4;
            this.buttonDEDTemperatureRead.Text = "Read Temperature";
            this.buttonDEDTemperatureRead.UseVisualStyleBackColor = true;
            this.buttonDEDTemperatureRead.Click += new System.EventHandler(this.DEDTemperatureRead_Click);
            // 
            // buttonDEDThSweep
            // 
            this.buttonDEDThSweep.Enabled = false;
            this.buttonDEDThSweep.Location = new System.Drawing.Point(11, 106);
            this.buttonDEDThSweep.Name = "buttonDEDThSweep";
            this.buttonDEDThSweep.Size = new System.Drawing.Size(97, 34);
            this.buttonDEDThSweep.TabIndex = 1;
            this.buttonDEDThSweep.Text = "Thres. Sweep";
            this.buttonDEDThSweep.UseVisualStyleBackColor = true;
            this.buttonDEDThSweep.Click += new System.EventHandler(this.buttonDEDThSweep_Click);
            // 
            // buttonCheckDEDConnection
            // 
            this.buttonCheckDEDConnection.Location = new System.Drawing.Point(128, 19);
            this.buttonCheckDEDConnection.Name = "buttonCheckDEDConnection";
            this.buttonCheckDEDConnection.Size = new System.Drawing.Size(95, 36);
            this.buttonCheckDEDConnection.TabIndex = 2;
            this.buttonCheckDEDConnection.Text = "Check Conns";
            this.buttonCheckDEDConnection.UseVisualStyleBackColor = true;
            this.buttonCheckDEDConnection.Click += new System.EventHandler(this.buttonCheckDEDConnection_Click);
            // 
            // buttonDEDShowThBias
            // 
            this.buttonDEDShowThBias.Location = new System.Drawing.Point(11, 63);
            this.buttonDEDShowThBias.Name = "buttonDEDShowThBias";
            this.buttonDEDShowThBias.Size = new System.Drawing.Size(98, 37);
            this.buttonDEDShowThBias.TabIndex = 0;
            this.buttonDEDShowThBias.Text = "Check Th. and Bias";
            this.buttonDEDShowThBias.UseVisualStyleBackColor = true;
            this.buttonDEDShowThBias.Click += new System.EventHandler(this.buttonDEDShowThBias_Click);
            // 
            // buttonPIXETVersion
            // 
            this.buttonPIXETVersion.Location = new System.Drawing.Point(11, 19);
            this.buttonPIXETVersion.Name = "buttonPIXETVersion";
            this.buttonPIXETVersion.Size = new System.Drawing.Size(97, 35);
            this.buttonPIXETVersion.TabIndex = 0;
            this.buttonPIXETVersion.Text = "PIXET Version";
            this.buttonPIXETVersion.UseVisualStyleBackColor = true;
            this.buttonPIXETVersion.Click += new System.EventHandler(this.buttonPIXETVersion_Click);
            // 
            // buttonStartFakeGUI
            // 
            this.buttonStartFakeGUI.Location = new System.Drawing.Point(236, 63);
            this.buttonStartFakeGUI.Name = "buttonStartFakeGUI";
            this.buttonStartFakeGUI.Size = new System.Drawing.Size(95, 34);
            this.buttonStartFakeGUI.TabIndex = 5;
            this.buttonStartFakeGUI.Text = "Use fake GUI";
            this.buttonStartFakeGUI.UseVisualStyleBackColor = true;
            this.buttonStartFakeGUI.Click += new System.EventHandler(this.buttonStartFakeGUI_Click);
            // 
            // buttonStartDEDGUI
            // 
            this.buttonStartDEDGUI.Location = new System.Drawing.Point(11, 63);
            this.buttonStartDEDGUI.Name = "buttonStartDEDGUI";
            this.buttonStartDEDGUI.Size = new System.Drawing.Size(136, 34);
            this.buttonStartDEDGUI.TabIndex = 5;
            this.buttonStartDEDGUI.Text = "Start GUI";
            this.buttonStartDEDGUI.UseVisualStyleBackColor = true;
            this.buttonStartDEDGUI.Click += new System.EventHandler(this.buttonStartDEDGUI_Click);
            // 
            // textBoxDEDConsole
            // 
            this.textBoxDEDConsole.Location = new System.Drawing.Point(584, 219);
            this.textBoxDEDConsole.Multiline = true;
            this.textBoxDEDConsole.Name = "textBoxDEDConsole";
            this.textBoxDEDConsole.ReadOnly = true;
            this.textBoxDEDConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDEDConsole.Size = new System.Drawing.Size(240, 421);
            this.textBoxDEDConsole.TabIndex = 27;
            // 
            // groupBoxUtils
            // 
            this.groupBoxUtils.Controls.Add(this.buttonStartFakeGUI);
            this.groupBoxUtils.Controls.Add(this.textBoxSpotPosn);
            this.groupBoxUtils.Controls.Add(this.buttonReadSpotPosn);
            this.groupBoxUtils.Controls.Add(this.textBoxGUIStatus);
            this.groupBoxUtils.Controls.Add(this.buttonStartDEDGUI);
            this.groupBoxUtils.Controls.Add(this.numericUpDownClickWait);
            this.groupBoxUtils.Controls.Add(this.textBoxMouseCoords);
            this.groupBoxUtils.Controls.Add(this.buttonReadCoords);
            this.groupBoxUtils.Location = new System.Drawing.Point(843, 36);
            this.groupBoxUtils.Name = "groupBoxUtils";
            this.groupBoxUtils.Size = new System.Drawing.Size(337, 152);
            this.groupBoxUtils.TabIndex = 28;
            this.groupBoxUtils.TabStop = false;
            this.groupBoxUtils.Text = "DED Utilities";
            // 
            // textBoxSpotPosn
            // 
            this.textBoxSpotPosn.Location = new System.Drawing.Point(158, 112);
            this.textBoxSpotPosn.Name = "textBoxSpotPosn";
            this.textBoxSpotPosn.ReadOnly = true;
            this.textBoxSpotPosn.Size = new System.Drawing.Size(116, 20);
            this.textBoxSpotPosn.TabIndex = 8;
            // 
            // buttonReadSpotPosn
            // 
            this.buttonReadSpotPosn.Location = new System.Drawing.Point(11, 106);
            this.buttonReadSpotPosn.Name = "buttonReadSpotPosn";
            this.buttonReadSpotPosn.Size = new System.Drawing.Size(136, 34);
            this.buttonReadSpotPosn.TabIndex = 7;
            this.buttonReadSpotPosn.Text = "Read Beam Position";
            this.buttonReadSpotPosn.UseVisualStyleBackColor = true;
            this.buttonReadSpotPosn.Click += new System.EventHandler(this.buttonReadSpotPosn_Click);
            // 
            // textBoxGUIStatus
            // 
            this.textBoxGUIStatus.Location = new System.Drawing.Point(158, 70);
            this.textBoxGUIStatus.Name = "textBoxGUIStatus";
            this.textBoxGUIStatus.ReadOnly = true;
            this.textBoxGUIStatus.Size = new System.Drawing.Size(65, 20);
            this.textBoxGUIStatus.TabIndex = 6;
            // 
            // numericUpDownClickWait
            // 
            this.numericUpDownClickWait.DecimalPlaces = 1;
            this.numericUpDownClickWait.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownClickWait.Location = new System.Drawing.Point(250, 25);
            this.numericUpDownClickWait.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownClickWait.Name = "numericUpDownClickWait";
            this.numericUpDownClickWait.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownClickWait.TabIndex = 2;
            this.numericUpDownClickWait.Value = new decimal(new int[] {
            55,
            0,
            0,
            65536});
            // 
            // textBoxMouseCoords
            // 
            this.textBoxMouseCoords.Location = new System.Drawing.Point(158, 24);
            this.textBoxMouseCoords.Name = "textBoxMouseCoords";
            this.textBoxMouseCoords.ReadOnly = true;
            this.textBoxMouseCoords.Size = new System.Drawing.Size(86, 20);
            this.textBoxMouseCoords.TabIndex = 1;
            this.textBoxMouseCoords.Text = "Not set";
            // 
            // buttonReadCoords
            // 
            this.buttonReadCoords.Location = new System.Drawing.Point(11, 19);
            this.buttonReadCoords.Name = "buttonReadCoords";
            this.buttonReadCoords.Size = new System.Drawing.Size(136, 31);
            this.buttonReadCoords.TabIndex = 0;
            this.buttonReadCoords.Text = "Read Coordinates";
            this.buttonReadCoords.UseVisualStyleBackColor = true;
            this.buttonReadCoords.Click += new System.EventHandler(this.buttonReadCoords_Click);
            // 
            // buttonWriteDEDConsoleLog
            // 
            this.buttonWriteDEDConsoleLog.Location = new System.Drawing.Point(595, 655);
            this.buttonWriteDEDConsoleLog.Name = "buttonWriteDEDConsoleLog";
            this.buttonWriteDEDConsoleLog.Size = new System.Drawing.Size(97, 37);
            this.buttonWriteDEDConsoleLog.TabIndex = 7;
            this.buttonWriteDEDConsoleLog.Text = "Generate Log FIle";
            this.buttonWriteDEDConsoleLog.UseVisualStyleBackColor = true;
            this.buttonWriteDEDConsoleLog.Click += new System.EventHandler(this.buttonWriteDEDConsoleLog_Click);
            // 
            // buttonDEDSingleSaveBrowse
            // 
            this.buttonDEDSingleSaveBrowse.Location = new System.Drawing.Point(235, 44);
            this.buttonDEDSingleSaveBrowse.Name = "buttonDEDSingleSaveBrowse";
            this.buttonDEDSingleSaveBrowse.Size = new System.Drawing.Size(84, 20);
            this.buttonDEDSingleSaveBrowse.TabIndex = 12;
            this.buttonDEDSingleSaveBrowse.Text = "Browse...";
            this.buttonDEDSingleSaveBrowse.UseVisualStyleBackColor = true;
            this.buttonDEDSingleSaveBrowse.Click += new System.EventHandler(this.buttonDEDSingleSaveBrowse_Click);
            // 
            // textBoxDEDDirectory
            // 
            this.textBoxDEDDirectory.Location = new System.Drawing.Point(10, 44);
            this.textBoxDEDDirectory.Name = "textBoxDEDDirectory";
            this.textBoxDEDDirectory.ShortcutsEnabled = false;
            this.textBoxDEDDirectory.Size = new System.Drawing.Size(212, 20);
            this.textBoxDEDDirectory.TabIndex = 11;
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
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDGridSpaced);
            this.groupBoxDEDGridCapture.Controls.Add(this.labelSpacedGridNotice);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonSpacedGridScan);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonGenSpacedGrid);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxYSpacingNum);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxXSpacingNum);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxYGridSpacing);
            this.groupBoxDEDGridCapture.Controls.Add(this.labelXYGridSpacing);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxXGridSpacing);
            this.groupBoxDEDGridCapture.Controls.Add(this.labelDEDSelectedRanges2);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDGridCoords);
            this.groupBoxDEDGridCapture.Controls.Add(this.labelDEDGridSTatus);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDGridRand);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDGridReg);
            this.groupBoxDEDGridCapture.Controls.Add(this.labelDEDBrowse);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonGenRegGrid);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonDEDSingleSaveBrowse);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDDirectory);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonRandGridScan);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonGenRandGrid);
            this.groupBoxDEDGridCapture.Controls.Add(this.buttonDEDSelectedGridMouse);
            this.groupBoxDEDGridCapture.Controls.Add(this.labelDEDSelectedRanges);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDSelectedYMax);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDSelectedYMin);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDSelectedXMax);
            this.groupBoxDEDGridCapture.Controls.Add(this.textBoxDEDSelectedXMin);
            this.groupBoxDEDGridCapture.Location = new System.Drawing.Point(844, 203);
            this.groupBoxDEDGridCapture.Name = "groupBoxDEDGridCapture";
            this.groupBoxDEDGridCapture.Size = new System.Drawing.Size(336, 437);
            this.groupBoxDEDGridCapture.TabIndex = 31;
            this.groupBoxDEDGridCapture.TabStop = false;
            this.groupBoxDEDGridCapture.Text = "Grab Patterns Over a Grid";
            // 
            // textBoxDEDGridSpaced
            // 
            this.textBoxDEDGridSpaced.Location = new System.Drawing.Point(10, 369);
            this.textBoxDEDGridSpaced.Name = "textBoxDEDGridSpaced";
            this.textBoxDEDGridSpaced.ReadOnly = true;
            this.textBoxDEDGridSpaced.Size = new System.Drawing.Size(308, 20);
            this.textBoxDEDGridSpaced.TabIndex = 27;
            // 
            // labelSpacedGridNotice
            // 
            this.labelSpacedGridNotice.AutoSize = true;
            this.labelSpacedGridNotice.Location = new System.Drawing.Point(8, 353);
            this.labelSpacedGridNotice.Name = "labelSpacedGridNotice";
            this.labelSpacedGridNotice.Size = new System.Drawing.Size(161, 13);
            this.labelSpacedGridNotice.TabIndex = 26;
            this.labelSpacedGridNotice.Text = "Only XMin and YMin will be used";
            // 
            // buttonSpacedGridScan
            // 
            this.buttonSpacedGridScan.Location = new System.Drawing.Point(182, 397);
            this.buttonSpacedGridScan.Name = "buttonSpacedGridScan";
            this.buttonSpacedGridScan.Size = new System.Drawing.Size(135, 29);
            this.buttonSpacedGridScan.TabIndex = 25;
            this.buttonSpacedGridScan.Text = "Grab over Spaced Grid";
            this.buttonSpacedGridScan.UseVisualStyleBackColor = true;
            this.buttonSpacedGridScan.Click += new System.EventHandler(this.buttonSpacedGridScan_Click);
            // 
            // buttonGenSpacedGrid
            // 
            this.buttonGenSpacedGrid.Location = new System.Drawing.Point(9, 397);
            this.buttonGenSpacedGrid.Name = "buttonGenSpacedGrid";
            this.buttonGenSpacedGrid.Size = new System.Drawing.Size(138, 29);
            this.buttonGenSpacedGrid.TabIndex = 24;
            this.buttonGenSpacedGrid.Text = "Generate Spaced Grid";
            this.buttonGenSpacedGrid.UseVisualStyleBackColor = true;
            this.buttonGenSpacedGrid.Click += new System.EventHandler(this.buttonGenSpacedGrid_Click);
            // 
            // textBoxYSpacingNum
            // 
            this.textBoxYSpacingNum.Location = new System.Drawing.Point(195, 328);
            this.textBoxYSpacingNum.Name = "textBoxYSpacingNum";
            this.textBoxYSpacingNum.Size = new System.Drawing.Size(50, 20);
            this.textBoxYSpacingNum.TabIndex = 23;
            this.textBoxYSpacingNum.Text = "Y Grid";
            // 
            // textBoxXSpacingNum
            // 
            this.textBoxXSpacingNum.Location = new System.Drawing.Point(133, 328);
            this.textBoxXSpacingNum.Name = "textBoxXSpacingNum";
            this.textBoxXSpacingNum.Size = new System.Drawing.Size(50, 20);
            this.textBoxXSpacingNum.TabIndex = 22;
            this.textBoxXSpacingNum.Text = "X Grids";
            // 
            // textBoxYGridSpacing
            // 
            this.textBoxYGridSpacing.Location = new System.Drawing.Point(71, 328);
            this.textBoxYGridSpacing.Name = "textBoxYGridSpacing";
            this.textBoxYGridSpacing.Size = new System.Drawing.Size(51, 20);
            this.textBoxYGridSpacing.TabIndex = 21;
            this.textBoxYGridSpacing.Text = "Y Spacing";
            // 
            // labelXYGridSpacing
            // 
            this.labelXYGridSpacing.AutoSize = true;
            this.labelXYGridSpacing.Location = new System.Drawing.Point(7, 312);
            this.labelXYGridSpacing.Name = "labelXYGridSpacing";
            this.labelXYGridSpacing.Size = new System.Drawing.Size(270, 13);
            this.labelXYGridSpacing.TabIndex = 20;
            this.labelXYGridSpacing.Text = "Set the following for larger spacing (X, Y) and grid points";
            // 
            // textBoxXGridSpacing
            // 
            this.textBoxXGridSpacing.Location = new System.Drawing.Point(9, 328);
            this.textBoxXGridSpacing.Name = "textBoxXGridSpacing";
            this.textBoxXGridSpacing.Size = new System.Drawing.Size(50, 20);
            this.textBoxXGridSpacing.TabIndex = 19;
            this.textBoxXGridSpacing.Text = "X Spacing";
            // 
            // labelDEDSelectedRanges2
            // 
            this.labelDEDSelectedRanges2.AutoSize = true;
            this.labelDEDSelectedRanges2.Location = new System.Drawing.Point(7, 182);
            this.labelDEDSelectedRanges2.Name = "labelDEDSelectedRanges2";
            this.labelDEDSelectedRanges2.Size = new System.Drawing.Size(204, 13);
            this.labelDEDSelectedRanges2.TabIndex = 18;
            this.labelDEDSelectedRanges2.Text = "To generate X or Y line can, set max=min.";
            // 
            // textBoxDEDGridCoords
            // 
            this.textBoxDEDGridCoords.Location = new System.Drawing.Point(10, 116);
            this.textBoxDEDGridCoords.Name = "textBoxDEDGridCoords";
            this.textBoxDEDGridCoords.ReadOnly = true;
            this.textBoxDEDGridCoords.Size = new System.Drawing.Size(309, 20);
            this.textBoxDEDGridCoords.TabIndex = 17;
            // 
            // labelDEDGridSTatus
            // 
            this.labelDEDGridSTatus.AutoSize = true;
            this.labelDEDGridSTatus.Location = new System.Drawing.Point(10, 72);
            this.labelDEDGridSTatus.Name = "labelDEDGridSTatus";
            this.labelDEDGridSTatus.Size = new System.Drawing.Size(100, 13);
            this.labelDEDGridSTatus.TabIndex = 16;
            this.labelDEDGridSTatus.Text = "Status of scan grids";
            // 
            // textBoxDEDGridRand
            // 
            this.textBoxDEDGridRand.Location = new System.Drawing.Point(172, 88);
            this.textBoxDEDGridRand.Name = "textBoxDEDGridRand";
            this.textBoxDEDGridRand.ReadOnly = true;
            this.textBoxDEDGridRand.Size = new System.Drawing.Size(147, 20);
            this.textBoxDEDGridRand.TabIndex = 15;
            // 
            // textBoxDEDGridReg
            // 
            this.textBoxDEDGridReg.Location = new System.Drawing.Point(10, 88);
            this.textBoxDEDGridReg.Name = "textBoxDEDGridReg";
            this.textBoxDEDGridReg.ReadOnly = true;
            this.textBoxDEDGridReg.Size = new System.Drawing.Size(147, 20);
            this.textBoxDEDGridReg.TabIndex = 14;
            // 
            // labelDEDBrowse
            // 
            this.labelDEDBrowse.AutoSize = true;
            this.labelDEDBrowse.Location = new System.Drawing.Point(7, 28);
            this.labelDEDBrowse.Name = "labelDEDBrowse";
            this.labelDEDBrowse.Size = new System.Drawing.Size(326, 13);
            this.labelDEDBrowse.TabIndex = 13;
            this.labelDEDBrowse.Text = "Choose DED capture directory (scan parameters will be saved here)";
            // 
            // buttonGenRegGrid
            // 
            this.buttonGenRegGrid.Location = new System.Drawing.Point(9, 201);
            this.buttonGenRegGrid.Name = "buttonGenRegGrid";
            this.buttonGenRegGrid.Size = new System.Drawing.Size(138, 29);
            this.buttonGenRegGrid.TabIndex = 12;
            this.buttonGenRegGrid.Text = "Generate Regular Grid";
            this.buttonGenRegGrid.UseVisualStyleBackColor = true;
            this.buttonGenRegGrid.Click += new System.EventHandler(this.buttonGenRegGrid_Click);
            // 
            // buttonRandGridScan
            // 
            this.buttonRandGridScan.Location = new System.Drawing.Point(182, 236);
            this.buttonRandGridScan.Name = "buttonRandGridScan";
            this.buttonRandGridScan.Size = new System.Drawing.Size(136, 30);
            this.buttonRandGridScan.TabIndex = 10;
            this.buttonRandGridScan.Text = "Grab over Random Grid";
            this.buttonRandGridScan.UseVisualStyleBackColor = true;
            this.buttonRandGridScan.Click += new System.EventHandler(this.buttonRandGridScan_Click);
            // 
            // buttonGenRandGrid
            // 
            this.buttonGenRandGrid.Location = new System.Drawing.Point(182, 201);
            this.buttonGenRandGrid.Name = "buttonGenRandGrid";
            this.buttonGenRandGrid.Size = new System.Drawing.Size(136, 29);
            this.buttonGenRandGrid.TabIndex = 9;
            this.buttonGenRandGrid.Text = "Generate Random Grid";
            this.buttonGenRandGrid.UseVisualStyleBackColor = true;
            this.buttonGenRandGrid.Click += new System.EventHandler(this.buttonGenRandGrid_Click);
            // 
            // buttonDEDSelectedGridMouse
            // 
            this.buttonDEDSelectedGridMouse.Location = new System.Drawing.Point(9, 236);
            this.buttonDEDSelectedGridMouse.Name = "buttonDEDSelectedGridMouse";
            this.buttonDEDSelectedGridMouse.Size = new System.Drawing.Size(138, 30);
            this.buttonDEDSelectedGridMouse.TabIndex = 8;
            this.buttonDEDSelectedGridMouse.Text = "Grab Over Square Grid";
            this.buttonDEDSelectedGridMouse.UseVisualStyleBackColor = true;
            this.buttonDEDSelectedGridMouse.Click += new System.EventHandler(this.buttonDEDSelectedGridMouse_Click);
            // 
            // labelDEDSelectedRanges
            // 
            this.labelDEDSelectedRanges.Location = new System.Drawing.Point(7, 142);
            this.labelDEDSelectedRanges.Name = "labelDEDSelectedRanges";
            this.labelDEDSelectedRanges.Size = new System.Drawing.Size(223, 14);
            this.labelDEDSelectedRanges.TabIndex = 6;
            this.labelDEDSelectedRanges.Text = "Box coordintes (XMin, XMax, YMin, YMax)";
            // 
            // textBoxDEDSelectedYMax
            // 
            this.textBoxDEDSelectedYMax.Location = new System.Drawing.Point(195, 159);
            this.textBoxDEDSelectedYMax.Name = "textBoxDEDSelectedYMax";
            this.textBoxDEDSelectedYMax.Size = new System.Drawing.Size(51, 20);
            this.textBoxDEDSelectedYMax.TabIndex = 5;
            this.textBoxDEDSelectedYMax.Text = "105";
            // 
            // textBoxDEDSelectedYMin
            // 
            this.textBoxDEDSelectedYMin.Location = new System.Drawing.Point(133, 159);
            this.textBoxDEDSelectedYMin.Name = "textBoxDEDSelectedYMin";
            this.textBoxDEDSelectedYMin.Size = new System.Drawing.Size(51, 20);
            this.textBoxDEDSelectedYMin.TabIndex = 4;
            this.textBoxDEDSelectedYMin.Text = "100";
            // 
            // textBoxDEDSelectedXMax
            // 
            this.textBoxDEDSelectedXMax.Location = new System.Drawing.Point(71, 159);
            this.textBoxDEDSelectedXMax.Name = "textBoxDEDSelectedXMax";
            this.textBoxDEDSelectedXMax.Size = new System.Drawing.Size(51, 20);
            this.textBoxDEDSelectedXMax.TabIndex = 3;
            this.textBoxDEDSelectedXMax.Text = "105";
            // 
            // textBoxDEDSelectedXMin
            // 
            this.textBoxDEDSelectedXMin.Location = new System.Drawing.Point(9, 159);
            this.textBoxDEDSelectedXMin.Name = "textBoxDEDSelectedXMin";
            this.textBoxDEDSelectedXMin.Size = new System.Drawing.Size(51, 20);
            this.textBoxDEDSelectedXMin.TabIndex = 2;
            this.textBoxDEDSelectedXMin.Text = "100";
            // 
            // buttonGridReset
            // 
            this.buttonGridReset.Location = new System.Drawing.Point(854, 655);
            this.buttonGridReset.Name = "buttonGridReset";
            this.buttonGridReset.Size = new System.Drawing.Size(138, 36);
            this.buttonGridReset.TabIndex = 11;
            this.buttonGridReset.Text = "Clear Grid Settings";
            this.buttonGridReset.UseVisualStyleBackColor = true;
            this.buttonGridReset.Click += new System.EventHandler(this.buttonGridReset_Click);
            // 
            // buttonDEDGridRecParams
            // 
            this.buttonDEDGridRecParams.Location = new System.Drawing.Point(1027, 655);
            this.buttonDEDGridRecParams.Name = "buttonDEDGridRecParams";
            this.buttonDEDGridRecParams.Size = new System.Drawing.Size(134, 36);
            this.buttonDEDGridRecParams.TabIndex = 7;
            this.buttonDEDGridRecParams.Text = "Record Scan Parameters";
            this.buttonDEDGridRecParams.UseVisualStyleBackColor = true;
            this.buttonDEDGridRecParams.Click += new System.EventHandler(this.buttonDEDGridRecParams_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(216, 445);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(85, 19);
            this.buttonAbort.TabIndex = 32;
            this.buttonAbort.Text = "Abort Scan";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonWriteSEMLog
            // 
            this.buttonWriteSEMLog.Location = new System.Drawing.Point(712, 656);
            this.buttonWriteSEMLog.Name = "buttonWriteSEMLog";
            this.buttonWriteSEMLog.Size = new System.Drawing.Size(96, 36);
            this.buttonWriteSEMLog.TabIndex = 34;
            this.buttonWriteSEMLog.Text = "Write SEM Log";
            this.buttonWriteSEMLog.UseVisualStyleBackColor = true;
            this.buttonWriteSEMLog.Click += new System.EventHandler(this.buttonWriteSEMLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 708);
            this.Controls.Add(this.buttonWriteSEMLog);
            this.Controls.Add(this.buttonWriteDEDConsoleLog);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.groupBoxDEDGridCapture);
            this.Controls.Add(this.labelDEDConsole);
            this.Controls.Add(this.labelScanProgressBar);
            this.Controls.Add(this.groupBoxUtils);
            this.Controls.Add(this.progressBarScan);
            this.Controls.Add(this.textBoxDEDConsole);
            this.Controls.Add(this.groupBoxDEDInit);
            this.Controls.Add(this.textBoxSetNotify);
            this.Controls.Add(this.groupBoxRefreshNotify);
            this.Controls.Add(this.buttonSpotModeSwitch);
            this.Controls.Add(this.groupBoxFrameGrab);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonGridReset);
            this.Controls.Add(this.groupBoxInitialize);
            this.Controls.Add(this.groupBoxDebugUpperRight);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.buttonCloseControl);
            this.Controls.Add(this.labelCloseControls);
            this.Controls.Add(this.labelXBeamScan);
            this.Controls.Add(this.buttonDEDGridRecParams);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeriesGrab)).EndInit();
            this.groupBoxRefreshNotify.ResumeLayout(false);
            this.groupBoxDEDInit.ResumeLayout(false);
            this.groupBoxUtils.ResumeLayout(false);
            this.groupBoxUtils.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClickWait)).EndInit();
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
        private System.Windows.Forms.Button buttonDEDSingleSaveBrowse;
        private System.Windows.Forms.TextBox textBoxDEDDirectory;
        private System.Windows.Forms.Label labelDEDConsole;
        private System.Windows.Forms.Button buttonCheckDEDConnection;
        private System.Windows.Forms.Button buttonDEDShowThBias;
        private System.Windows.Forms.TextBox textBoxStageZ;
        private System.Windows.Forms.TextBox textBoxStageY;
        private System.Windows.Forms.TextBox textBoxStageX;
        private System.Windows.Forms.GroupBox groupBoxDEDGridCapture;
        private System.Windows.Forms.Label labelDEDSelectedRanges;
        private System.Windows.Forms.TextBox textBoxDEDSelectedYMax;
        private System.Windows.Forms.TextBox textBoxDEDSelectedYMin;
        private System.Windows.Forms.TextBox textBoxDEDSelectedXMax;
        private System.Windows.Forms.TextBox textBoxDEDSelectedXMin;
        private System.Windows.Forms.Button buttonDEDGridRecParams;
        private System.Windows.Forms.Label labelFrameGrabFileNamePart2;
        private System.Windows.Forms.Label labelFrameGrabFileName;
        private System.Windows.Forms.TextBox textBoxFrameGrabFileName;
        private System.Windows.Forms.Button buttonDEDTemperatureRead;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.NumericUpDown numericUpDownClickWait;
        private System.Windows.Forms.TextBox textBoxMouseCoords;
        private System.Windows.Forms.Button buttonReadCoords;
        private System.Windows.Forms.Button buttonDEDSelectedGridMouse;
        private System.Windows.Forms.Button buttonStartDEDGUI;
        private System.Windows.Forms.Button buttonStartFakeGUI;
        private System.Windows.Forms.TextBox textBoxGUIStatus;
        private System.Windows.Forms.Button buttonWriteDEDConsoleLog;
        private System.Windows.Forms.TextBox textBoxSpotPosn;
        private System.Windows.Forms.Button buttonReadSpotPosn;
        private System.Windows.Forms.Button buttonWriteSEMLog;
        private System.Windows.Forms.Button buttonRandGridScan;
        private System.Windows.Forms.Button buttonGenRandGrid;
        private System.Windows.Forms.Label labelSeriesGrabFileName;
        private System.Windows.Forms.Label labelSeriesGrabName;
        private System.Windows.Forms.TextBox textBoxSeriesGrabName;
        private System.Windows.Forms.Button buttonSeriesGrab;
        private System.Windows.Forms.Label labelSeriesGrabDefault;
        private System.Windows.Forms.Button buttonSeriesGrabIndexReset;
        private System.Windows.Forms.Label labelCurrentSeriesGrabIndex;
        private System.Windows.Forms.NumericUpDown numericUpDownSeriesGrab;
        private System.Windows.Forms.Label labelSeriesGrabHint;
        private System.Windows.Forms.Label labelGrabDirectoryHint;
        private System.Windows.Forms.Button buttonGridReset;
        private System.Windows.Forms.Button buttonGenRegGrid;
        private System.Windows.Forms.Label labelDEDBrowse;
        private System.Windows.Forms.TextBox textBoxDEDGridCoords;
        private System.Windows.Forms.Label labelDEDGridSTatus;
        private System.Windows.Forms.TextBox textBoxDEDGridRand;
        private System.Windows.Forms.TextBox textBoxDEDGridReg;
        private System.Windows.Forms.Label labelDEDSelectedRanges2;
        private System.Windows.Forms.TextBox textBoxYGridSpacing;
        private System.Windows.Forms.Label labelXYGridSpacing;
        private System.Windows.Forms.TextBox textBoxXGridSpacing;
        private System.Windows.Forms.Button buttonSpacedGridScan;
        private System.Windows.Forms.Button buttonGenSpacedGrid;
        private System.Windows.Forms.TextBox textBoxYSpacingNum;
        private System.Windows.Forms.TextBox textBoxXSpacingNum;
        private System.Windows.Forms.TextBox textBoxDEDGridSpaced;
        private System.Windows.Forms.Label labelSpacedGridNotice;
    }
}

