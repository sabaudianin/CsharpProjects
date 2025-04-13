string[] orders=new string[3];

orders[0]="Order 1";
orders[1]="Order 2";
orders[2]="Order 3";


orders[1]="New Order 2";
Console.WriteLine(orders[1]);

string[] idOrder=["1","2","3"];
string[] someOrder={"1","2","3"};
Console.WriteLine(idOrder[1]);

Console.WriteLine($"array length:{idOrder.Length}");


string[] names={"John","Jane","Jack"};
Console.WriteLine($"Array Names length:{names.Length}");

foreach(string name in names){
    Console.WriteLine(name);
}

int [] inventory={100,200,300,400,500};

int bin=0;
int sum=0;
foreach(int item in inventory){
    Console.WriteLine(item);  
    sum+=item;  
    bin++;
    Console.WriteLine($"Bin {bin} has {item} items and temp {sum}");    
}


Console.WriteLine($"Total inventory: {sum}");