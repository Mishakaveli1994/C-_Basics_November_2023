# Dotnet commands
`dotnet --list-sdks` - Check .NET SDK's installed

`dotnet --list-runtimes` - Check .NET runtimes installed

`dotnet --info` - Check all .NET info

`dotnet new console` - Create new console app

`dotnet new console -f net6.0` - Create with a specific .NET SDK version

`dotnet new console -f net7.0 --use-program-main -o .\9_Fish_Tank\` - for specific path

`dotnet new sln` - create .sln file

`dotnet sln add (ls -r **/*.csproj)` - automaticall add project to sln file (check directory !)

`..\create_directories.ps1 .` - from project folder with created folders to auto create .sln and add .csproj files