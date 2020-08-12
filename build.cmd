
@echo off

color 17
Title 脚本编译处理

REM msbuild config

set config=Release

set outputdir=bin\Release

set commonflags=/p:Configuration=%config%;AllowUnsafeBlocks=true /p:CLSCompliant=False



if %PROCESSOR_ARCHITECTURE%==x86 (

         set msbuild="%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"

) else ( set msbuild="%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"

)


:begin
cls
Echo. 请选择需要的操作
Echo     1 . OEM_change_CSharp
Echo     2 . OEM_change_VB
Echo     3 . clean
Echo     4 . Exit 

Set /P Choice= 　　　　　请选择要进行的操作数字 ，然后按回车：
If not "%Choice%"=="" (
  If "%Choice%"=="4" exit
  If "%Choice%"=="3" call clean.bat && exit /b 1
  If "%Choice%"=="2" goto vb
  If "%Choice%"=="1" goto cs
)
::pause>nul
goto :begin

clean.bat

REM this script for _VB
:vb
echo ---------------------------------------------------------------------

echo Building ...

%msbuild% "%~dp0Project_OEM_change_VB\Project_OEM_change_VB.vbproj" %commonflags% /tv:4.0 /p:TargetFrameworkVersion=v4.5 /p:Platform="Any Cpu" /p:OutputPath="%~dp0Project_OEM_change_VB\%outputdir%"

if errorlevel 1 goto build-error
cd /d %~dp0Project_OEM_change_VB
call package.cmd
exit /b 1
REM this script for _CSharp
:cs
echo ---------------------------------------------------------------------

echo Building ...

%msbuild% "%~dp0Project_OEM_change_CSharp\Project_OEM_change_CSharp.csproj" %commonflags% /tv:4.0 /p:TargetFrameworkVersion=v4.5 /p:Platform="Any Cpu" /p:OutputPath="%~dp0Project_OEM_change_CSharp\%outputdir%"

if errorlevel 1 goto build-error
cd /d %~dp0Project_OEM_change_CSharp
call package.cmd
exit /b 1

:build-error

echo Failed to compile...
exit /b 1
