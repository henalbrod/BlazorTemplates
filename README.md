# Blazor App Mixed Host Solution

This is a Visual Studio 2019 Preview 3 project template for creating [Blazor](http://blazor.net) v0.8.0 solutions that can be hosted either client or server side, the idea behind this is to have a convenient implementation that allows changing from hosting models easily.

This template implements both the client-side and server-side hoting models using the classic blazor ASP.Net Core Hosted Solution Structure:

- [solution_name].Client
- [solution_name].Server
- [solution_name].Shared


### Runnning in server-side/Razor Components mode

Select the [solution_name].Server project or set it as the default project doing so the application will run under server-side (ASP.NET Core Razor Components with SignalR) host model. 

- Under this mode you can debug the Client C# code, controllers routes also work under "api/{controller}/{action}" routes
- Please note that in this template the Server project utilizes the same wwwroot folder located inside the Client project, so there's no need to move it inside the Server project.
- Server project points to Client's wwwroot folder, so no need of move it into Server project.

### Runnning in client-side mode

Select the [solution_name].Client project or set it as the default project doing so the application will run under client-side host model

- Under this mode you cannot debug the Client C# code, it will act as a static web site


### How to use it?

Clone the repository or directly [Download](https://github.com/Pegazux/Blazor-App-Mixed-Host-Solution/blob/master/Blazor%20App%20Mixed%20Host%20Solution/Blazor%20App%20Mixed%20Host%20Solution.zip?raw=true) the template zip file and follow [this instructions](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-locate-and-organize-project-and-item-templates?view=vs-2019#user-templates)


### Known issues

- Pressing F5 throws an exception while running in server-side mode (except root path)