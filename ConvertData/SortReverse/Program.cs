﻿// string[] pallets =  ["B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Array.Resize(ref pallets,3);
// Console.WriteLine($"Resizing 3 .... count:{pallets.Length}");
// foreach(var pallet in pallets){
//     Console.WriteLine(pallet);
// }


// string value="a1b2c3d4";
// char[] valueArray=value.ToCharArray();
// foreach(var item in valueArray){
//     Console.WriteLine(item);
// }

// string result = new string(valueArray);
// Console.WriteLine(result);

// string spitArray=string.Join("-",valueArray);
// Console.WriteLine(spitArray);

// string[] items = spitArray.Split("-");
//  Console.WriteLine(items);
// foreach(string item in items){
//     Console.WriteLine(item);
// }


// string pangram = "The quick brown fox jumps over the lazy dog";


// string[] message = pangram.Split(' ');

// string[] newMessage = new string[message.Length];

// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }


// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(",");
Array.Sort(orders);

foreach (var order in orders)
{
    if (order.Length == 4)
    {
        Console.WriteLine($"-{order}");
    }
    else
    {
        Console.WriteLine($"-{order} \t-ERROR");
    }
}