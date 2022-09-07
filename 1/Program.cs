// Показать натуральные числа от N до 1, N задано
Console.WriteLine(ShowNumbersUpTo(7));


int ShowNumbersUpTo(int N)
{
    if (N == 1) return N; Console.Write($"{N}, ");
    return ShowNumbersUpTo(N-1);
    
}
