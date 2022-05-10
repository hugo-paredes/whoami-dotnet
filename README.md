# Whoami dotnet

```bash
# Create solution
dotnet new sln --name Whoami
# Create WebAPI
dotnet new webapi --auth None --no-https true --name HostApp --output src/HostApp
# Add project to solution
dotnet sln Whoami.sln add src/HostApp/HostApp.csproj
# Download `.gitignore` for Visual Studio
curl -o .gitignore https://raw.githubusercontent.com/github/gitignore/main/VisualStudio.gitignore
```
