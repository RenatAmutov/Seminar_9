// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber()
{
    Console.Write("Vvedite chislo: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumNumberOtNDoM (int max, int min)
{
    if(max == min)
    {
     return min;
    }
    else
    {
     return max + SumNumberOtNDoM(max-1, min);    
    }
}

int max = InputNumber();
int min = InputNumber();
if(max < min)
{
    (max, min) = (min, max);
}
Console.Write($"summa chisel mezdu {min} i {max} ravna {SumNumberOtNDoM(max, min)} ");
