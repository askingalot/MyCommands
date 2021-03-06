using System;
using System.IO;

const int LINE_COUNT = 10;

if (args.Length != 1)
{
    Console.Error.WriteLine("USAGE: myhead <filename>");
    Environment.Exit(1);
}

var filename = args[0];

if (!File.Exists(filename))
{
    Console.Error.WriteLine($"No such file: {filename}");
    Environment.Exit(1);
}

using var file = new StreamReader(filename);
for (var i = 0; i < LINE_COUNT; i++)
{
    var line = file.ReadLine();
    if (line == null)
    {
        return;
    }
    Console.WriteLine(line);
}
