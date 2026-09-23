Console.WriteLine("What was the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write ("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

// do the output.
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: "+ fuelCost.ToString("C"));


Console.WriteLine("How many people are going? ");
int howManyPeopleGoing = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("How many pizzas? ");
int howManyPizzas = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("What is the price per Pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//do the math

const int slicesPerPizza = 8;

double totalSlices = howManyPizzas * slicesPerPizza;

double slicesPerPerson = totalSlices / howManyPeopleGoing;

double pizzaCost = howManyPizzas * pricePerPizza;


Console.WriteLine("Totalslices " + totalSlices.ToString());
Console.WriteLine("Slicesperperson " + slicesPerPerson.ToString("F2"));
Console.WriteLine("Pizzacost " + pizzaCost.ToString("F2"));


Console.WriteLine("What are the hourly hours worked this week? ");
int hourlyWorked = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("What is the hourly rate? ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

//do the math

const double taxRate = 18;

double grossPay = hourlyWorked * hourlyRate;

double taxWithheld = grossPay * taxRate;

double takeHomepay = grossPay - taxWithheld;

Console.WriteLine("GrossPay " + grossPay.ToString("C"));
Console.WriteLine("Tax Withheld " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay " + takeHomepay.ToString("C"));



double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal/howManyPeopleGoing;

double takeHomepayPerHour = takeHomepay/hourlyRate;

double hoursMustWorked = costPerPerson/takeHomepayPerHour;

Console.WriteLine("tripTotal " + tripTotal.ToString());
Console.WriteLine("Cost Per person " + costPerPerson.ToString());
Console.WriteLine("Take Home Pay per Hour" + takeHomepayPerHour.ToString());
Console.WriteLine("Hours you must work " + hoursMustWorked.ToString());

