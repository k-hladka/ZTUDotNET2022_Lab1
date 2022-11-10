using Lab1ForNetCore.Classes;

List <MusicalInstrument> instrument = new List <MusicalInstrument> ();
instrument.Add(new Violin());
instrument.Add(new Trombone());
instrument.Add(new Ukulele());
instrument.Add(new Cello());

instrument.Add(new Violin("Скрипка"));      // index = 4
instrument.Add(new Trombone("Тромбон"));
instrument.Add(new Ukulele("Укулеле"));
instrument.Add(new Cello("Вiолончель"));

instrument.Add(new Violin("Violin", 7250));
instrument.Add(new Trombone("Trombone", 25720));    //index = 9
instrument.Add(new Ukulele("Ukulele", 5890));
instrument.Add(new Cello("Cello", 140800));

//Перші чотири цикли виводять по 4 елементи, щоб не повторювати виклик методів для однакових об'єктiв
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Звук: ");
Console.ResetColor();
for (int i = 0; i < 4; i++)
    instrument[i].Sound();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\nНазва: ");
Console.ResetColor();
for (int i = 0; i < 4; i++)
    instrument[i].Show();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nОпис: ");
Console.ResetColor();
for (int i = 0; i < 4; i++)
    instrument[i].Decs();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nIсторiя створення: ");
Console.ResetColor();
for (int i = 0; i < 4; i++)
    instrument[i].History();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nВся доступна iнформацiя: ");
Console.ResetColor();
for (int i = 0; i < instrument.Count; i++)
    instrument[i].ShowInfo();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nПриклид клонування: ");
Console.ResetColor();
//instrument[4] = new Violin("Скрипка"); - визначено вище
instrument.Add((MusicalInstrument)instrument[4].Clone());   //index = 12
instrument[12].Name = "SKRIPKA";
Console.WriteLine($"instrument[4].Name = {instrument[4].Name}");
Console.WriteLine($"instrument[12].Name = {instrument[12].Name}");

//instrument[9] = new Trombone("Trombone", 25720); - визначено вище
instrument.Add((MusicalInstrument)instrument[9].Clone());   //index = 13
instrument[13].Price = 35000;
Console.WriteLine($"instrument[9].Price = {instrument[9].Price}");
Console.WriteLine($"instrument[13].Price = {instrument[13].Price}");