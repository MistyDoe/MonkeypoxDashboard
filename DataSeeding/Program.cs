// See https://aka.ms/new-console-template for more information

using CsvHelper;
using DashBoardAPI.DAL;
using DashBoardAPI.Models;
using System.Globalization;

Seed();

static void Seed ( )
{
    var db = new CaseContext();
    using var transaction = db.Database.BeginTransaction();
    using ( var reader = new StreamReader("c:/users/migli/source/repos/monkeypoxdashboard-1/dashboardapi/data/data.csv") )
    using ( var csv = new CsvReader(reader, CultureInfo.InvariantCulture) )
        try
        {
            var instance = new CaseDb();
            var cont = csv.EnumerateRecords(instance);
            foreach ( var inst in cont )
            {
                db.Cases.Add(new Case
                {
                    Id = Guid.NewGuid().ToString(),
                    date = inst.date,
                    location = inst.location,
                    total_cases = inst.total_cases,
                });
                db.SaveChanges();
            }
            transaction.Commit();
        }
        catch ( Exception ex )
        {
            Console.WriteLine(ex);
        }
}


