// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Console.ReadLine();
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
//Console.Write(result);

*/


/* // задача 1
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1*number1==number2){
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}*/



/*

int number1 = Convert.ToInt32(Console.ReadLine());

if(number1 == 1){
    Console.WriteLine("П");
} else if(number1 == 2){
    Console.WriteLine("В");
} else if(number1 == 3){
    Console.WriteLine("С");
} else if(number1 == 4){
    Console.WriteLine("Ч");
} else if(number1 == 5){
    Console.WriteLine("П");
} else if(number1 == 6){
    Console.WriteLine("С");
} else if(number1 == 7){
    Console.WriteLine("В");
}
*/
/*
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number*-1;
    while(number2<=number1){
    Console.WriteLine(number2);
    number2++;
}
*/

/*
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number1%10);

*/



/*
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number1;

if(max<number2){
    max = number2;
    min = number1;
}
if(max<number3){
    max = number3;
    min = number1;
}
if(min>number2){
    min = number2;
}
if(min>number3){
    min = number3;
}
Console.WriteLine("Максимальное число "+max);
Console.WriteLine("Минимальное число "+min);*/


/*

int number1 = Convert.ToInt32(Console.ReadLine());
if(number1%2 == 0){
    Console.WriteLine("Четное");
} else {
    Console.WriteLine("Не четное");
}

*/


/*

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 1;
while(number2<=number1){
    if(number2%2 == 0){
        Console.WriteLine(number2);
    }
    number2++;
}
*/










/*
int Max(int arg1, int arg2, int arg3){
    int max = arg1;
    if(max<arg2){
        max = arg2;
    }
    if(max<arg3){
        max = arg3;
    }
    return max;
}
int max1 = Max(2, 4, 1);
 Console.WriteLine(max1);

 
 
int max2 = Max(6, 3,9);
 Console.WriteLine(max2);

 
int max3 = Max(2, 3, 5);
 Console.WriteLine(max3);

 
int max = Max(max1, max2, max3);
 Console.WriteLine(max);

 //или

max = Max(Max(2, 4, 1), Max(6, 3,9), Max(2, 3, 5));

 Console.WriteLine(max);

 */







/*
int Max(int arg1, int arg2, int arg3){
    int max = arg1;
    if(max<arg2){
        max = arg2;
    }
    if(max<arg3){
        max = arg3;
    }
    return max;
}


 int[] array = {1,2,3,4,5,6,7,8,9};
 array[0] = 33;

int arr_l = array.Length;
int find = 6;
int index = 0;
while(index<find){
    if(array[index] == find){
        Console.WriteLine(find);
        break;
    }
    index++;
}
 
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );
  Console.WriteLine(arr_l);
  */









/*
  
void newzArr(int[] col){
    int length = col.Length;
    int index = 0;
    while(index<length){
        col[index] = new Random().Next(1,20);
        //Console.WriteLine(col[index]);
        index++;
    }
}
*/



/*
void printArr(int[] col2){
    int length = col2.Length;
    int index = 0;
    while(index<length){
        col2[index] = new Random().Next(1,10);
        Console.WriteLine(col2[index]);
        index++;
    }
}

int ind(int[] col, int find){

    int length = col.Length;
    int index = 0;
    int pos = -1;
    
    while(index<find){
        if(col[index] == find){
            pos = index;
            break;
        }
        index++;
    }
    return pos;
}
int[] arr = new int[10];

//newzArr(arr);
printArr(arr);
Console.WriteLine();
int pos = ind(arr, 4);

Console.WriteLine(pos);

*/


/*
int number = Convert.ToInt32(Console.ReadLine());
number = (number/10)%10;
Console.WriteLine(number);




int result(int number){
    return (number/10)%10;
}
int number = Convert.ToInt32(Console.ReadLine());
number = result(number);
Console.WriteLine(number);

*/


/*
int number = Convert.ToInt32(Console.ReadLine());
if(number.ToString().Length >= 3){
    int i = 3;
    int p = 1;
    while(number.ToString().Length > i){
        p *= 10;
        i++;
    }
    Console.WriteLine((number/p)%10);
} else {
    Console.WriteLine("Третьей цифры нет");
}



*/


/*
int result(int number){

    if(number.ToString().Length >= 3){
        int i = 3;
        int p = 1;
        while(number.ToString().Length > i){
            p *= 10;
            i++;
        }
        return (number/p)%10;
    } else {
        return -1;
    }
}
int number = Convert.ToInt32(Console.ReadLine());
number = result(number);
if(number != -1){
    Console.WriteLine(number);
} else {
    Console.WriteLine("Третьей цифры нет");
}
*/


/*
string[] days = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
int number = Convert.ToInt32(Console.ReadLine());


int result(int number){
    if(days[number-1] == "Суббота" ||  days[number-1] == "Воскресенье"){
        return 1;
    } else {
        return 0;
    }
}
number = result(number);
if(number == 1){
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}

*/


/*
bool numberX = int.TryParse(Console.ReadLine(), out int x);
bool numbery = int.TryParse(Console.ReadLine(), out int y);
if(numberX != true || numbery!=true){
    Console.WriteLine("Числа неверные");
}

bool Validate(int x, int y){
    if(x == 0 || y == 0){
        return false;
    } else {
        return true;
    }

}
int Pos(int x, int y){
    if(x>0 && y>0){
        return 1;
    }
     if(x<0 && y>0){
        return 2;
    }
     if(x<0 && y<0){
        return 3;
    }
     if(x>0 && y<0){ 
        return 4;
    }
    return -1;
}
bool isValid = Validate(x, y);
if(!isValid){
    Console0.WriteLine("dd");
    return;
}
int res = Pos(x, y);

Console.WriteLine(res);

*/


/*


string number_arr = number2.ToString();

string res = "";
for(int i=number_arr.Length; i>0; i--){
    res += number_arr[i-1];
}
if(number2.ToString() == res){
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}
Console.WriteLine(number2+"-------"+res);



*/



bool number = int.TryParse(Console.ReadLine(), out int number2);
if(number != true){
    Console.WriteLine("Число неверное");
    return;
}

string Perev(int number2){
    string number_arr = number2.ToString();
    string res = "";
    for(int i=number_arr.Length; i>0; i--){
        res += number_arr[i-1];
    }
    return res;
}
string Srav(string a, string b){
    
    Console.WriteLine(a+"---"+b);
    if(a == b){
        return "Да";
    } else {
        return "Нет";
    }
}
string res2 = Srav(Perev(number2), number2.ToString());
Console.WriteLine(res2);
/*
if(number2.ToString() == res){
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}
Console.WriteLine(number2+"-------"+res);




bool number = int.TryParse(Console.ReadLine(), out int number2);
if(number != true){
    Console.WriteLine("Число неверное");
    return;
}

void result(int[] arr, int number2){
    for(int i = 0; i<number2; i++){
        arr[i]=(i+1)*(i+1)*(i+1);
    }
}
int[] arr = new int[number2];
result(arr, number2);
for(int i = 0; i<arr.Length; i++){
    Console.WriteLine(arr[i]);
}



Console.WriteLine("Введите координаты x,y,z для точки А разделяя их пробелом: ");
string[] A = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("Введите координаты x,y,z для точки B разделяя их пробелом: ");
string[] B = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

double xA = double.Parse(A[0]);
double yA = double.Parse(A[1]);
double zA = double.Parse(A[2]);

double xB = double.Parse(B[0]);
double yB = double.Parse(B[1]);
double zB = double.Parse(B[2]);

double S = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB}) -> {S:f3}");

*/