@echo off
set pt=%~dp0
del exe\ /s /q
rd exe\ /s /q

xcopy bin\Release\OEMchange.exe exe\ /i /f /v /h /y
xcopy bin\Release\bmp exe\bmp\ /i /f /v /h /y
xcopy bin\Release\content.json exe\ /i /f /v /h /y
xcopy bin\Release\content.xml exe\ /i /f /v /h /y
xcopy bin\Release\readme.txt exe\ /i /f /v /h /y

xcopy ..\packages\MetroModernUI.1.4.0.0\lib\net\MetroFramework.Design.dll exe\ /i /f /v /h /y
xcopy ..\packages\MetroModernUI.1.4.0.0\lib\net\MetroFramework.dll exe\ /i /f /v /h /y
xcopy ..\packages\MetroModernUI.1.4.0.0\lib\net\MetroFramework.Fonts.dll exe\ /i /f /v /h /y

xcopy ..\packages\Newtonsoft.Json.12.0.2\lib\net40\Newtonsoft.Json.dll exe\ /i /f /v /h /y

::合并DLL  EXE
%pt%\tools\ILMerge.exe  /ndebug /target:winexe /targetplatform:v4 /out:%pt%\exe\OEM_change.exe /log %pt%\exe\OEMchange.exe %pt%\exe\MetroFramework.Design.dll %pt%\exe\MetroFramework.dll %pt%\exe\MetroFramework.Fonts.dll %pt%\exe\Newtonsoft.Json.dll

del exe\OEMchange.exe
del exe\MetroFramework.Design.dll
del exe\MetroFramework.dll
del exe\MetroFramework.Fonts.dll
del exe\Newtonsoft.Json.dll


if exist %pt%\exe\OEM_change.exe (rename %pt%\exe\OEM_change.exe OEMchange.exe && echo success) else (echo ERROR) 


pause