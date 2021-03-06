using System;
using System.IO;
using System.Linq;

if (args.Length != 1)
{
    Console.Error.WriteLine("USAGE: mysort <filename>");
    Environment.Exit(1);
}

var filename = args[0];

if (!File.Exists(filename))
{
    Console.Error.WriteLine($"No such file: {filename}");
    Environment.Exit(1);
}

var sorted = File.ReadAllLines(filename).OrderBy(line => line);
foreach (var line in sorted)
{
    Console.WriteLine(line);
}
