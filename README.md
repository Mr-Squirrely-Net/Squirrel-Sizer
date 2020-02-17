# Squirrel-Sizer
A simple to use file sizer.

To use it simple.

You give it a long number and it gives you a string with the size abbreviation suffix.

```c#
long number = 1024;
Sizer.SizeSuffix(number); // This will output 1.00kb
```

To use this with files is even as easy.

```c#
FileInfo info =  new FileInfo("C:\\Path\\To\\File\\file.txt");
Sizer.SizeSuffix(info.Length); // This will output the converted size of the file.
// So if the size of the file in bytes is 1024 it will give you 1.00kb
```

You also have these if you want them

```c#
Sizer.Zero; // This will give you 0.00bytes
Sizer.Max // This will give you 8.00EB
```

