System.Console.WriteLine("input number  ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 2;
while(number2 <= number1)
{
   if(number2%2 == 0)
    System.Console.Write(number2 + ",");
    number2 += 1;
}

