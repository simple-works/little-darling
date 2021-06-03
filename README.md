# ![Icon](./icon_32x32.png?raw=true) Little Darling

[![Plarform Windows](https://img.shields.io/badge/Windows-blue?logo=windows)](https://github.com/topics/windows)
[![C# 3.0](https://img.shields.io/badge/C%23-3.0-blue?logo=c-sharp)](https://github.com/topics/csharp)
[![.NET Framework 3.5](https://img.shields.io/badge/.NET%20Framework-3.5-blue?logo=dot-net)](https://github.com/topics/dotnet)

This is a an unharmful prank application you can use for your pranking plans. :smiley:

**:floppy_disk: [Download Binary Release (SFX Installer)](./Little%20Darling/bin/Release/LittleDarling.sfx.exe?raw=true "Download")**

![screenshot](./screenshot.gif?raw=true "Little Darling")

## :sparkles: What it does ?
Once opened and closed, from time to time, you will start hearing a baby in the background. <br/>
It will also keep running after windows startups, until you manage to stop it.<br/>
This is for pranksters who like to see their friends getting creeped out and going insane when they can't figure out where the baby sounds are coming from.

## :information_source: How it works ?
- When you click OK or close the application, it doesn't actually end, it just hides in the background.
- Every time and after a random delay, It starts playing a random sound file in the background.
- To really close it, you just need to open the task manager, find its process and kill it.
- For camouflage purpose, its process is named `svchost.exe` to be confounded with the other already running [Windows SvcHost Processes](https://en.wikipedia.org/wiki/Svchost.exe "Read about SvcHost on Wikipedia").
- It also register itself to run on every Windows startup through an entry in the [Windows Registry](https://en.wikipedia.org/wiki/Windows_Registry "Read about Registry on Wikipedia").
- To prevent it from running on Windows start, you have to remove that registry entry.
- There's a way to open and close the application without anything of the above happening.
- By right clicking on the baby icon in the left top corner and choosing `Stop` from the secret contextual menu, It will end without anything happening and will also remove (If it exists) the registry entry that makes it run on Windows startup.

## :rocket: Development
The source is written in **[C#](https://github.com/dotnet/csharplang) 3.0** with **[.NET](https://github.com/dotnet) Framework 3.5** and **[WinForms](https://github.com/dotnet/winforms)** using **[Visual Studio](https://visualstudio.microsoft.com) 2010**.

## :page_facing_up: License
- Licensed under [MIT License](./LICENSE?raw=true).
- Using [CSCore 1.2.1.2](https://github.com/filoe/cscore) licensed under [Microsoft Public License](https://github.com/filoe/cscore/blob/master/license.md).