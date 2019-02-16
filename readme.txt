I was a bit confused by the instructions here:

·       Takes in two arguments (argument 1 = functionality to perform, argument 2 = filename)
·       If the first argument is anyone of –v, --v, /v, --version then return the version of the file (use FileDetails.Version to get the version number, don’t worry about accessing the file or checking if it exists etc.)
·       If the second argument is anyone of –s, --s, /s, --size the return the size of the file (use FileDetails.Size)

^^^ Which are a bit ambiguous ("the second argument is anyone of –s, --s, /s, --size"), I assumed that the command line arguments were of the form:

EXE [action] [filename]

--------------------------------------------------------------------------------------------------------------------------

To run the tests open the file in Tests\Tests.bat and change the path to the executable to where it is on your machine, then just run the Test.bat

