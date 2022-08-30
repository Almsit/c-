
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool number = int.TryParse(Console.ReadLine(), out int number2);
if(number != true){
    Console.WriteLine("Число неверное");
    return;
}

string toAr(int number2){
    string number_arr = number2.ToString();
    string res = "";
    for(int i=number_arr.Length; i>0; i--){
        res += number_arr[i-1];
    }
    return res;
}
string Result(string a, string b){
    
    Console.WriteLine(a+"---"+b);
    if(a == b){
        return "Да";
    } else {
        return "Нет";
    }
}
string res2 = Result(toAr(number2), number2.ToString());
Console.WriteLine(res2);
*/














//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*

bool number = int.TryParse(Console.ReadLine(), out int number2);
if(number != true){
    Console.WriteLine("Число неверное");
    return;
}


int Result(int[] arr, int number2){
    
    int[] arr = new int[number2];
    for(int i = 0; i<number2; i++){
        arr[i]=(i+1)*(i+1)*(i+1);
    }
    return arr;
}
void Print(int[] arr){
    for(int i = 0; i<arr.Length; i++){
        Console.WriteLine(arr[i]);
    }
}

arr = Result(number2);
Print(arr);

*/












//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.WriteLine("Введите координаты x,y,z для точки А разделяя их пробелом: ");
string[] A = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("Введите координаты x,y,z для точки B разделяя их пробелом: ");
string[] B = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);




double[] Res(string a1, string a2, string a3, string b1, string b2, string b3){
    double[] arr = new double[7];
    double xA = double.Parse(a1);
    double yA = double.Parse(a2);
    double zA = double.Parse(a3);

    double xB = double.Parse(b1);
    double yB = double.Parse(b2);
    double zB = double.Parse(b3);
    
    
    double S = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    
    arr[0] = xA;
    arr[1] = yA;
    arr[2] = zA;
    arr[3] = xB;
    arr[4] = yB;
    arr[5] = zB;
    arr[6] = S;
    
    return arr;

}

void Print(double[] arr){
    for(int i = 0; i<arr.Length; i++){
        Console.WriteLine(arr[i]);
    }
}

double[] arr = Res(A[0], A[1], A[2], B[0], B[1], B[2]);
Print(arr);


*/