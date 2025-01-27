Write the program `FileComparison` that compares two files. Two files have been provided for you, **Quote.txt** and **Quote.docx**.

> Note: you will not be able to see the **Quote.docx** file.

Next write the file comparison application that displays the sizes of the two files as well as the ratio of their sizes to each other. To discover a file’s size, you can create a `System.IO.FileInfo` object using statements such as the following, where **FILE_NAME** is a string that contains the name of the file, and size has been declared as an integer:

```
      FileInfo fileInfo = new FileInfo(FILE_NAME);
      size = fileInfo.Length;
```

Your program's output should look like the following:

```
The size of the Word file is FILE_SIZE
and the size of the Notepad file is FILE_SIZE
The Notepad file is x% of the size of the Word file
```
