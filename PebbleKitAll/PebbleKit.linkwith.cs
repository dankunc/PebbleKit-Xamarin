using System;
using ObjCRuntime;

[assembly: LinkWith ("PebbleKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
