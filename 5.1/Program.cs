// See Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int N = 5;
FibonacciArray(firstNumber,secondNumber,N,0);

int[] FibonacciArray(int A, int B, int C, int D)
{
    int[] array = new int[C];
    for(D = 0; D < array.Length; D++)
    {
        array[D] = A + B;
        Console.WriteLine(array[D]);
        int tmp = A + B;
        A = B;
        B = tmp;
    }
    return array;
}