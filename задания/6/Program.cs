Console.Clear();
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
 Console.WriteLine("Введите числа через пробел для создания массива");
string[] stringArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);



bool Valid(string[] stringArr){
    
    for(int i = 0; i<stringArr.Length; i++){
        //int numArr = Convert.ToInt32(new string(stringArr[i], 2));
        bool number = int.TryParse(stringArr[i], out int numberInt);
        if(number != true){
            Console.WriteLine("Массив задан не верно");
            return false;
        }
    }
    return true;
}
bool valid = Valid(stringArr);
if(!valid){
    return;
}

int GetResult(string[] stringArr){
    int num = 0;
    int numArr = 0;
     for(int i = 0; i<stringArr.Length; i++){
        //Console.WriteLine(stringArr[i]);
        numArr = Convert.ToInt32(stringArr[i]);
        if(numArr > 0){
            num++;
        }
    }
    return num;
}
Console.WriteLine(GetResult(stringArr));

*/
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double[,] coefficientis = new double[2, 2];
double[] num = new double[2];

void GetCoefficients(){
  for (int i = 0; i < coefficientis.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coefficientis.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coefficientis[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
double[] GetResult(double[,] coefficientis)
{
  num[0] = (coefficientis[1,1] - coefficientis[0,1]) / (coefficientis[0,0] - coefficientis[1,0]);
  num[1] = num[0] * coefficientis[0,0] + coefficientis[0,1];
  return num;
}
void PrintCoefficients(double[,] coefficientis)
{
  if (coefficientis[0,0] == coefficientis[1,0] && coefficientis[0,1] == coefficientis[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coefficientis[0,0] == coefficientis[1,0] && coefficientis[0,1] != coefficientis[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    GetResult(coefficientis);
    Console.Write($"\nТочка пересечения прямых: ({num[0]}, {num[1]})");
  }
}
GetCoefficients();
PrintCoefficients(
*/