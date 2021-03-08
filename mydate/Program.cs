using System;
using System.Linq;

var now = DateTime.Now;

var tz = TimeZoneInfo.Local.IsDaylightSavingTime(now)
    ? TimeZoneInfo.Local.DaylightName
    : TimeZoneInfo.Local.StandardName;
tz = TimeZoneAbbreviation(tz);

var format = now.Day < 10
    ? $"ddd MMM  d hh:mm:ss tt {tz} yyyy"
    : $"ddd MMM d hh:mm:ss tt {tz} yyyy";
     
Console.WriteLine(DateTime.Now.ToString(format));


// Surely there's a better way
string TimeZoneAbbreviation(string timeZoneName) =>
    string.Join("",
        timeZoneName.Split(" ").Select(part => part[0])
    ).ToUpper();