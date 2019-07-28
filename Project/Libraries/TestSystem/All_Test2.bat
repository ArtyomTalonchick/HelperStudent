@echo off
for %%i in (z??*.exe) do (
if exist %%~ni.res del %%~ni.res
echo Task 1 >%%~ni.res
echo Program to test: %%~ni
echo Program to test: %%~ni >>%%~ni.res
echo ................ >>%%~ni.res 
for %%j in (01,02,1,2,3,4,5,6,7,8,9,10) do call test.bat %%j %%~ni
if exist input.txt del input.txt>Nul
if exist output.txt del output.txt>Nul
if exist %%~ni.res sum.exe %%~ni.res
)