# AndOTA
AndOTA is a C# WinForms implementation of the sdat2img script.
It allows you to convert Android Lollipop (5.0) and newer OTA files (system.new.dat, system.transfer.list) to ext4 images.

![Screenshot](https://raw.githubusercontent.com/evilpro/AndOTA/master/AndOTA.png?token=AB2jUgMBbElbl0L7kk2SPvUvakqhuxnxks5bajmNwA%3D%3D)

## Info
As mentioned above the utility is written in C#. The current target framework is .NET Framework 4.5.

## Credits
### Original script
This is basically just a reimplementation of the already existing sdat2img Python script.
The sdat2img repository can be found here: https://github.com/xpirt/sdat2img

### Pyhton range in C#
The project uses a C# implementation of the Python range function.
It was originally created by David Tchepak and published on his blog at https://davesquared.net/2008/01/python-like-range-implementation-in-c.html
