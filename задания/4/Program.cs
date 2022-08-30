Console.Clear();
/*
bool number1 = int.TryParse(Console.ReadLine(), out int numberInt1);
bool number2 = int.TryParse(Console.ReadLine(), out int numberInt2);
bool Valid(bool n1, bool n2, int n3, int n4){
    if(n1 != true || n2 != true){
        Console.WriteLine("Число неверное");
        return false;
    }
    if(n4 == 0){
        numberInt2 = 1;
        return true;
    }
    return true;
}
bool valid =  Valid(number1, number2, numberInt1, numberInt2);
if(!valid){
    return;
}



//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Result(int n1, int n2){
    int res = n1;
    for(int i = 0; i<n2-1; i++){
        res = res*n1;
    }
    return res;
}
Console.WriteLine(Result(numberInt1, numberInt2));
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

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*

bool number1 = int.TryParse(Console.ReadLine(), out int numberInt1);
bool Valid(bool n1, int numberInt1){
    if(n1 != true){
        Console.WriteLine("Число неверное");
        return false;
    }
    if(numberInt1.ToString().Length<2){
        Console.WriteLine("Длина числа меньше 2");
        return false;
    }
    return true;
}
bool valid =  Valid(number1, numberInt1);
if(!valid){
    return;
}
int Result(int n1){
    int result = 0;
    string toArr = n1.ToString();
    for(int i = 0; i<toArr.Length; i++){
        result += Convert.ToInt32(new string(toArr[i], 1));
    }
    return result;
}
Console.WriteLine(Result(numberInt1));
//
*/
Console.WriteLine("Введите 8 чисел для создания массива");
string[] stringArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


bool Valid(string[] arr){
    if(arr.Length>8){
        Console.WriteLine("Массив больше 8 чисел");
        return false;
    }
    if(arr.Length<8){
        Console.WriteLine("Массив меньше 8 чисел");
        return false;
    }
    for(int i = 0; i<arr.Length; i++){
        if(int.TryParse(arr[i], out int number) != true){
            Console.WriteLine("Число в массиве неверное");
            return false;
        }
    }
        return true;
}
bool valid =  Valid(stringArr);
if(!valid){
    return;
}
string Result(string[] stringArr){
    string result = "";
    for(int i = 0; i<stringArr.Length; i++){
        if(result == ""){
            result = stringArr[i];
        } else {
            result += ", "+stringArr[i];
        }
    }
    result = "["+result+"]";
    return result;
}
Console.WriteLine(Result(stringArr));