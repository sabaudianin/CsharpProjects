// string message = "Find what is (inside the parentheses)";
// int opening = message.IndexOf('(');
// int closing = message.IndexOf(')');


// Console.WriteLine($"{opening} , {closing}");
// opening+=1;
// int length = closing - opening;
// Console.WriteLine(message.Substring(opening,length));


// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"first: {first_h}, last: {last_h}");

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";

// int opening = message.LastIndexOf('(');

// opening+=1;
// int closing = message.LastIndexOf(')');
// int length = closing - opening;
// Console.WriteLine(message.Substring(opening,length));

// string message = "(What if) there are (more than) one (set of parentheses)?";

// while (true)
// {
//     int opening = message.IndexOf('(');
//     if (opening == -1) break;

//     opening += 1;
//     int closing = message.IndexOf(')');
//     int length = closing - opening;

//     Console.WriteLine(message.Substring(opening, length));

//     message = message.Substring(closing + 1);
// }

// string message = "Hello, world!";
// char[] chars = {'a','e','i'};

// int index = message.IndexOfAny(chars);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");


// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }


// string data = "12345John Smith          5000  3  ";

// string updatedData = data.Remove(5,20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--"," ");
// message = message.Replace("-","");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan="<span>";
const string closeSpan="</span>";

int opening= input.IndexOf(openSpan);
int closing = input.IndexOf(closeSpan);
opening+=openSpan.Length;
int length= closing - opening;
quantity=input.Substring(opening,length);
output=input;
output = output.Replace("<div>","");
output = output.Replace("</div>","");
output = output.Replace("&trade;","&reg;");



// Your work here

Console.WriteLine(quantity);
Console.WriteLine(output);