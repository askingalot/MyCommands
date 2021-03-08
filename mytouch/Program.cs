using System;
using System.IO;

if (args.Length != 1)
{
    Console.Error.WriteLine("USAGE: mytouch <filename>");
    Environment.Exit(1);
}

File.CreateText(args[0]);
