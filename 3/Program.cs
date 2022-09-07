// Найти сумму элементов от M до N, N и M заданы
Console.Write($"The sum between elements amounts to {TotalSumBetweenNumbers(0,4)}");

int TotalSumBetweenNumbers(int M, int N)
{
    if(M == N) return N;
    return TotalSumBetweenNumbers(M, N-1)+N;
}
