Console.WriteLine ("Введите трехзначное число ");
int numberA = int.Parse(Console.ReadLine());
int x1 = numberA%10;
int x2 = numberA/10;
int y = x2%10;
Console.WriteLine($"Вторая цифра {numberA} -> {y}");