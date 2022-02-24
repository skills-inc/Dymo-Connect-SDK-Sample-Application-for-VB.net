# Dymo Connect SDK Sample Application for VB.net

Since Dymo did not provide any vb.net samples with their Dymo Connect SDK, I am sharing my sample application to help others get started.

Dependencies
DYMO.Connect.SDK 1.4.2.35
NETStandard - NETStandard.Library 2.0.0
SkiaSharp - SkiaSharp 1.68.0
SkiaSharp.Views - SkiaSharp.Views 1.68.0

**ClickOnce Deployment Tips**

When you build your application with the Dymo Connect SDK from Nuget, not all the dll files will come along with your ClickOnce deployment.
You will know that you have dlls missing when you get an error that the element DieCutLabel does not exist in template or that no printers can be found.
In this application I was able to work around it by comparing the build in the \bin\debug folder against my ClickOnce deployment folder to see what files were missing from my ClickOnce deployment.
I added these to my project and set them to Build Action: Content and Copy if newer:


libSkiaSharp.dll

x86\DYMOPrinting.dll

x86\PrintingSupportLibrary.dll

x86\libdymobarcode.dll

x86\LW5xxCommunicationLibrary.dll

x86\usps4cb.dll


I messed around with mag.exe and building a custom manifest and it just was nothing but a hassle.  At least this method will still allow me to make updates to my code and quickly publish.
Nice advantage to upgrading my apps from the old SDK to the new Dymo Connect SDK is that I'm no longer tied to the version of the Dymo software installed on the endpoint.

This is all after I had already added as much to my references as I could, the problem is that the SDK files in the x86 folder MUST be in the x86 folder and you must set the Compile target to x86.  I didn't need the x64 folder.

These are the dll files I had in my build (that were not already in the x86 folder)
I had to manually add libSkiaSharp.dll, but the rest were added as References.

DYMO.Common.dll

DYMO.CrossPlatform.Common.dll

DYMO.CrossPlatform.Common.PlatformSpecific.dll

DYMO.LabelAPI.dll

DYMO.LabelAPI.PlatformSpecific.dll

DymoSDK.dll

libSkiaSharp.dll

netstandard.dll

SkiaSharp.dll

SkiaSharp.Views.Desktop.dll

SkiaSharp.Views.Gtk.dll

SkiaSharp.Views.WPF.dll
