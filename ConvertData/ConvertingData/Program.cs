﻿// int first = 2;
// string second = "4";

// string result = first + second;

// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;

// Console.WriteLine($"decimal {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"Decimal : {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int : {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");

// int first = 5;
// int second = 7;

// string message = first.ToString() + second.ToString();

// Console.WriteLine(message);


// string first = "5";
// string second = "7";

// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";

// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// int value = (int)1.5m;
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m);
// Console.WriteLine(value2);

// string value = "bad";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement : {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement");
// }

// Console.WriteLine($" Measurment {result +50}");



// string value2 = "bad";
// int result2 = 0;
// if (int.TryParse(value2, out result2))
// {
//    Console.WriteLine($"Measurement: {result2}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// if (result2 > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result2}");


// string[] values = { "12,3", "45", "ABC", "11", "DEF" };

// string msg = "";
// decimal total = 0m;

// foreach (var value in values)
// {
//     decimal number;
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     }
//     else
//     {
//         msg += value;
//     }
// }

// Console.WriteLine($"Message: {msg}");
// Console.WriteLine($"Total: {total}");


int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)

int result1=Convert.ToInt32(value1/value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2=value2/(decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3/value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");