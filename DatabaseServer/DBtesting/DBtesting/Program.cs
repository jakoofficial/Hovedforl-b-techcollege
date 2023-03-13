using TECHCOOL;

SQLet.ConnectSqlServer("H1PD021123_Jokes", "docker.data.techcollege.dk", "h1pd021123", "h1pd021123");
Console.WriteLine("Connected to server");

//SQLet.Execute("INSERT INTO jokes (joke) VALUES ('Haha a joke')");

var res = SQLet.GetResult("SELECT joke FROM jokes");

foreach (var item in res)
{
    Console.WriteLine(item["joke"]);
}

Console.WriteLine("Done");

Console.ReadLine();