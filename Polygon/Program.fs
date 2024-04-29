open FSharp.Data.Sql
open Microsoft.Data.Sqlite

[<Literal>]
let connectionString = 
    "Data Source=" + 
    __SOURCE_DIRECTORY__ + @"/../../../tests/SqlProvider.Tests/scripts/northwindEF.db;" + 
    "Version=3;foreign keys=true"

let connection = new SqliteConnection("Data Source=db.db")
connection.Open()
    