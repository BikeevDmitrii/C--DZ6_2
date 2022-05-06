// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Какое колличество чисел вы хотите ввести? M = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Mac()
{
    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}
void Print(int[] a)
{
    int b=0;
    for (int i = 0; i < n; i++)
    {
        if (a[i] > 0)
        {
            b++;
        }
        
    }
    Console.Write("Колличество чисел больше 0  = "+ b);
}
int[] array = Mac();
Print(array);
