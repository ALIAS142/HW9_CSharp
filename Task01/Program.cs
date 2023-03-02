// Задача (1) 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// System.Console.WriteLine("Enter number:  ");
// int numN = int.Parse(Console.ReadLine());

// int numK = 1;

// while (numK <= numN)
// {
//      System.Console.WriteLine(Convert.ToInt32(numN));
    
//      numN = numN - 1;
// }
  

  	Console.WriteLine("Enter number N:   ");
	int number = int.Parse(Console.ReadLine());
	

	
	void NaturalNumbers(int number)
	{
	    if (number < 0) 
	    {
	        Console.Write($"{number} is not a natural"); 
	        return;
	    }
	    else if (number == 0) return;
	    Console.Write(number + " ");
	    NaturalNumbers(number - 1);
	}
	

	NaturalNumbers(number);
