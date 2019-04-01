$CMD = 'nunit3-console.exe'
$arg = 'C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\NUnitTests\bin\Debug\NUnitTests.dll
'

& $CMD $arg 

$HtmlGenerator = 'C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\NUnit-HTML-Report-Generator\NUnitHTMLReportGenerator.exe'
$htmlarg1 = 'C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\NUnitTests\bin\Debug\TestResult.xml'
$htmlarg2 = 'C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\HtmlReport\report1.html' 

& $HtmlGenerator $htmlarg1 $htmlarg2