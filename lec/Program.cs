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




int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 1;
while(number2<=number1){
    if(number2%2 == 0){
        Console.WriteLine(number2);
    }
    number2++;
}