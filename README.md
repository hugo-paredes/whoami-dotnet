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
# Run the API locally
dotnet run --project src/HostApp/HostApp.csproj
```

```bash
# Make sure to have a tool manifest available in your repository or create one using the following command:
dotnet new tool-manifest
# Install Cake as a local tool using the dotnet tool command (you can replace 2.2.0 with a different version of Cake you want to use):
dotnet tool install Cake.Tool --version 2.2.0
```
