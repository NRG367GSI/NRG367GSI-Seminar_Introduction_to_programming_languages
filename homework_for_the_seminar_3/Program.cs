/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Verification(string input)
{
    bool result = Int32.TryParse(input, out int number);
    if (result == false) number = -987654321; 
    return number;
}

void Task_19()
{
    Console.Write("Введите 5 значное число: ");
    string userInput = Console.ReadLine();

    if (userInput.Length == 5)
    {
        if (Verification(userInput) == -987654321) Console.WriteLine($"Введенная комбинация символов {userInput} не удовлетворяет условию");
        if (userInput[0] == userInput[4] && userInput[1] == userInput[3] && Verification(userInput) != -987654321) Console.Write($"Число {userInput} является полиндромом!");
        if (userInput[0] != userInput[4] || userInput[1] != userInput[3] && Verification(userInput) != -987654321) Console.WriteLine("Введенное значение не полиндром");
        
    }
}

void Task_21()
{
    Console.WriteLine("Введите точки А: ");

    Console.Write("Аx: ");
    double ax = Verification(Console.ReadLine());

    Console.Write("Ay: ");
    double ay = Verification(Console.ReadLine());

    Console.Write("Az: ");
    double az = Verification(Console.ReadLine());


    Console.WriteLine("Введите точки B: ");

    Console.Write("Bx: ");
    double bx = Verification(Console.ReadLine());

    Console.Write("By: ");
    double by = Verification(Console.ReadLine());

    Console.Write("Bz: ");
    double bz = Verification(Console.ReadLine());

     double delta = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)), 3);
     Console.WriteLine(delta);
}

void Task_23()
{
    Console.WriteLine("Введите число: ");
    string usirInput = Console.ReadLine();
    int number = Verification(usirInput);
    if (number != -987654321)
    {
        if (number > 0)
        {
            for (double cub = 1; cub < number + 1;  cub++) Console.WriteLine($"{cub}^3={Math.Pow(cub, 3)}");
        }
        if (number < 0)
        {
            for (double cub = -1; cub > number - 1;  cub--) Console.WriteLine($"{cub}^3={Math.Pow(cub, 3)}");
        }
    }
    else Console.WriteLine("Введено не верное значение!");
}

void menu()
{
Console.WriteLine("Для вызова задачи 19 введите 1");
Console.WriteLine("Для вызова задачи 21 введите 2");
Console.WriteLine("Для вызова задачи 23 введите 3");
string query = Console.ReadLine();
if (query == "1") Task_19();
if (query == "2") Task_21();
if (query == "3") Task_23();
}

menu();