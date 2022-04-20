dotnet publish -c Release -r win-x86 -o ".\Artifacts\SelfContained\win-x86" --self-contained

dotnet publish -c Release -r win-x86 -o ".\Artifacts\FrameworkDependent\win-x86" --no-self-contained