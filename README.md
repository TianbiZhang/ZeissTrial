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
- .NET Framework version 4.0 or higher for C#.
- The user should check that all the inclusions and packages used in the C# projects are imported in Visual Studio (or equivalent). The Zeiss SmartSEM API (proprietary) is not included in this repository.
- Microsoft Visual Studio (VS). A free version ("VS Community") is available for download online. Note that the C# project is for VS version 2016 as the SmartSEM API is quite old.

 You will need to setup the remote connection if you want to control the SEM from another PC where you run ZeissTrial. This is relatively easy if there is a local wired network (LAN) in your SEM lab as you can connect your control PC (server) to the same network switch and manually set up its IPv4 address. The IP addresses of both the server and the clientThis is needed for  RConfigure. Once this is set, you should be ready to establish the remote connection.

## ZeissTrial Async

The ZeissTrial Async flavour of the software is the original version developed by Zhang. In this section, we will go through the graphical interface of the program and introduce the functions of every button.

### The Graphical Interface

An overview of the GUI is shown below.

### Initialization and Closing Control

Once the remote connection is set (unnecessary if you run SmartSEM locally as an emulator), the API interface should be initialized first. Click "Initialize API" if running locally (emulator), or "Initialize Remote" if running remotely. No SEM-related commands can be excecuted if the API is not initialized, and a error message box will pop up. Note that if you initialize the local API, the "Initialize Remote" button will gray out. A message box will pop up and indicate whether the API has been correctly initialized, and the first parameter in the parameter/status zone will show "Initialized" instead of "Not Initialized" with a red background.

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

### Grab over a grid

This section was designed in conjunction with my DED capture scripts. The basic idea is simple: moving the beam over a regularly spaced grids, with a pause.  There are two types of scan: a regular scan (zigzag) or a pseudo-random ordered scan. There are also two types of grid spacing: a regular grid (spacing of 1 pixel), or a spaced grid (spacing of more than 1 pixel). The general idea is to input the setup parameters for the gris (starting/ending positions, spacing), click on the button to generate the corresponding scan (regular or random), then start the scan.

- A regular grid requires both starting and ending X and Y coordinates. Note that the scan goes from top left to bottom right and the parameters must be typed into the "box coordinates" textboxes in this order. Afterwards, you can generate either a regular or a random grid, and click the corresponding grab button to initiate the scan.
- A spaced grid required the starting X and Y coordinates, spacing of grid in both X and Y directions in pixel units, and the number of grids in X and Y directions in pixel units. Note that ending grid position is not required. Again, you need to generate the scan grid first, then perform the scan.

This mode is akin to a typical EBSD experiment albeit at a slow speed since my DED control is in python. The way that script works was to control the mouse cursor to click the grab button of the grab script. First, use the read coordinate button to read the mouse position you want to click, and set the wait time. Then you can either start the GUI (you need to change the directory of the file for this to work), or use the fake GUI (just scan, no grab). Only after setting up the mouse position and the (fake or real) GUI will you be able to start the scan (there will be a reminder).
