A hobby full-stack project using sqlite, asp.net core, and react

# Description

A full stack project for the hack day of the bootcamp The task was to present an application completed in one day. The application uses a dataset of moneypox case data seeded into the SqLitle database. Backed was built using Asp.net Core and Entity Framework for database handling. The frontend was built using React.  
# Getting Started

## Build with

* Asp.Net Core
* Entity
* Sqlite
* React

## installing 
1. Clone repository 

```
git clone https://github.com/MistyDoe/MonkeypoxDashboard
```


2. Restore dependencies
Make sure you have installed:
* Microsoft.EntityFrameworkCore.Sqlite 
* EntityFrameworkCore
* Microsoft.EntityFrameworkCore

In terminal, navigate to the DashBoardAPI, then run
```
dotnet restore
```

Afterwards run 

```
dotnet run
```

The backend should be running. 
Now in another terminal instance, navigate to the client folder, then run:
```
npm i
```

after it is done, run:

```
npm start
```

Now the dashboard can be accessed at http://localhost:3000/

## Authors

Migle Urbonaite @MistyDoe

