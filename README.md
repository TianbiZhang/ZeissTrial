---
date: 2022-10-13
author: Tianbi
---

# ZeissTrial Document

Last update: November 20, 2023

First draft: October 13, 2022

## Introduction

The ZeissTrial software series are a series of software monitoring and controlling a Zeiss scanning electron microscope (SEM). It was originally developed by Tianbi Zhang for his PhD work on a custom transmission Kikuchi diffraction setup, where the software facilitates automated beam scan and pattern capture.

This project was directly adapted from the demo project shipped along with the SmartSEM programming interface.

### Glossary

- ZeissTrial: this software.

- Client and server: when you establish a remote connection to the SEM PC, the client is the PC where you run ZeissTrial, and the server is the SEM PC where SmartSEM is installed and being controled by ZeissTrial.

### System requirements

- This project only runs on Windows operating system. Version should be at least Windows 7. It have not been tested on Windows 11 yet!
- The Zeiss SmartSEM programming interface (the API). This is proprietary and is not included in this repository.
- .NET Framework version 4.0 or higher for C#. All the inclusions and packages used in the C# projects should be readily available.
- Python 3.7.
- Microsoft Visual Studio (VS). A free version ("VS Community") is available for download online. Note that the C# project is for VS version 2016 as the SmartSEM API is quite old.

 You will need to setup the remote connection if you want to control the SEM from another PC where you run ZeissTrial. This is relatively easy if there is a local wired network (LAN) in your SEM lab as you can connect your control PC (server) to the same network switch and manually set up its IPv4 address. The IP addresses of both the server and the clientThis is needed for  RConfigure. Once this is set, you should be ready to establish the remote connection.

## ZeissTrial Async

The ZeissTrial Async flavour of the software is the original version developed by Zhang. In this section, we will go through the graphical interface of the program and introduce the functions of every button.

### The Graphical Interface

An overview of the GUI is shown below. (add screenshot)

### Initialization and Closing Control

Once the remote connection is set (unnecessary if you run SmartSEM as an emulator), the API interface should be initialized first. Click "Initialize API" if running locally (emulator), or "Initialize Remote" if running remotely. No SEM-related commands can be excecuted if the API is not initialized, and a error message box will pop up. Note that if you initialize the local API, the "Initialize Remote" button will gray out. A message box will pop up and indicate whether the API has been correctly initialized, and the first parameter in the parameter/status zone will show "Initialized" instead of "Not Initialized" with a red background.

If you would like to close the program, or temporarily stop excution of SEM-related commands, you should click "Close Control" first. This closes the API. You can then resume your operations by initializing again, or quit the program by clicking "Quit".

### General functions

### Quick Testing Tools

A few quick testing tools are programmed for the interface with different purposes. Please note that all testing tools require the initialization of the API.

ZeissTrial is build on some key API functions in the programming interface: Get, Set, GetLimits, Excecute and Grab.

- "Get API Version". This will simply test if the API is responding. A message box will pop up with the version code.

- "Get Spot Position (Posn) Limits". This tests if GetLimits wirks properly and will return with the frame size in a pop-up message box.

- "Perform X Beam Scan". This tests the Get and Set functions. It will first change to spot mode if it is not on, then read the current position of the spot using "Get" and move the spot horizontally across the entire frame using "Set". A message box will appear when the scan is complete. This process can be cancelled by clicking the "Abort" button.

- "Mag Map". This function will set the magnification to the minimum (using "GetLimits") in increments of 20x until 100kx, read the pixel size (in m) simultaneously and generate a text file "magmapvalues.txt" in the selected directory. This function is useful to establish the relationship between magnification and pixel size (step size) as we cannot set directly the pixel size (it is set through setting the magnification). This process can be cancelled by clicking the "Abort" button and the text file will still be generated.

- "Perform XY Beam Scan". This is similar to "Perform X Beam Scan" and can be seem as multiple X beam scan in series. The beam will scan across the entire frame in a raster fashion: left to right, then top to bottom. A message box will appear when the scan is complete. This process can be cancelled by clicking the "Abort" button.

### Parameter Monitoring

ZeissTrial monitors a wide range of SEM parameters by reading them from the API. These parameters will be shown (if clicked the first time after launching the program) and refreshed in the parameter/status zone when you click "Refresh Parameters". The button "Auto refresh (Notify)" will enable automatic parameter update when there is a change to the monitored parameter, and report errors in the notification box in natural language.

Parameters and statuses displayed in this zone can be customized by modifying the source code. Below is the list of the parameters/statuses monitored in the default version.

| | | | |
|---|---|---|---|
|API Initialization State| Actual Current | Magnification | Detector |
|Vacuum State| Extractor Current| Pixel Size | Detector Channel |
|Beam State| Spot Mode State | Working Distance | Brightness |
|EHT Voltage| Scan Rate | Aperture Size | Contrast |
|High Current Mode State| Stage X Position | Stage Y Position | Stage Z Position |

### Parameter Setting

There are two parameter setting function outside the testing tools.

- "Set Mag" textbox and button. The program will read the magnification input by the user and set to the corresponding magnifications. Error message will show if the input is invalid or exceeds the maximum value allowed.

- "Spot Mode On/Off" will toggle the state of spot mode based on its current stage. If spot mode is on, then clicking this button will switch it off, and vice versa. This is useful when beam scan is needed. Note that for testing functions "X Beam Scan" and "XY beam Scan", spot mode will be turned on automatically.

### Quick Grab

ZeissTrial includes a quick grab button to grab the current frame and save it as a .tif image. The image will be stored in the selected directory and given a name from user input (defalt is "Frame"). The default scan parameter are frame size 1024x768, scan speed 9 and line integral with N=4. Please make sure the stored resolution is consistent with the code.

The program will first unfreeze the frame if necessary, set the scan parameters and initialize the scan, read the frame time and wait for the corresponding time and store the frame to the image.

A solution to grab a series of images in sequence is provided in the ZeissTrial SmarAct package, where the series name is from user input and the image ID starts from 1 and will increment by 1 with further capturing. This can be worked into a skeleton for sequential capturing involving a custome sample stage.

Please note that in order to change the "N" value for noise reduction, the user should always change the noise reduction coefficient "AP_NR_COEFF", whose value is also dependent on the noise reduction mode (frame average, line integral, etc.) and must be reset when switching to another noise reduction mode.

### Known issues

- Please make sure that the versions of the SmartSEM remoting interface are synchronized for the client and the server. Otherwise a mnemonic error will be reported and will affect functions using the function "Set" and "Excecute".

- Quick Grab: because of the way the API works, it is not possible to grab directly 16-bit tiff images.

## Buttons overview

This section will go through the structure of each function, especially button click functions, involved in ZeissTrial.

### Initialization Zone and Exit Zone

- Initialize: this will simply call the CZEMApi.Initialise("") to initialize the API locally.
- InitializeRemote: this will call CZEMApi.InitialiseRemoting() to initialize the remote API. Note that the remote connection should be established already at this step, including running EM Server and logging onto SmartSEM. The default version of ZeissTrial does not provide functionalities to remotely log onto SmartSEM.
- For both initialization methods, a global boolean variable apiInitialized will be toggled to true from its default value of false. This variable is used throughout ZeissTrial to determine whether an SEM-related command can be run.
- CloseControl: this calls CZEMApi.ClosingControl(), closes the API and set the global boolean apiInitialised value to false. No further actions can be done by ZeissTrial until the API is initialized again.
- Quit: this closes the ZeissTrial window when control is closed or when the API is not initialized yet. This uses a C# Windows form function Close().

### Parameter Monitoring Zone

- RefreshParams: this will call UpdateStatus() for each parameter/status monitored in the parameter/status zone.
- SetNotify (Auto Refresh): this will enable automated parameter update through SetNotify(), when there is a change in the parameter monitored. Note that this also works under remoting.

### Parameter Setting Zone

- SetMag: this reads the value of input by the user in the textbox on the left, and set the magnification to the corresponding value using Set(). Note that this is the only way to adjust the pixel size. This can also be seen as a template for setting any parameter (if not read-only) to a user input value.
- SpotModeSwitch: this reads the current state of spot mode using Get(), and toggles it off/on depending on the current state using first an if statement and then Set(). This function will update the status of spot mode regardless of whether SetNotify() is enabled.

### Quick Testing Zone

- GetCZEMApiVersion: this returns the version of the SmartSEM API using GetVersion(). Note that Zeiss has indicated in the manual that GetVersion is deprecated. An alternative could be reading "SV_VERSION" using Get(). In addition, although the excecution of this function does not require initialization of the API, in ZeissTrial the initialization is still forced.
- GetBeamPosnLimits: this returns the X (AP_SPOT_POSN_X) and Y (AP_SPOT_POSN_Y) limits using GetLimit().
- XBeamScan (async): this will excecute a beam scan by moving the spot horizontally. First, the program will read if spot mode is switched on and turn it on if not. Then it will read the current position of the spot using Get() and reset its X position to 0 using Set(). The scan is done by continuously changing the X position by Set() in a do-while loop until the upper limit of the X position is reached (note: to enable the async feature and the abort button, the do-while loop is used instead of a for loop. This applies to all async functions in ZeissTrial).
- MagMap (async): this will first read the minimum magnification available, set the current magnification to the minimum value, then use a do-while loop to gradually increase the magnification (in 20x increments), read the corresponding pixel size (AP_PIXEL_SIZE) in m, pause briefly for 0.02s and continue until magnification reaches 200000. The magnification-pixel size pair are stored in a list. After the loop is finished (or aborted), the list is written to a text file.
- XYBeamScan (async): this will perform a raster scan of the beam. First, limits of X and Y beam positions are read by GetLimits(). Then the spot is set to the top left (0, 0) and move towards right. When it reaches the end, the spot will be moved to the next Y position and its X position reset. This function can be potentially made into a function incorporating 3rd party detectors to synchronize beam movement and signal capture.
- XScanGrabPixelValue: this function is deprecated because the nature of the "AP_SPOT" parameter is unclear.

### Frame Grab Zone

- BrowseFrameGrab and textBoxFrameGrab: this button will call the directory selection dialogue. The user can select a directory to store the SEM images captured by ZeissTrial. The selected directory is shown on the left. The default path is Desktop. Note that this directory will also be used for MagMap.

- GrabImage2File and textBoxFrameGrabFileName: this button will perform a series of actions to grab the current frame into a tif image. The name of the image is given by the user ("Frame" by default) in the textbox above. First, the current frame is unfrozen by setting "DP_FROZEN" to "Live" using Set(). This will ensure that the frame is refreshed. Then the scan speed is changed to 9 and the noise reduction mode to line integral using Excecute. The noise reduction coefficient (N) is then set to 4 using Set(). Next, the freeze state of the frame ("DP_FREEZE_ON") is set to "End Frame". If these 4 commands are successfully performed, the program will read the frame time in miliseconds and pause for (frame time + 3 seconds) for the scan to finish and the frame frozen. A message will show up in the notify window indicating the wait time. Then the frame will be captured. Note that GrabImage2File first calls a custom function SEMFrameCapture(). SEMFrameCapture() utilizes the CZEMApi.Grab() function. This function is written in this way as calling of CZEMApi.Grab() can be long. When the image is stored, a message will show up in the notify window.

> Note the difference between "DP_FROZEN" and "DP_FREEZE_ON":
>
> - "DP_FROZEN" is the state of the frame. Allowed values are "Live" (0) and "Frozen" (1).
> - "DP_FREEZE_ON" determines when the frame will be frozen. Allowed values are "End Frame" (0), "End Line" (1) and "Command" (2).

### The Abort Button

The "abort scan" button is used to cancel the excecution of any ongoing asynchronized functions through a cancellation token `_canceller`. Every asynchronized function must be programmed to incorporate the cancellation token to make use of the abort button. When the button is clicked, a message "process aborted" will appear on the notify window. Please refer to Programming Guide for how to write custom asynchronized functions for ZeissTrial.

### Helper functions

This section lists functions using only standard C# functions. For the standard ZeissTrial Async flavour, the helper functions mainly serve the asynchronized programming feature (abort button, textbox update, etc.)

- `SetTextSetNotify(string text)`. This function is the asynchronized version of ``textBox.Appendtext(string text)``. However, an asynchronized function is excecuted on a different thread, and it cannot call functions pointing to the textbox created on a different thread directly, and the textbox must be invoked. This function simply invoke the textbox first, then perform the ``textBox.Appendtext(string text)`` action.

## Programming guide

ZeissTrial is written in C# as it provides an easy way to make graphical user interfaces through the Windows Form Application package and is relatively easy to learn. The author acknowledges that some hardware do not have a C# API, and interop with this program can become difficult. The SmartSEM API does come with a C++ API as well, which may better suit your need.

As is in many hardware programming practices, the SmartSEM API relies on functions and returned (error) codes to control the SmartSEM software and then the SEM itself. If it returns 0, the call is successfully excecuted. If not, one should then call the ReportError() function to generate an error message in natural language, which will show up in the notification box, and decide whether the function should be terminated.

Parts of the ZeissTrial main code were adapted from the demonstration C# program provided by Zeiss. It is suggested to keep them as they are and make use of them. These include:

```C#
public enum ZeissErrorCode
public enum ZeissNotificationCode
string ErrorToString()

internal void ReportError()
internal void DisplayError()
public void Notify()

public void CZEMApi_Notify()
public void CZEMApi_NotifyWithCurrentValue()
public void UpdateStatus()
```

Therefore, each call of an SEM-related function should follow loosely this structure:

```C#
private void button1_Click(object sender, EventArgs e)
{
    long lreply = CZEMApi.Function(""); // Excecute a function

    if ((zeisserrorcode)lreply != ZeissErrorCode.API_E_NO_ERROR) //or if (lreply != 0)
    {
        ReportError(lreply, str Caller, str Comments); 
        // in this case, Caller = "Function" and Comments can be "button1_Click".
        // Next, decide if the function should terminate (return;)
    }
    // code to excecute when lreply == 0
}
```

More specifically, each API function has a distinct usage. Below is a brief description of the commonly used ones. For details, please consult the official SmartSEM API Programming guide.

### CZEMApi.Get and GetLimits

"Get" is used to get values or states, and "GetLimits" for upper and lower limits of numerical parameters. To assign the values got from the functions, one must declare the variables first using the appropriate VariantWrapper, which will be passed to the API and the hardware. Incorrect VariantWrapper may result in errors.

```C#
object vMinValueX = new VariantWrapper((float)0.0f);
object vMaxValueX = new VariantWrapper((float)0.0f);
object vValueY = new VariantWrapper((float)0.0f); // generally good for float or integers, such as pixel position
object varStr = new VariantWrapper(""); // This gives "=" as well as the units. Good for the parameter/status zone or natural langauge output, e.g. displaying in a message box.

long lReplyX = CZEMApi.GetLimits("AP_SPOT_POSN_X", ref vMinValueX, ref vMaxValueX);
long lReplyY = CZEMApi.Get("AP_SPOT_POSN_Y", ref vValueY);
```

### CZEMApi.Set

"Set" is used to set values or states. Again, the value you want to pass to the function needs to be converted into strings, then wrapped in the VariantWrapper class, no matter what data type the parameter is originally (0, 0.1, etc.). Note that some digital parameters have equivalent names for the states in addition to the integer codes. For example, "DP_SPOT" 0 is equivalent to "Off" and 1 to "On".

```C#
int XPos = 0;
object XPos_loop = new VariantWrapper(XPos.ToString());
long lReply_XPos = CZEMApi.Set("AP_SPOT_POSN_X", ref XPos_loop);

object SpotStateTarget = new VariantWrapper("Off"); 
long lReturnSwitch = CZEMApi.Set("DP_SPOT", SpotStateTarget);
```

### CZEMApi.Excecute

"Excecute" is used to excecute certain commands that do not need additional inputs, for example, starting line integral. These commands start with "CMD_". Scan speed is also set through Excecute(). A list of commands can be found in the API manual.

```C#
long lreplyscanrate = CZEMApi.Execute("CMD_SCANRATE9");
```

Note however that if you want to select the scan rate based on user input (e.g. from a drop-down menu), it may require extra work.

### CZEMApi.Grab

"Grab()" is used to grab the current frame into images. Note that it will grab whatever is shown on the screen regardless of the state of the scan. Therefore, if you want to use it as an alternative to SEM image capturing, it should be used alongside functions that toggles noise reduction and freezing of the frame. In addition, it is not possible to change the type of the image (8-bit, 16-bit, etc.) and images are always captured at 8-bit.

```C#

long lReply = CZEMApi.Grab(0, 0, 1024, 768, 0, filepath);
// first two zeros are X and Y offsets respectively - usually can be set to 0 and there is no need to change.
// third and fourth parameters are dimensions of the image to be captured. they should match the display resolution!
// Fifth parameter is subsampling. This should be 0 or -1 by default for no subsampling.
```

### Dealing with Graphical User Interface

Developing a graphical interface in C# with VS is quite simple, which is the main reason why ZeissTrial is written in C#. Addition, deletion and edit of the elements such as buttons and textboxes are easily accessible through toolbox-common control panel and properties panel when you are in the design view.

To edit the function for when a button is clicked, you can simply double click the button in the design view.

Another commonly used feature is to fetch user input value in textboxes. This is easily done by ``string strtextBox = textBoxName.Text``. Note that textboxes only contain strings, and you may need to use convert functions when needed to convert to int, double, etc. This is often necessary for NumericUpDown components where the user input can only be numbers, as ``NumericUpDown.Value`` also returns a string.

### How to write Async functions

In the standard, synchronized C# Windows form, all the GUI elements and excecution of the functions (button click, etc.) are performed on the same thread. This brings a variety of problems:

1. The GUI will not be responsive during the excecution (but it is not frozen either). Textboxes might not be promptly updated.
2. You may find it useful in many occasions to be able to interrupt or cancel a running process when there is an error, be it a beam scan, MagMap, etc. with an abort button. However, cancelling the thread will also close the ZeissTrial main window, and for the GUI to be active again, you will have to wait until the full scan is over.

In short, the function of the abort button is to simply break from the iteration upon excecuting another function. The most effective way to introduce such features is to utilize asynchronized programming. Below is an example of an asynchronized function using the cancellation token (i.e. the abort button) in a single loop.

```C#
private CancellationTokenSource _canceller;
private async void buttonAsync_click()
{
    _canceller = new CancellationTokenSource();
    await TaskEx.Run(() =>
    {
        do
        {
            /// Code to excecute
            if (_canceller.Token.IsCancellationRequested)
                break;
            /// Code to excecute
        } while (criteria);
        _canceller.Dispose();
    });
}
```

However, breaking from a nested loop (e.g. X-Y beam scan) is trickier since "break" will only exit the inner loop. To tackle this, you can set an extra boolean value to determine whether you should exit the loop.

```C#
private CancellationTokenSource _canceller;
private async void buttonAsync_click()
{
    _canceller = new CancellationTokenSource();
    bool exitLoop = false;
    await TaskEx.Run(() =>
    {
        do
        {
            do
            {
                /// Code to excecute
                if (_canceller.Token.IsCancellationRequested)
                {
                    exitLoop = true;
                    break;
                }
            } while (criteria_2)
            
            /// Code to excecute
            
            if (exitLoop)
                break;
            /// Code to excecute
        } while (criteria_1);
        _canceller.Dispose();
    });
}
```

Note that if ``async`` is declared in the function name, you must include the ``await`` block in the body of the function.

## Update Log

- October 13, 2022: initial commit.
