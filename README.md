# Omnideck API
This is the package for the Unity Omnitrack API by Omnifinity.

## Installation
Use the Unity Package Manager and add this github repo using the 
url. 

Navigate to the <i>Project Settings > XR Plug-in Managment</i>. Enable the OpenXR tickbox and fix any issues Unity recommends.
If you are using a HTC Vive Controller navigate to the <i>Project Settings > XR Plug-in Management > OpenXR</i> and add the <i>HTC Vive Controller Profile</i> in the <i>Interaction Profiles</i> section.

Navigate to the <i>Window > Package Manager</i>. Search for the <i>XR Interaction Toolkit</i> package, navigate to its Samples and import the Starter Assets sample. 

More details will follow...

## Samples
The package contains three samples on how to integrate the Omnideck API with your VR application.
- Example 1: Integration with the Unity XR Interaction toolkit interaction system (v2.5.2+) by adding a OmnideckContinousMoveProvider that extends the ContinousMoveProviderBase from XRI. Remember to import the XRI Starter Asset samples. Uses a Unity Character Controller that can collide with the surrounding objects. Supports hand controllers and basic interaction.
- Example 2: Integration using a Unity Character Controller that can collide with the surrounding objects. It has an XR Rig attached to it.
- Example 3: Integration using a Vector3 script, without any object collision. It has an XR Rig attached to it.

## Changelog
Please see https://github.com/Omnifinity/Unity-Omnideck-API/blob/main/CHANGELOG.md
