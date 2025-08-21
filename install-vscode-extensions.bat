@echo off
echo Installing VS Code extensions for ASP.NET Core development...

code --install-extension ms-dotnettools.csharp
code --install-extension ms-dotnettools.csdevkit
code --install-extension ms-dotnettools.vscode-dotnet-runtime
code --install-extension ms-dotnettools.blazorwasm-companion

echo Extensions installed! Restart VS Code to activate them.
pause