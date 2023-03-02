// Задача 2 (66): Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// 1:


int M;
int N;
int Summa = 0;
Console.Write("Enter M: ");
M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = M; i <= N; i++)
 Summa += i;
Console.WriteLine(Summa);
for (int i = N; i <= M; i++)
    Summa += i;
Console.WriteLine(Summa);



// 2:

int M = SetNumbers("Enter M: ");
int N = SetNumbers("Enter N: ");
int Temp = M;

if (M > N) 
{
  M = N; 
  N = Temp;
}

SumElRange(M, N, Temp = 0);

void SumElRange(int M, int N, int Sum)
{
  Sum = Sum + N;
  if (N <= M)
  {
    Console.Write($"{Sum}");
    return;
  }
  SumElRange(M, N - 1, Sum);
}

int SetNumbers(string number) 
{
  Console.Write(number);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}
