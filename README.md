# Squirrel-Sizer
This is a simple file sizing library.

Goto https://www.nuget.org/packages/SquirrelSizer/

To use it is simple.

### You give it a long number and it gives you a string with the size abbreviation suffix.

```c#
long number = 1234500;
Sizer.Suffix(number); 
// This will output 1kb
```

or 

```c#
long number = 1234500;
Sizer.SuffixName(number); 
// This will output 1 Kilobyte
```

-------

### It will always give you a number with your string
### To stop it from giving you a number

```c#
long number = 1234500;
Sizer.Suffix(number, includeNumber: false)
// This will output kb
```

### You have to include the "includeNumber:" part, this is cause of the way I implemented it.
### I might change this later.

-------

### To change how many decimal places to use it's easy as well

```c#
long number = 1234500;
Sizer.SuffixName(number, 4)
// This will output 1.1773 Kilobyte
```

```c#
long number = 1234500;
Sizer.SuffixName(number, 4, false)
// This will output Kilobyte
```



-------
### To use this with files is even as easy.

```c#
Sizer.Suffix("C:\\Path\\To\\File\\file.txt"); 
// This will output the converted size of the file.
```

or 

```c#
Sizer.SuffixName("C:\\Path\\To\\File\\file.txt"); 
// This will output the converted size of the file.
```

-------

### You can even get the complete size of multiple files

```c#
List<string> files = new List<string>() {
            "C:\\Path\\To\\File\\file1.txt",
            "C:\\Path\\To\\File\\file2.txt",
            "C:\\Path\\To\\File\\file3.txt"
        };
Sizer.AllSuffix(files); 
// This will output the size of all the files in the list
```

or

```c#
List<string> files = new List<string>() {
            "C:\\Path\\To\\File\\file1.txt",
            "C:\\Path\\To\\File\\file2.txt",
            "C:\\Path\\To\\File\\file3.txt"
        };
Sizer.AllSuffixName(files); 
// This will output the size of all the files in the list
```

-------

