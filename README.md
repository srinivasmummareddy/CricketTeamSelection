# CricketTeamSelection

This project selects a team based on the following input criteria
```javascript
{
    "playerHeight": 5.4,
    "playerBMI": 24,
    "playerRuns": 7000,
    "playerWickets": 100,
    "playerStumpings": 100
}
```

The server utilizes PostgresDB as its persistence and uses Dapper as MicroORM and uses best practices for development like logging, loose coupling, unit tests.

Seed data for generating is included in [`here`](./src/Infrastructure/Database/seed.sql).

Function for team selection is included in [`here`](./src/Infrastructure/Database/TeamSelectionFunction.sql).

Postman [`collection`](https://www.getpostman.com/collections/2ccecb2a2d8fdfe577b1) and [`environment variables`](./Local.postman_environment.json) here.


The CricketTeamSelection server exposes the following endpoints -
* [`/api/TeamSelection`](./src/Api/Controllers/TeamSelectionController.cs#L41-L45) to select the team

**Nuget packages referenced -**
```shell
# For logging into file using Serilog
Serilog 
Serilog.AspNetCore
Serilog.Enrichers
Serilog.Enrichers.Process
Serilog.Enrichers.Thread
Serilog.Settings.Configuration
Serilog.Sinks.File

# Dapper as MicroORM
Dapper

# NPGSQL as ADO.NET compliant driver code for Postgres
Npgsql

# For Swagger UI
Swashbuckle.AspNetCore

# For miscellanous tasks
Newtonsoft.Json

# For fluent assertions
Shouldly
```
