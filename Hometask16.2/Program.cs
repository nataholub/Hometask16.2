using System;

try
{
    int inputNumber;
    
    Console.Write("Enter the number: ");
    try
    {
        inputNumber = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input.Please enter numeric values only.");
        return;
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number is too large or too small for an int type.");
        return;
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("Input value is missing.");
        return;
    }
    catch (IOException)
    {
        Console.WriteLine("Console error.");
        return;
    }
    catch (OutOfMemoryException)
    {
        Console.WriteLine("Insufficient memory.");
        return;
    }

    Console.WriteLine("The entered value is a number.");
}
catch (Exception ex)
{
    Console.WriteLine($"Сталася помилка: {ex.Message}");
}
