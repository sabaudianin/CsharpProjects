// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();

using System.ComponentModel.DataAnnotations;

string? readResult;
string role ="";
bool validEntry = false;

do{
Console.WriteLine("Enter your Role(Human,Bot,Dog)");
readResult = Console.ReadLine();

if(readResult != null)
{
   role = readResult.Trim();
}

if(role.ToLower() == "human" || role.ToLower() == "bot" || role.ToLower() == "dog"  )
{
   validEntry = true;
}
else{
   Console.WriteLine($"the role \"{role}\" is not valid ");
}

}while(validEntry == false);

Console.WriteLine($"Your input value ({role}) has been accepted.");
readResult = Console.ReadLine();


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int stringsCount = myStrings.Length;

string myString = "";
int periodLocation=0;

for(int i =0; i<stringsCount;i++){
   myString=myStrings[i];
   periodLocation = myString.IndexOf(".");

   string mySentence;

   while(periodLocation !=-1){
mySentence = myString.Remove(periodLocation);

myString = myString.Substring(periodLocation +1);

myString = myString.TrimStart();

periodLocation = myString.IndexOf(".");
Console.WriteLine(mySentence);
   }
 mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}