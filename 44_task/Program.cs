// 44. Найти точки пересечения 2х прямых, заданных уравнениями
 // y = k1 * x + b1, y = k2 * x + b2, b1 и k1 и b2 и k2 заданы

Random rand = new Random();
int k1 = rand.Next(0,20);
int b1 = rand.Next(0,20);
int k2 = rand.Next(0,20);
int b2 = rand.Next(0,20);
int y1;
int y2;
int x;
x = (b2 - b1) / (k1 - k2);
y1 = (k1 * x) + b1;
y2 = (k2 * x) + b2;
Console.WriteLine($"Присвоены значения k1 = {k1} b1 = {b1} k2 = {k2} b2 = {b2}");
Console.WriteLine($"х = {x} у1 = {y1} у2 = {y2}");
if (y1 == y2)
if (k1 != k2)
    Console.WriteLine($"Точки пересечения ({x};{y1})");
else
    Console.WriteLine($"Нет точек пересечения");