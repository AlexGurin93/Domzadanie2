//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*void Zadacha10()
{
Random rand = new Random ();
int number = rand.Next(100, 1000);
Console.WriteLine ("Случайное число" );
Console.WriteLine (number);

int ones = number%10;
int tens = number/10;
int hunds = number/100;
int ResultNumber =tens%10;
Console.WriteLine(ResultNumber);
}
*/
//Zadacha10();

//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

/*void Zadacha13()
Console.WriteLine ("Случайное число" );

int number = Convert.ToInt32(Console.ReadLine());
   
  if (number < 100)

          Console.Write("Нет третьей цифры");

  else if (number < 1000)
       
           Console.Write(number % 10);
       
  else
       
  while(number > 1000)
           
        number /= 10;
           
Console.Write(number%10);
       */
   //Задача 15: Напишите программу, которая принимает на вход цифру, 
   //обозначающую день недели, и проверяет, является ли этот день выходным.
  Console.WriteLine ("Введите число от 1 до 7 : " );
   int number = Convert.ToInt32(Console.ReadLine());
   if ( number == 7 || number == 6)
       Console.Write("Выходной");
   else
       Console.Write("Рабочий");
   