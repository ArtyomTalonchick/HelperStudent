@echo off
@echo Test %1
@echo Test %1 >>%2.res
if exist input.txt del input.txt
if exist output.txt del output.txt
copy %1.in input.txt>nul
rem timer %2.exe 1000 1024 >>%2.res
%2.exe
if exist output.txt goto next
@echo No output file! >>%2.res
goto end
:next
Checker.exe %1.out >>%2.res
rem fc output.txt out.%1 >>%2.res
@echo ---------->>%2.res
:end
