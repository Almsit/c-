Console.Clear();
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("Количество строк");
bool num1 = int.TryParse(Console.ReadLine(), out int numberInt1);
Console.WriteLine("Количество столбцов");
bool num2 = int.TryParse(Console.ReadLine(), out int numberInt2);


bool Valid(bool n1, bool n2, int n3, int n4){
    if(n1 != true || n2 != true){
        Console.WriteLine("Число неверное");
        return false;
    }
    if(n3 == 0 || n4 == 0){
        
        Console.WriteLine("Число должгл быть больше 0");
        return true;
    }
    return true;
}
bool valid =  Valid(num1, num2, numberInt1, numberInt2);

if(!valid){
    return;
}



double[,] GetArr(int rows, int cols)
{
    double[,] array = new double[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return array;
}

void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


PrintArr(GetArr(numberInt1, numberInt2));
*/

//Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
/*
Console.WriteLine("Введите кол-во строк");
bool number1 = int.TryParse(Console.ReadLine(), out int numberInt1);
Console.WriteLine("Введите кол-во столбцов");
bool number2 = int.TryParse(Console.ReadLine(), out int numberInt2);
Console.WriteLine("Введите число для поиска");
bool number3 = int.TryParse(Console.ReadLine(), out int numberInt3);

bool Valid(bool n1, bool n2, bool n3, int n4, int n5, int n6){
    if(n1 != true || n2 != true || n3 != true){
        Console.WriteLine("Число неверное");
        return false;
    }
    if(n4 == 0 || n5 == 0){
        
        Console.WriteLine("Число должгл быть больше 0");
        return true;
    }
    return true;
}
bool valid =  Valid(number1, number2, number3, numberInt1, numberInt2, numberInt3);

if(!valid){
    return;
}


int[,] GetArr(int numberInt1, int numberInt2){
    
    int [,] array = new int [numberInt1 ,numberInt2];
    for (int i = 0; i < numberInt1; i++){
        for (int j = 0; j <numberInt2; j++){
            array [i,j] = new Random().Next(1, 5);
        }   
    }
    return array;
}

int FindCountNum(int[,] array, int numberInt3){
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(array[i,j] == numberInt3){
                k++;
                break;
            }
        }   
    }
    if(k == 0){
        k = 1;
    }
    return k;
}

string[] FindNum(int[,] array, int k){
    string[] array2 = new string[k];
    k = 0;
    array2[k] = "Индекс не найден";
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(array[i,j] == numberInt3){
                array2[k] = "Строка "+i+" Индекс "+j;
                k++;
                break;
            }
        }
    }
                
    return array2;
}

void PrintArr(int[,] array, string[] array2){
    
    for (int i = 0; i < array2.Length; i++){
        Console.Write(" [");
        Console.Write(array2[i] + " ");
        Console.Write("]");
        Console.WriteLine(""); 
    }
    
    Console.WriteLine("------------------------------------"); 
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write(" Строка "+i+" [");
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

int[,] arr = GetArr(numberInt1, numberInt2);
PrintArr(arr, FindNum(arr,FindCountNum(arr, numberInt3)));



*/
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

Console.WriteLine("Введите кол-во строк");
bool number1 = int.TryParse(Console.ReadLine(), out int numberInt1);
Console.WriteLine("Введите кол-во столбцов");
bool number2 = int.TryParse(Console.ReadLine(), out int numberInt2);

bool Valid(bool n1, bool n2, int n3, int n4){
    if(n1 != true || n2 != true){
        Console.WriteLine("Число неверное");
        return false;
    }
    if(n3 == 0 || n4 == 0){
        
        Console.WriteLine("Число должно быть больше 0");
        return true;
    }
    return true;
}
bool valid =  Valid(number1, number2, numberInt1, numberInt2);

if(!valid){
    return;
}


int[,] GetArr(int numberInt1, int numberInt2){
    
    int [,] array = new int [numberInt1 ,numberInt2];
    for (int i = 0; i < numberInt1; i++){
        for (int j = 0; j <numberInt2; j++){
            array [i,j] = new Random().Next(0, 100);
        }   
    }
    return array;
}


double[] GetSum(int[,] array){
    double[] arr = new double[array.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i,j];
        }   
        arr[i] = sum/array.GetLength(1);
    }
    
    return arr;
}


void PrintArr(int[,] array, double[] arr_sum){
    

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        
        Console.Write(" Среднее арифметическое -  "+arr_sum[i]);
        Console.WriteLine(""); 
    }
}

int[,] arr = GetArr(numberInt1, numberInt2);
PrintArr(arr, GetSum(arr));

*/