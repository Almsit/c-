
Console.Clear();


Console.WriteLine("Введите Число N");
bool number1 = int.TryParse(Console.ReadLine(), out int numberInt1);
Console.WriteLine("Введите Число M");
bool number2 = int.TryParse(Console.ReadLine(), out int numberInt2);

bool Valid(bool n1, bool n2, int n3, int n4){
    if(n1 != true || n2 != true){
        Console.WriteLine("Число неверное");
        return false;
    }
    return true;
}
bool valid =  Valid(number1, number2, numberInt1, numberInt2);

if(!valid){
    return;
}




//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
/*

int GetCountArr(int n, int m)
{
    int k = 0;
    for(int i=n; i<=m; i++){
        k++;
    }
    return k;
}

int[] GetArr(int n, int m, int k)
{   
    int[] arr = new int[k];
    int j = 0;
    for(int i=n; i<=m; i++){
        arr[j] = i;
        j++;
    }
    return arr;
}
void PrintArr(int[] array){
     Console.Write("[ ");
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }   
        Console.Write("]");
        
}
PrintArr(GetArr(numberInt1, numberInt2, GetCountArr(numberInt1, numberInt2)));









*/
//
//
//рекурсия
/*
    Console.WriteLine("Рекурсия");

    int GetCountArr(int n, int m)
    {
        int k = 0;
        for(int i=n; i<=m; i++){
            k++;
        }
        return GetArr(n, m, k);
    }
    int GetArr(int n, int m, int k)
    {   
        for(int i=n; i<=m; i++){
            PrintArr(i);
        }
        return 1;
    }
    void PrintArr(int num){
        Console.Write(num);
    }
GetCountArr(numberInt1, numberInt2);
*/

//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


/*
int GetCountArr(int n, int m)
{
    int k = 0;
    for(int i=n; i<=m; i++){
        k++;
    }
    return k;
}

int[] GetArr(int n, int m, int k)
{   
    int[] arr = new int[k];
    int j = 0;
    for(int i=n; i<=m; i++){
        arr[j] = i;
        j++;
    }
    return arr;
}


int GetSum(int[] array)
{   
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        sum += array[i];
    }
    return sum;
}
void PrintArr(int[] array, int sum){
     Console.Write("[ ");
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }   
        Console.Write("]");
        
        Console.Write(" - Сумма чисел "+sum);
        
}
PrintArr(GetArr(numberInt1, numberInt2, GetCountArr(numberInt1, numberInt2)), GetSum(GetArr(numberInt1, numberInt2, GetCountArr(numberInt1, numberInt2))));
*/
//
//
//
/*
Console.WriteLine("Рекурсия");

    int GetCountArr(int n, int m)
    {
        int k = 0;
        for(int i=n; i<=m; i++){
            k++;
        }
        return GetArr(n, m, k);
    }
    int GetArr(int n, int m, int k)
    {   
        
        int sum = 0;
        for(int i=n; i<=m; i++){
            
            sum = GetSum(i, sum);
            PrintArr(i, 0);
        }
        
        Console.Write("Сумма чисел - "+sum);

        return 1;
    }
    int GetSum(int n, int sum){
        return sum+n;
    }
    void PrintArr(int num, int m){
        Console.Write(num);
    }
GetCountArr(numberInt1, numberInt2);
*/
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n){
    if (m == 0) {
        return n + 1;
    } else if (n == 0 && m > 0) {
        return Akkerman(m - 1, 1);
    } else {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
void PrintValue(int m, int n){
    Console.Write(Akkerman(m, n)); 
}
PrintValue(numberInt1,numberInt2);;

*/