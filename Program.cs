//Int32
const string promptId = "Please enter your ID: ";
Console.Write(promptId);

string? idString;
idString = Console.ReadLine();
int id;

bool isIdInt = int.TryParse(idString, out id);
Console.WriteLine("ID is an int? " + isIdInt + " ID: " + id);

// Double
const string promptDouble = "\nPlease enter the price of gas per gallon: ";
Console.WriteLine(promptDouble);

string? gasPrice;
gasPrice = Console.ReadLine();
double price;

bool isPriceDouble = double.TryParse(gasPrice, out price);
Console.WriteLine("Gas price is double? " + isPriceDouble + " Price/gallon: " + price);

// DateTime
const string promptDate = "Please enter todays date: ";
Console.Write(promptDate);

string? dateString;
dateString = Console.ReadLine();
DateTime dt;

bool isDate = DateTime.TryParse(dateString, out dt);
Console.WriteLine("User input is a date? " + isDate + " The date: " + dt);

/*
 * PART 2
 */

int x = 10;
int y = x;

Console.WriteLine("x = " + x + " y = " + y);
Console.WriteLine("x == y? " + (x == y));

y = 5;
Console.WriteLine("x = " + x + " y = " + y);
Console.WriteLine("x == y? " + (x == y));


RefType r1 = new RefType() { a = 1, b = 2 };
RefType r2 = new RefType() { a = 1, b = 2 };
RefType r3 = r1;
r1.a = 55;

Console.WriteLine("r1 == r2? " + (r1 == r2));
Console.WriteLine("r1 == r3? " + (r1 == r3));
Console.WriteLine("r1.a = " + r1.a);
Console.WriteLine("r3.a = " + r3.a);
class RefType {
    public int a;
    public int b;
}