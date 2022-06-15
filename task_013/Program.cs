// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
string[] array = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine("Ввведите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 0 && n < 5)
{
 Console.WriteLine($"{array[n]} является рабочим днём");  
 
}
else if (n >= 5 && n < 7)
{
   Console.WriteLine($"{array[n]} является выходным днём");  

}
else
{
   Console.WriteLine("Отсутствует такой день недели");   
}

