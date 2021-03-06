# HttpListener
ASP.Net Core 6.0 Minimal Web API

# Description
Provides sample endpoint to accept POST request for applicaton/json content and logs incoming data to console.

# How to launch
## Using source code from Visual Studio Code
Edit __Properties\launchSettings.json__ to set proper hostname and port.  
In Terminal window type __dotnet run__ and hit Enter.

## Deploy self-contained executable
In Terminal window type __dotnet publish -c Release -r win_x86 -o "<target_path>" --self-contained__  

Run __HttpListener.exe --urls http(s)://hostname:port__ from the target path

## Use pre-built for win-x86
Copy __Artifacts\SelfContained\win-x86__ or __Artifacts\FrameworkDependent\win-x86__ to target machine

Run __HttpListener.exe --urls http(s)://hostname:port__ from the target path

# Usage
1. Navigate to __http(s)://hostname:port/swagger__ in browser to see available endpoints and methods  
2. Use Postman (or other application) to send request to specified endpoint  
3. Incoming request content is logged to console window  