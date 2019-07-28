@echo off
if %1. == . goto noparm
if exist %1.res del %1.res
echo Task 1 >%1.res
echo Program to test: %1 >>%1.res
echo ................ >>%1.res 
for %%i in (01,02,1,2,3,4,5,6,7,8,9,10) do call test.bat %%i %1
if exist input.txt del input.txt>Nul
if exist output.txt del output.txt>Nul
if exist %1.res sum.exe %1.res
exit
:noparm
@echo Usage: test_all filename
@echo filename must be without extension!
