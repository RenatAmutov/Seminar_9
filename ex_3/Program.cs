// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Acr(int m, int n)
{
 if(m == 0)
 {
    return n + 1;
 }
 else if((m != 0) && (n == 0))
 {
    return Acr(m - 1, 1);;
 }
 else 
 {
    return Acr(m - 1, Acr(m, n - 1));;
 }
}
Console.Write("Vvedite chislo m: ");
int m = InputNumber();
Console.Write("Vvedite chislo n: ");
int n = InputNumber();
if(m < 0)
{
  m=m *-1;
  Console.WriteLine($"chislo m = {m*-1} bilo preobraxovanno v polozhitelnoe {m}");  
}
if(n < 0)
{
  n=n *-1;  
  Console.WriteLine($"chislo n = {n*-1} bilo preobraxovanno v polozhitelnoe {n}");
}
Console.WriteLine($"{Acr(m, n)} ");