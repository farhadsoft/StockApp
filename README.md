| Project | For our project we had a new requirement, to create a new HTTP rest API that should be able to return needed stock data by search. |
| --- | --- |
| Participation | As a software engineer, I created the REST API endpoint using C#, .Net for serving HTTP requests about stock data. For synchronization data in Postgres DB, I implemented ETL pattern as an additional service which time to time extracts data from source of true, transform it and process load. In the REST API service, I have implemented access control management for authentication requests. Also, validating and transforming every request to proper LINQ through the API. And API endpoint can return requested data with high performance. I considered lots of best practices about REST API in my implementation. |
| Team | Team: 2 members. .NET developer and 1C developer |
| Database | • Postgres |
| Tools | • Visual Studio 2022 Preview • Visual Studio Code • Insomnia • Docker Desktop • pgAdmin 4 |
| Technologies | • .NET 6 • REST • JSON • Blazor Server • Radzen Blazor • Razor • ExcelDataReader • AutoMapper • Onion Architecture • Docker Hub • Azure App Service • Azure AD B2C • DigitalOcean |
