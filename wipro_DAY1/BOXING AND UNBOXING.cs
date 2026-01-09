//boxing is the process of converting a value type to the type object.
//unboxing is the reverse process of converting an object to a value type.
using System;
int num = 42; // value type
object boxedNum = num; // boxing
Console.WriteLine("Boxed value: " + boxedNum);
int unboxedNum = (int)boxedNum; // unboxing
Console.WriteLine("Unboxed value: " + unboxedNum);

