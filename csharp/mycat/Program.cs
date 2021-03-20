using System;
using System.IO;

const int BUFFER_SIZE = 4096;

if (args.Length == 0)
{
    Console.Error.WriteLine("USAGE: mycat <filename> ...");
    Environment.Exit(1);
}

var buffer = new char[BUFFER_SIZE];

foreach (var filename in args)
{
    if (!File.Exists(filename))
    {
        Console.Error.WriteLine("No such file: " + filename);
        continue;
    }

    using var reader = new StreamReader(filename);
    int numRead;
    while ((numRead = reader.Read(buffer)) != 0)
    {
        Console.Write(buffer, 0, numRead);
    }
}
