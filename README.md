
## Overviews

This project is a demo implementation of **sentry-unity**, the Sentry SDK for Unity Crash Reporting. The demo produces several crashes that get captured by sentry-unity and sent to Sentry.io. You can also download the SDK manually here https://github.com/getsentry/sentry-unity as a distribution zip.

The **Official Sentry Documentation** for Unity is at https://docs.sentry.io/platforms/unity/

## Setup
| dependency    |    version     |
| ------------- | :------------: |
| sentry-unity  |     0.4.3      |
| unity hub     |     2.4.5      |
| unity version |   2020.3.15f2  |
| macOS         |  Big Sur 11.4  |

<ins>Unity</ins>

Download Unity Hub using this link https://unity3d.com/get-unity/download 

if you dont have licesne choose your Unity and go to individul to get the free version 

install the proper unity version 


## Configuration 

For this demo Sentry is installed but I'll show you how you can easily do that from Unity's package manager. 

<img src="README/package-manager.png">

You can now access Sentry's Configuration Window under *Unity->Tools->Sentry*



### DSN key

Sentry can be configured via the Sentry configruation window or [programatically](https://docs.sentry.io/platforms/unity/configuration/options/). 

<img src="README/sentry-config.png">


## Run
1. clone this repo 
2. Go to Unity Hub, Add this repo as a project
3. Install proper vesion of unity if need be  
4. Click the run button 

## Expected Behavior 

Welcome to Senty's ground-breaking game, this games consists of multiple buttons 

**Play** calls `throwNullException()`

**Settings** navigates to settings menu

**Exit** calls `ExceptionToString()`

more about the functions can be found here: https://github.com/getsentry/sentry-unity/tree/main/samples/unity-of-bugs




## Gif

![gif](README/unity-demo.gif)
