// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int number = Prompt("Введите первое число: ");
int number2 = Prompt("Введите второе число: ");
int res = 1;
for (int i=1; i <= number2; i++) 
{
    res = res*number;
}
System.Console.WriteLine("Первое число в степени второго числа: "+ res);