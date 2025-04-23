// string first = "Hello";
// string second = "World!";

// string result = string.Format("{1} {0}",first,second);
// Console.WriteLine(result);

// string res2 = string.Format("{0} {0} {0}",first,second);
// Console.WriteLine(res2);

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price:{price:C} Save:{discount:C}");

// decimal measure = 123456.78912m;
// Console.WriteLine($"Measurement: {measure:N4}");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");


// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");

// Console.WriteLine($"Miejsca po przecinku - {productShares:N3}");
// Console.WriteLine($"Waluta - {subtotal:C}");
// Console.WriteLine($"Procenty po przecinku - {taxPercentage:P2}");
// Console.WriteLine($"Waluta - {total:N}");

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(9,'-'));
// Console.WriteLine(input.PadRight(11,'+'));

// string paymentId = "769C";
// string payeeName = "John Doe";
// string paymentAmount = "$5,000.00";
// var formattedLine = paymentId.PadRight(6) + payeeName.PadRight(24) + paymentAmount.PadLeft(10);

// Console.WriteLine(formattedLine);



string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear Mr. {customerName}");
Console.WriteLine($"As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"{newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
comparisonMessage =($"{currentProduct}  {currentReturn:P2}".PadRight(20))+($"{currentProfit:C}".PadLeft(20));

// Your logic here

Console.WriteLine(comparisonMessage);