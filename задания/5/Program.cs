Console.Clear();
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int countArr = 10;
int[] GetRandom(int countForArr){
    int[] arr = new int[countForArr];
    for(int i=0; i<countForArr; i++){
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
int GetNum(int[] arr){
    string stringArr = "";
    int num = 0;
    int numTemp = 0;
    for(int i=0; i<arr.Length; i++){
       
        if((arr[i]%2) == 0){
            num++;
        }
    }
    return num;
}
string PrintArr(int[] arr){
    string result = "";
    for(int i = 0; i<arr.Length; i++){
        if(result == ""){
            result = arr[i].ToString();
        } else {
            result += ", "+arr[i].ToString();
        }
    }
    result = "["+result+"]";
    return result;
}

int[] arr = GetRandom(countArr);
Console.WriteLine(GetNum(arr)+"---"+PrintArr(arr));
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
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int countArr = 10;
int[] GetRandom(int countForArr){
    int[] arr = new int[countForArr];
    for(int i=0; i<countForArr; i++){
        arr[i] = new Random().Next(-20, 10);
    }
    return arr;
}
int GetNum(int[] arr){
    int num = 0;
    for(int i = 0; i<arr.Length; i++){
         if((i%2) == 1){
            //Console.Write((arr[i])+"-----");
            num += arr[i];
            //Console.Write("|"+num+"|--/");
        }
    }
    return num;
}
string PrintArr(int[] arr){
    string result = "";
    for(int i = 0; i<arr.Length; i++){
        
        if((i%2) == 1){
            if(result == ""){
                result = arr[i].ToString();
            } else {
                result += ", "+arr[i].ToString();
            }
        }
    }
    result = "["+result+"]";
    return result;
}

int[] arr = GetRandom(countArr);
Console.WriteLine(GetNum(arr)+"---"+PrintArr(arr));

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

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
int countArr = 10;
int[] GetRandom(int countForArr){
    int[] arr = new int[countForArr];
    for(int i=0; i<countForArr; i++){
        arr[i] = new Random().Next(1, 100);
        Console.WriteLine(arr[i]);
    }
    return arr;
}

int GetMin(int[] arr){
    int min = arr[0];
    for(int i = 0; i<arr.Length; i++){
        if(min > arr[i]){
            min = arr[i];
        }
    }
    return min;
}

int GetMax(int[] arr){
    
    int max = arr[0];
    for(int i = 0; i<arr.Length; i++){
        if(max < arr[i]){
            max = arr[i];
        }
    }
    return max;
}
int GetRes(int num1, int num2){
    
    return num2 - num1;
}
int[] arr =GetRandom(countArr);
Console.WriteLine("Минимальное - "+GetMin(arr)+" Максимальное - "+GetMax(arr)+" Разница - "+GetRes(GetMin(arr), GetMax(arr)));

*/




string[,] table = new string[2, 3];
table[0, 0]  = "1";
//Console.WriteLine(table.Length);
for(var i = 0; i<table.GetLength(0); i++){
    for(var k = 0; k<table.GetLength(1); k++){

        Console.Write(table[i, k]);
    }
        Console.WriteLine();
}