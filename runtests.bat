set project=HtmlGenerator
set packages_path=C:\Users\hughb\.nuget\packages
set tests_path=src\HtmlGenerator.Tests\bin\debug\net45\win10-x64
set test_name=%project%.Tests.exe

set open_cover=%packages_path%\OpenCover\4.6.519\tools\OpenCover.Console.exe
set report_generator=%packages_path%\ReportGenerator\2.4.5\tools\ReportGenerator.exe	
set xunit=%packages_path%\xunit.runner.console\2.2.0-beta2-build3300\tools\xunit.console.exe

set test_name=%tests_path%\%test_name%

set report_name=resources\coverage.xml
set report_path=resources\coverage

%open_cover% -register:user -output:"%report_name%" -filter:"+[%project%*]* -[%project%.Tests]*" -target:"%xunit%" -targetargs:"%test_name% -noshadow"

%report_generator% -reports:"%report_name%" -targetdir:"%report_path%"
