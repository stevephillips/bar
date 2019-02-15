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




:: If the second argument is anyone of –s, --s, /s, --size the return the size of the file (use FileDetails.Size)


:: Some cases where it should gracefully fail
