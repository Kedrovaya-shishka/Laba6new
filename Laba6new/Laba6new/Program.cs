//Laba 6
//Number 1
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int a = N;
int b = 0;
while (a > 0)
{
    a /= 10;
    b++;
}
int[] Func = new int[b];
MyFunc getFunc = (int x) => x % 10;
a = N;
for (int i = b - 1; i >= 0; i--)
{
    Func[i] = getFunc(a);
    a = a / 10;
}
Console.WriteLine("Массив цифр:");
foreach (int d in Func)
{
    Console.Write(d + " ");
}
delegate int MyFunc(int x);
