$ProjectDir = "C:\Users\george_serban\rock-paper-scissors\RockPaperScissors"
$PackagesDir = "$ProjectDir\packages"
$OutDir = "$ProjectDir\NUnitTests\bin\Debug"

# Install NUnit Test Runner
$nuget = "C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe"
& $nuget install NUnit.Runners  -Version 2.6.2 -o $PackagesDir

# Set nunit path test runnerC:\Program Files (x86)\NUnit 2.6.3\bin
$nunit = "C:\Program Files (x86)\NUnit 2.6.3\bin"

#Find tests in OutDir
$tests = (Get-ChildItem $OutDir -Recurse -Include *Tests.dll)

# Run tests
& $nunit /noshadow /framework:"net-4.0" /xml:"$OutDir\Tests.nunit.xml" $tests