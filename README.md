# Squirrel-Sizer
This is a simple file sizing library.

Goto https://www.nuget.org/packages/SquirrelSizer/

To use it is simple.

### You give it a long number and it gives you a string with the size abbreviation suffix.

```c#
long number = 1024;
Sizer.GetSizeSuffix(number); // This will output 1.00kb
```

or 

```c#
long number = 1024;
Sizer.GetSizeName(number); // This will output 1.00 Kilobyte
```

-------

### To use this with files is even as easy.

```c#
Sizer.GetSizeSuffix("C:\\Path\\To\\File\\file.txt"); // This will output the converted size of the file.
```

or 

```c#
Sizer.GetSizeName("C:\\Path\\To\\File\\file.txt"); // This will output the converted size of the file.
```

-------

### You can even get the complete size of multiple files

```c#
List<string> files = new List<string>() {
            "C:\\Path\\To\\File\\file1.txt",
            "C:\\Path\\To\\File\\file2.txt",
            "C:\\Path\\To\\File\\file3.txt"
        };
Sizer.GetFullSizeSuffix(files); // This will output the size of all the files in the list
```

or

```c#
List<string> files = new List<string>() {
            "C:\\Path\\To\\File\\file1.txt",
            "C:\\Path\\To\\File\\file2.txt",
            "C:\\Path\\To\\File\\file3.txt"
        };
Sizer.GetFullSizeName(files); // This will output the size of all the files in the list
```

