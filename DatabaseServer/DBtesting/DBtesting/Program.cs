using TECHCOOL;

//SQLet.ConnectSqlServer("H1PD021123_Jokes", "docker.data.techcollege.dk", "h1pd021123", "h1pd021123");
SQLet.ConnectSQLite(@"c:\users\Jacob Ø. Andersen\documents\mydb.db");
Console.WriteLine("Connected to server");

//SQLet.Execute("INSERT INTO jokes (joke) VALUES ('Haha a joke')");

var res = SQLet.GetResult("SELECT name FROM groups");

foreach (var item in res)
{
    Console.WriteLine(item["name"]);
}

Console.WriteLine("Done");

Console.ReadLine();