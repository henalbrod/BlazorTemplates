# Blazor App Mixed Host Solution
This is a Visual Studio 2019 project template for creating [blazor](http://blazor.net) v0.8.0 solutions that can be hosted either client or server side


### Blazor App Mixed Host Solution
This template implements the classic blazor ASP.Net Core Hosted Solution Structure

- [solution_name].Client
- [solution_name].Server
- [solution_name].Shared

Either the Client or Server projects can be set as the Default Project, [solution_name].Client project will run under client-side host style and the [solution_name]..Server project will run under server-side (ASP.NET Core Razor Components with SignalR) host style.
