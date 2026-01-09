//strings in c# are used to store a sequence of characters.
//strings are reference types and are immutable.
//Strings are enclosed in double quotes.
using System;
string name="Wipro";
Console.WriteLine("company name:"+name);
//strings are two types
//1.mutable strings
//2.immutable strings
//mutable strings can be changed after creation
//creating a mutable string using StringBuilder 

//StringBuilder mutableString=new StringBuilder("Hello");
//appending text to mutable string
//mutableString.Append(" World");
//.toString() method to convert StringBuilder to string
//Console.WriteLine("Mutable String:"+mutableString.ToString());

//difference between stringbuilder and stringbuffer
//stringbuilder is not thread-safe whereas stringbuffer is thread-safe
//stringbuilder is faster than stringbuffer due to lack of synchronization  
//creating a stringbuffer
//stringbuffer sb=new stringbuffer("Hello");
//appending text to stringbuffer
////sb.append(" World");
//.toString() method to convert stringbuffer to string  
//Console.WriteLine("StringBuffer:"+sb.toString());