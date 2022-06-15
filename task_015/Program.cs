// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Ввведите число: ");
string n = Console.ReadLine();
if (n.Length < 3)
{
Console.WriteLine("В заданном числе нет третьей цифры");
}
else{
    Console.WriteLine(n[2]);
   //char[] array;
// array = n.ToCharArray(2,1);
//Console.WriteLine(array);
}

