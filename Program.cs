using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("<<=============Part 1=============>>");
        // Convert pounds to kilograms
        Console.WriteLine("Enter a value in pounds (lbs): ");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds * 0.453592;
        Console.WriteLine($"Pounds: {pounds} lbs");
        Console.WriteLine($"Kilograms: {kilograms} kg");

        Console.WriteLine("=================================");

        // Convert miles to kilometers
        Console.WriteLine("Enter a value in miles (mi): ");
        double miles = double.Parse(Console.ReadLine());
        double kilometers = miles * 1.60934;
        Console.WriteLine($"Miles: {miles} mi");
        Console.WriteLine($"Kilometers: {kilometers} km");

        Console.WriteLine("=================================");

        // Convert Fahrenheit to Celsius
        Console.WriteLine("Enter a value in Fahrenheit (°F): ");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Fahrenheit: {fahrenheit} °F");
        Console.WriteLine($"Celsius: {celsius} °C");

        Console.WriteLine("=================================");

        // CALCULATE AVERAGE AGE OF STUDENTS

        int[] ages = new int[10];
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            sum += ages[i];
        }

        double averageAge = (double)sum / 10;

        Console.WriteLine("Ages of all students:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Student {i + 1}: {ages[i]} years old");
        }
        Console.WriteLine($"Average age of students: {averageAge}");

        Console.WriteLine("=====================================================");

        // Output fantasy story
        string character1 = "Alice";
        string character2 = "Bob";
        string character3 = "Charlie";
        string character4 = "Daisy";
        string character5 = "Ethan";
        string equipment = "Sword of Destiny";
        string item = "Amulet of Power";
        string ability = "Fireball";
        string story = $"Once upon a time, in a world of magic and adventure, there were five heroes: {character1}, {character2}, {character3}, {character4}, and {character5}. " +
            $"Armed with their {equipment}s and wielding incredible {ability} abilities, they embarked on a quest to find the legendary {item}. " +
            $"Their journey was filled with perilous challenges and unexpected twists, but through their bravery and determination, they overcame every obstacle and saved the day.";
        Console.WriteLine(story);

        Console.WriteLine("================================================");

        Console.WriteLine("<<=============Part 2=============>>");
        // Print number pattern 1
        Console.WriteLine("Enter a number for number pattern 1: ");
        int number1 = int.Parse(Console.ReadLine());
        if (number1 <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            for (int i = 1; i <= number1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine("=================================");

        // Print number pattern 2
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            int sum1 = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
                sum1 += i;
                if (i != number)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Output: {sum1}");
        }

        Console.WriteLine("=================================");

        // Print number pattern 3
        Console.WriteLine("Enter a number for number pattern 3: ");
        int number3 = int.Parse(Console.ReadLine());
        if (number3 <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            for (int i = 1; i <= number3; i++)
            {
                for (int j = 1; j <= number3 - i + 1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}