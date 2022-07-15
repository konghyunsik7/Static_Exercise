//Create a new console app called StaticExercise.

//Now create a static class called TempConverter.The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

//Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!

using Static_Exercise;

Console.WriteLine("Please Enter the Celsius Temp: ");
double userInput= double.Parse(Console.ReadLine());
double celcius = TempConvertor.FahrenheitToCelsius(userInput);


Console.WriteLine("Sweeeeeet! Now please enter the Fahrenheit temp: ");
double userInput2 = double.Parse(Console.ReadLine());
double fahrenheit = TempConvertor.CelsiusToFahrenheit(userInput2);
Console.WriteLine();

Console.WriteLine($"Here are the temp for Celsius and Fahrenheit:{celcius} & {fahrenheit}");




