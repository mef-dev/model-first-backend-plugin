if not exist %~dp0bin (mkdir %~dp0bin)
cd bin
rd /s /q . 2>nul
cd ..
dotnet publish -o bin\Deploy --force
cd bin\Deploy
rmdir runtimes /s /q
powershell.exe -nologo -noprofile -command "Compress-Archive -Force -Path *.* Natec.Entities.zip"