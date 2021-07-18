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

which gives sample response like -
```javascript
{
    "bowlers": [
        {
            "playerId": 61,
            "playerName": "Corey Mingame",
            "playerCountry": "Albania",
            "playerType": "bowler",
            "playerHeight": 5.9,
            "playerBmi": 23,
            "playerRuns": 3214,
            "playerWickets": 150,
            "playerStumpings": 0
        },
        {
            "playerId": 53,
            "playerName": "Fiona Lello",
            "playerCountry": "Aland Islands",
            "playerType": "bowler",
            "playerHeight": 5.7,
            "playerBmi": 20,
            "playerRuns": 7500,
            "playerWickets": 219,
            "playerStumpings": 0
        },
        {
            "playerId": 30,
            "playerName": "Arnoldo Salasar",
            "playerCountry": "Albania",
            "playerType": "bowler",
            "playerHeight": 5.8,
            "playerBmi": 23,
            "playerRuns": 5270,
            "playerWickets": 180,
            "playerStumpings": 0
        },
        {
            "playerId": 62,
            "playerName": "Dov Goldis",
            "playerCountry": "Albania",
            "playerType": "bowler",
            "playerHeight": 5.9,
            "playerBmi": 12,
            "playerRuns": 5000,
            "playerWickets": 235,
            "playerStumpings": 0
        },
        {
            "playerId": 24,
            "playerName": "Wiatt Cattow",
            "playerCountry": "Albania",
            "playerType": "bowler",
            "playerHeight": 5.7,
            "playerBmi": 12,
            "playerRuns": 8000,
            "playerWickets": 400,
            "playerStumpings": 0
        }
    ],
    "batsmen": [
        {
            "playerId": 18,
            "playerName": "Anette Gockelen",
            "playerCountry": "Albania",
            "playerType": "batsman",
            "playerHeight": 6,
            "playerBmi": 16,
            "playerRuns": 8321,
            "playerWickets": 46,
            "playerStumpings": 0
        },
        {
            "playerId": 2,
            "playerName": "Janice Kelsow",
            "playerCountry": "Albania",
            "playerType": "batsman",
            "playerHeight": 5.5,
            "playerBmi": 13,
            "playerRuns": 7500,
            "playerWickets": 1,
            "playerStumpings": 0
        },
        {
            "playerId": 45,
            "playerName": "Brittney Drinkhall",
            "playerCountry": "Albania",
            "playerType": "batsman",
            "playerHeight": 5.5,
            "playerBmi": 18,
            "playerRuns": 7500,
            "playerWickets": 180,
            "playerStumpings": 0
        },
        {
            "playerId": 6,
            "playerName": "Nerty Mushawe",
            "playerCountry": "Albania",
            "playerType": "batsman",
            "playerHeight": 5.8,
            "playerBmi": 16,
            "playerRuns": 7500,
            "playerWickets": 46,
            "playerStumpings": 0
        },
        {
            "playerId": 12,
            "playerName": "Terra Setterthwait",
            "playerCountry": "Albania",
            "playerType": "batsman",
            "playerHeight": 5.9,
            "playerBmi": 16,
            "playerRuns": 8321,
            "playerWickets": 55,
            "playerStumpings": 0
        }
    ],
    "keepers": [
        {
            "playerId": 17,
            "playerName": "Wilhelm Morch",
            "playerCountry": "Albania",
            "playerType": "keeper",
            "playerHeight": 5.7,
            "playerBmi": 23,
            "playerRuns": 8654,
            "playerWickets": 235,
            "playerStumpings": 235
        }
    ]
}
```
___

The server utilizes PostgresDB as its persistence and uses Dapper as MicroORM and uses best practices for development like logging, configuration management by environment, loose coupling, unit tests.

Seed data for generating is included in [`here`](./src/Infrastructure/Database/seed.sql).

Function for team selection is included in [`here`](./src/Infrastructure/Database/TeamSelectionFunction.sql).

Postman [`collection`](https://www.getpostman.com/collections/2ccecb2a2d8fdfe577b1) and [`environment variables`](./Local.postman_environment.json) here.


The CricketTeamSelection server exposes the following endpoints -
* [`/api/TeamSelection`](./src/Api/Controllers/TeamSelectionController.cs#L41-L45) to select the team
___

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
