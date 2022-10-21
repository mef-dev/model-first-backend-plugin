if not exist "bin" mkdir bin

cd bin
rd /s /q . 2>nul
cd ..
dotnet publish -o bin\Deploy --force --arch x64
cd bin\Deploy
rmdir runtimes /s /q
rem powershell.exe -nologo -noprofile -command "Compress-Archive -Force -Path %~s1\*.* Bss.Entities.zip"
rem powershell.exe -nologo -noprofile -command "Compress-Archive -Force -Path %~dp0\*.* Bss.Entities.zip"
powershell.exe -nologo -noprofile -command "Compress-Archive -Force -Path *.* Bss.Entities.zip"

pause
