// See Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Fibonacci(firstNumber, secondNumber,4);

int Fibonacci(int A, int B, int N)
{
    if (N == 1 || N == 0) return A+B; Console.WriteLine(Fibonacci(B,A,N-1) + Fibonacci(A,B,N-1));
    return Fibonacci(B,A,N-1) + Fibonacci(A,B,N-1);
}
