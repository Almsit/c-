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
        stringArr = arr[i].ToString();
        numTemp = 0;
        //Console.Write((arr[i])+"-----");
        for(int k = 0; k<stringArr.Length; k++){
            if(Convert.ToInt32(new string(stringArr[k], 1)) == 0){
                continue;
            }
            if((stringArr[k]%2) == 0){
                num++;
                numTemp++;
            }
        }
        //Console.Write(numTemp);
        //Console.WriteLine(" ");
    }
    return num;
}
string GetResult(int[] arr){
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
Console.WriteLine(GetNum(arr)+"---"+GetResult(arr));
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
string GetResult(int[] arr){
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
Console.WriteLine(GetNum(arr)+"---"+GetResult(arr));

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

