/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write($"Введи число М(количество чисел): ");
int M = int.Parse(Console.ReadLine());
int[] Massiv = new int[M];

void Numbers(int M)
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    Massiv[i] = int.Parse(Console.ReadLine());
  }
}
int Result(int[] Massiv)
{
  int count = 0;
  for (int i = 0; i < Massiv.Length; i++)
  {
    if(Massiv[i] > 0 ) count++; 
  }
  return count;
}

Numbers(M);
Console.WriteLine($"Количество чисел больше 0: {Result(Massiv)} ");
