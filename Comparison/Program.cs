byte value1 = 2, value2 = 3;

bool result = false;

result = (value1 < value2);
Console.WriteLine(result);
Console.ReadLine();

result = (value1 > value2);
Console.WriteLine(result);
Console.ReadLine();

result = (value1 <= value2);
Console.WriteLine(result);
Console.ReadLine();

result = (value1 >= value2);
Console.WriteLine(result);
Console.ReadLine();

result = (value1 != value2);
Console.WriteLine(result);
Console.ReadLine();

result = (value1 == value2);
Console.WriteLine(result);
Console.ReadLine();




byte number1 = 2;
byte number3 = number1++;
byte number2;

Console.WriteLine(number3);
Console.WriteLine(number2 = number1--);

Console.WriteLine(number2 = --number1);
Console.ReadLine();

byte variable = 0;

variable = (byte)(variable + 5);
Console.WriteLine(variable);
Console.ReadLine();

variable += 5;

Console.WriteLine(variable);
Console.ReadLine();