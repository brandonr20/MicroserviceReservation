# MicroserviceReservation

## Table of Contents
1. [General Info](#general-info)
2. [Technologies](#technologies)
3. [Getting Started](#getting_started)


### General Info
***
This is an API for the microservice reservation.

Here we can create a reservation, obtain a reservation according to its id, obtain a list of reservations according to the airline name

## Technologies
***
List of technologies used within the project:
* [Net Core 5]

## Getting Started
***
please clone the repository with the following code. 
```
$ git clone https://github.com/brandonr20/MicroserviceReservation.git
```

Create file appsettings.json in the project MicroserviceReservation with the following code

```
{
  "ConnectionStrings": {
    "ReservationDB": "Server={YOUR_SERVER_NAME};Initial Catalog={YOUR_DATABASE_NAME};User ID={YOUR_USERID};Password={YOUR_PASSWORD};Trusted_Connection=True;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```
