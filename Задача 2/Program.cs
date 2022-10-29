/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double[,] Coordinate = new double[2, 2];
double[] CrossPoint = new double[2];

void InputCoordinate()
{
  for (int i = 0; i < Coordinate.GetLength(0); i++)
  {
    Console.Write($"Введите координаты для {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < Coordinate.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      Coordinate[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] Coordinate)
{
  CrossPoint[0] = (Coordinate[1,1] - Coordinate[0,1]) / (Coordinate[0,0] - Coordinate[1,0]);
  CrossPoint[1] = CrossPoint[0] * Coordinate[0,0] + Coordinate[0,1];
  return CrossPoint;
}

void OutputResponse(double[,] Coordinate)
{
  if (Coordinate[0,0] == Coordinate[1,0] && Coordinate[0,1] == Coordinate[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (Coordinate[0,0] == Coordinate[1,0] && Coordinate[0,1] != Coordinate[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(Coordinate);
    Console.Write($"\nТочка пересечения прямых: ({CrossPoint[0]}, {CrossPoint[1]})");
  }
}

InputCoordinate();
OutputResponse(Coordinate);