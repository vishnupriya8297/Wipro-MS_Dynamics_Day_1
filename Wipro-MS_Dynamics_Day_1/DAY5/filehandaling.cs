//creating a file using File.Create() method in default directory
string filePath = "demo.txt";
using (FileStream fs = File.Create(filePath))
{
    // File created successfully
    if (File.Exists(filePath))
    {
        Console.WriteLine("File created successfully: " + filePath);
    }
}

//Writing to the file using StreamWriter class
using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("Hello, this is a demo file created today.");
    sw.WriteLine("This file is created to demonstrate file handling in C#.");
}
using (StreamReader sr = new StreamReader(filePath))
{
    string content = sr.ReadToEnd();
    Console.WriteLine("File Content:");
    Console.WriteLine(content);
}
//below are the types of modes while working with files in C#:
//read: Opens the file for reading only. An exception is thrown if the file does not exist.
//write: Opens the file for writing only. If the file exists, it is overwritten. If the file does not exist, a new file is created.
//append: Opens the file for writing only. If the file exists, the write operation appends data to the end of the file. If the file does not exist, a new file is created.
//open: Opens the file if it exists. An exception is thrown if the file does not exist.
//openorcreate: Opens the file if it exists; otherwise, a new file is created.
//truncate: Opens the file for writing only and truncates the file to zero bytes. An exception is thrown if the file does not exist.
//These modes are specified using the FileMode enumeration when creating a FileStream object.