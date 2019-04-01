$ScriptFromGit = Invoke-WebRequest https://git.epam.com/George_Serban/rock-paper-scissors/tree/master/NUnitConsoleScript.ps1
Invoke-Expression $($ScriptFromGit.Content)