# Rest-Dot-Net-core-Boilerplate
 <img align="left" width="116" height="116" src="https://raw.githubusercontent.com/shreedhar-ww/rest-dot-net-core-boilerplate/main/.github/icon.png" /> 
<br/><br/><br/>

<p align="left> This is a solution template for creating a Single Page App (SPA) with Angular and ASP.NET Core following the principles of Clean Architecture.  </p>

## Technologies

* ASP.NET Core 3.1
* [Entity Framework Core 3.1](https://docs.microsoft.com/en-us/ef/core/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)
* [NUnit](https://nunit.org/), [FluentAssertions](https://fluentassertions.com/), [Moq](https://github.com/moq) & [Respawn](https://github.com/jbogard/Respawn)
* [Docker](https://www.docker.com/)
* [Seri Logger](https://serilog.net/)

## Overview
   <img  width="800" height="400" src="https://raw.githubusercontent.com/shreedhar-ww/rest-dot-net-core-boilerplate/main/.github/overview.png" /> 
<br/>
   <img align="right" width="300" height="300" src="https://raw.githubusercontent.com/shreedhar-ww/rest-dot-net-core-boilerplate/main/.github/cleanarch.png" />  

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

### WebUI

This layer is a single page application based on Angular 10 and ASP.NET Core 5. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only *Startup.cs* should reference Infrastructure.


## License

This project is licensed with the [MIT license](LICENSE).