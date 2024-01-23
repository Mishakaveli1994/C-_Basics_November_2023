param(
    [string]$path
)
$rootDirectory = Resolve-Path $path

# Get all subdirectories in the root directory
$subdirectories = Get-ChildItem -Path $rootDirectory -Directory

foreach ($dir in $subdirectories) {
    # Check if the directory is empty (no files or subdirectories)
    $isEmpty = @(Get-ChildItem -Path $dir.FullName).Count -eq 0

    if ($isEmpty) {
        # If the directory is empty, run the dotnet new console command
        dotnet new console -f net7.0 --use-program-main -o $dir.FullName

    }
}

dotnet new sln -o $rootDirectory
dotnet sln add (ls -r $rootDirectory/*.csproj)

Write-Host "Process completed."
