Console.Clear();
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int countArr = 10;
int methodRandom(int countForArr){
    int[] arr = new int[countForArr];
    string stringArr = "";
    int num = 0;
    int numTemp = 0;
    for(int i=0; i<countForArr; i++){
        numTemp = 0;
        arr[i] = new Random().Next(100, 1000);
        stringArr = arr[i].ToString();
        Console.Write((arr[i])+"-----");
        for(int k = 0; k<stringArr.Length; k++){
            if(Convert.ToInt32(new string(stringArr[k], 1)) == 0){
                continue;
            }
            if((stringArr[k]%2) == 0){
                num++;
                numTemp++;
            }
        }
        Console.WriteLine(numTemp);
        Console.WriteLine(" ");
    }
    return num;
}

Console.WriteLine(methodRandom(countArr));
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
int methodRandom(int countForArr){
    int num = 0;
    int[] arr = new int[countForArr];

    for(int i=0; i<countForArr; i++){
        arr[i] = new Random().Next(-20, 10);
    }
    for(int i = 0; i<arr.Length; i++){
         if((i%2) == 1){
            Console.Write((arr[i])+"-----");
            num += arr[i];
            Console.Write("|"+num+"|--/");
        }
    }
    return num;
}
Console.WriteLine(methodRandom(countArr));

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
int[] methodRandom(int countForArr){
    int[] arr = new int[countForArr];
    for(int i=0; i<countForArr; i++){
        arr[i] = new Random().Next(1, 100);
        Console.WriteLine(arr[i]);
    }
    return arr;
}

int methodMin(int[] arr){
    int min = arr[0];
    for(int i = 0; i<arr.Length; i++){
        if(min > arr[i]){
            min = arr[i];
        }
    }
    return min;
}

int methodMax(int[] arr){
    
    int max = arr[0];
    for(int i = 0; i<arr.Length; i++){
        if(max < arr[i]){
            max = arr[i];
        }
    }
    return max;
}
int methodRes(int num1, int num2){
    
    return num2 - num1;
}
int[] arr = methodRandom(countArr);
Console.WriteLine("Минимальное - "+methodMin(arr)+" Максимальное - "+methodMax(arr)+" Разница - "+methodRes(methodMin(arr), methodMax(arr)));

*/

