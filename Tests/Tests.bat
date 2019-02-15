:: Use this to batch unit test various options to call the Console app with

@echo off

:: Rename this full path to location on your machine of the FileData.exe
SET testExe=C:\DEV\app2\DeveloperTestExercise-master\DeveloperTestExercise-master\FileData\bin\Debug\FileData.exe

:: If the first argument is anyone of –v, --v, /v, --version then return the version of the file (use FileDetails.Version to get the version number, don’t worry about accessing the file or checking if it exists etc.)

echo Case Version 1
CALL %testExe% -v c:/test.txt
echo Case Version 2
CALL %testExe% --v c:/test.txt
echo Case Version 3
CALL %testExe% /v c:/test.txt
echo Case Version 4
CALL %testExe% --v "c:/file/with spaces/in it.txt"

echo.

:: If the second argument is anyone of –s, --s, /s, --size the return the size of the file (use FileDetails.Size)
echo Case Filesize 1
CALL %testExe% -s c:/test.txt
echo Case Filesize 2
CALL %testExe% --s c:/test.txt
echo Case Filesize 3
CALL %testExe% /s c:/test.txt

echo.

:: Some cases where it should gracefully fail
echo Case fail 1
CALL %testExe% s
echo Case fail 2
CALL %testExe% s c:/test.txt
echo Case fail 3
CALL %testExe%
echo Case fail 4
CALL %testExe% -s
