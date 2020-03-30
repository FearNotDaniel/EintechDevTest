# EintechDevTest

Sample project for Eintech recruitment process. Created by Daniel Hume via Amicus Recruitment on 30 March 2020.

# Approach

Solution has been designed in line with [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html "Uncle Bob") principles. For such a simple requirement as presented in the task, this would of course be overkill, however this choice was made to demonstrate a suitable design for an enterprise-scale project of six months or more working with a development team. For smaller, disposable apps - PoCs and MVCs - a much simpler MVC approach could be taken that keeps all models in the web project and has the controllers talking directly to Entity Framework objects. The Clean Architecture however has several advantages over this:

* Enables unit testing through Inversion of Control and Dependency Injection (a sample test project is included, though only one test has been implemented at this stage)
* Permits effective Domain Driven Design by uniting all business logic in separate classes away from the application infrastructure and presentation
* This in turn allows for future expansion across multiple platforms by leveraging both domain classes (in the Core project) and a thin API layer.
* Encourages compliance with SOLID principles through mechanisms such as Domain Events as an alternative to later extending classes to carry out extra in-process behaviour.

A simple REST API has been added as part of the main Web project, which could of course be extracted into a separate project from any desktop or mobile website. This can be tested when running the project via the built in [/swagger](https://localhost:44376/swagger/index.html "Requires project running in local IIS") endpoint that presents a UI for making API calls.

# Test Data

A database backup can be found in SQLBackup at the solution root.