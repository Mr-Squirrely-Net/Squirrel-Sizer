# Squirrel-Sizer
This is a simple file sizing library.

Goto https://www.nuget.org/packages/SquirrelSizer/

To use it is simple.

You give it a long number and it gives you a string with the size abbreviation suffix.

```c#
long number = 1024;
Sizer.SizeSuffix(number); // This will output 1.00kb
```

To use this with files is even as easy.

The new way:
```c#
Sizer.GetSize("C:\\Path\\To\\File\\file.txt"); // This will output the converted size of the file.
```

or

The old way:
```c#
FileInfo info =  new FileInfo("C:\\Path\\To\\File\\file.txt");
Sizer.SizeSuffix(info.Length); // This will output the converted size of the file.
```

You can even get the complete size of multiple files

```c#

List<string> files = new List<string>() {
            "C:\\Path\\To\\File\\file1.txt",
            "C:\\Path\\To\\File\\file2.txt",
            "C:\\Path\\To\\File\\file3.txt"
        };
Sizer.GetCompleteSize(files); // This will output the size of all the files in the list
```

You also have these if you want them

```c#
Sizer.Zero; // This will give you 0.00bytes
Sizer.Max // This will give you 8.00EB
```

