System.Console.WriteLine("input number1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input number2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input number3 ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number2 > max){
    max = number2;
    }
if(number3 > max){
    max = number3;
}
System.Console.WriteLine("max = " + max);

