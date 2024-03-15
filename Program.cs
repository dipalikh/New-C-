// See https://aka.ms/new-console-template for more information

//Task 1: Name Input Program

Console.Write("Please Enter your name:");  //Ask the user to enter their name

string userName = Console.ReadLine();
// Create a string variable and get user name from the keyboard and store it in the variable

Console.WriteLine("Hello, " + userName + "!");
// Print the userName,which will display the input value

//Task 2: Age Verification and Terms of Service Agreement Program

Console.Write("Please Enter your age:");  //Ask the user to enter their age

int age = Convert.ToInt32(Console.ReadLine());// Print the userage,which will display the input value
if ( age < 18) 
{
  Console.WriteLine("You must be 18 years old to use this service.");
}
 //entered age is below 18, display the message:nnn
//else if ( age >= 18)
else 
{ 
  Console.WriteLine("You are above 18 and can move further to login");
  Console.WriteLine("Do you agree with the terms of service? yes/no");
  string response = Console.ReadLine();
if (response.ToLower() == "no")
{
  Console.WriteLine ("You must agree to the terms of service to continue.");
}
else if (response.ToLower() == "yes")
{
  Console.WriteLine("Thank you, followed by a summary of the provided information: user name,user age Accepted TO: yes.");
}
else{
  Console.WriteLine("Invalid input");
}
}
//entered age is 18 or above, proceed to ask: "Do you agree with the terms of service? yes/no"
//Task 3: Variable Names and Types

 Console.WriteLine("Enter the name of the grocery item:");//Wait for user to enter the grocery items
string a = Console.ReadLine(); 

Console.WriteLine("Enter the quantity:");//Wait for user to enter the quantity of grocery items
string b = Console.ReadLine(); 

Console.WriteLine("Enter the weight in kilograms:");//Wait for user to enter the grocery weight in kilograms
string c = Console.ReadLine(); 

Console.WriteLine("Enter the price per unit:");//Wait for user to enter the price per unit of grocery items
string d = Console.ReadLine();

Console.WriteLine($"Item: {a}, Quantity: {b}, Weight: {c} kg, Price: ${d}");

//Task 4: Simple Calculator Program

 //Ask user to provide a mathematical operator (+,-,/,*)

Console.Write("Enter the first number:"); //Wait for user to enter the first number
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number:"); //Wait for user to enter the second number
int num2= Convert.ToInt32(Console.ReadLine());

// int num1 =number1;
// int num2 =number2;

Console.WriteLine(num1+num2); //Run the math operation and display the result

Console.WriteLine(num1-num2); // Run the math operation and display the result

Console.WriteLine(num1/num2); // Run the math operation and display the result

Console.WriteLine(num1*num2); // Run the math operation and display the result















    
    


