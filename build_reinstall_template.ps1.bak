function Reset-Templates{
    [cmdletbinding()]
    param(
        [string]$templateEngineUserDir = (join-path -Path $env:USERPROFILE -ChildPath .templateengine)
    )
    process{
        'resetting dotnet new templates. folder: "{0}"' -f $templateEngineUserDir | Write-host
        get-childitem -path $templateEngineUserDir -directory | Select-Object -ExpandProperty FullName | remove-item -recurse
        &dotnet new --debug:reinit
    }
}
nuget pack .\nuget.conf.template.nuspec -OutputDirectory .\nupkg
Reset-Templates
dotnet new --uninstall yacloud.serverless.template.nuspec
dotnet new --install .\nupkg\yacloud.serverless.template.nuspec.1.0.1.nupkg