# Obey My Commands!

## A C# Exercise

For this exercise you will recreate simplified versions a few handy Linux/Unix commands.

For each command listed below you should create a C# console application. The name of each C# app should be of the form `myxxx` where `xxx` is the name of the original UNIX command. For example, your version of the `head` command should be called `myhead`.

For commands that involve files, it is assumed that the files are text - _not binary_ - files. You can use the `*.txt` files provided in this repo for testing.

> **NOTE:** The real commands are _**significantly**_ more complex than the commands you're being asked to build here. Each command listed below includes a link to the linux documentation (a.k.a. _manual page_). These links are for added context. You are **NOT** being asked to fully implement the command.

> **NOTE:** You might find it interesting to _"publish"_ your commands so they can be executed as stand-alone commands.
>   
> **If you're on Windows:**
> `dotnet publish -r win-x64 -p:PublishSingleFile=true -o publish`
> 
> **If you're on Linux:**
> `dotnet publish -r linux-x64 -p:PublishSingleFile=true -o publish`
> 
> **If you're on MacOS:**
> `dotnet publish -r osx-x64 -p:PublishSingleFile=true -o publish`
>
> Once you've fun this command you can find your executable in the newly created `publish` directory.

### myhead

> [head](https://linux.die.net/man/1/head) FILE
> Print first 10 lines of FILE

> **NOTE:** This program is implemented as an example in this repo.

### mytail

> [tail](https://linux.die.net/man/1/tail) FILE  
> Print last 10 lines of FILE

### mycat

> [cat](https://linux.die.net/man/1/cat) FILE  
> Prints FILE to stdout

> cat FILE1 FILE2 ...  
> Concatenate FILE1 and FILE2 and print to stdout

### mysort

> [sort](https://linux.die.net/man/1/sort) FILE  
> Sort the content of FILE alphabetically and print it to the screen. Do not change the file.  
> **NOTE:** You can use the file, `unordered.txt` in this repo for testing.

### mytouch

> [touch](https://linux.die.net/man/1/touch) FILE  
> Create FILE as empty file

### mydate

> [date](https://linux.die.net/man/1/date)  
> Print the system date and time

### myls

> [ls](https://linux.die.net/man/1/ls)  
> List contents of the current directory

> ls DIR  
> List contents of DIR

### mymkdir

> [mkdir](https://linux.die.net/man/1/mkdir) DIR  
> Create a new directory called DIR

### myrm

> [rm](https://linux.die.net/man/1/rm) FILE  
> Remove FILE

### mycp

> [cp](https://linux.die.net/man/1/cp) FILE1 FILE2  
> Copy the contents of FILE1 to FILE2

### mymv

> [mv](https://linux.die.net/man/1/mv) FILE1 FILE2  
> Rename FILE1 to FILE2

> mv FILE DIR  
> Move FILE to DIR

### mywget

> [wget](https://linux.die.net/man/1/wget) URL  
> Download the file at URL
