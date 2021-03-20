using System;
using System.Collections.Generic;
using System.IO;

const int LINE_COUNT = 10;

if (args.Length != 1)
{
    Console.Error.WriteLine("USAGE: mytail <filename>");
    Environment.Exit(1);
}

var filename = args[0];

if (!File.Exists(filename))
{
    Console.Error.WriteLine($"No such file: {filename}");
    Environment.Exit(1);
}

var queue = new FixedStringQueue(LINE_COUNT);
string line;

using (var reader = new StreamReader(filename))
{
    while ((line = reader.ReadLine()) != null)
    {
        queue.Enqueue(line);
    }
}

while ((line = queue.Dequeue()) != null)
{
    Console.WriteLine(line);
}


class FixedStringQueue
{
    private int _maxSize;
    private Queue<string> _internalQueue;

    public FixedStringQueue(int maxSize)
    {
        if (maxSize <= 0)
        {
            throw new ArgumentException($"{nameof(maxSize)} must be greater than zero.");
        }
        _maxSize = maxSize;
        _internalQueue = new(maxSize);
    }

    public void Enqueue(string newValue)
    {
        if (_internalQueue.Count == _maxSize)
        {
            _internalQueue.Dequeue();
        }
        _internalQueue.Enqueue(newValue);
    }

    public string Dequeue()
    {
        _internalQueue.TryDequeue(out var value);
        return value;
    }
}