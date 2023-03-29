using Automaten;

//Console.SetWindowSize(1920,1080);

Automat automat = new Automat();
Storage storage = new Storage();

automat.SetupAutomat(storage);

//Draw.DrawBox(2, 2, 50, '#', 15, '|');

Console.ReadKey();
