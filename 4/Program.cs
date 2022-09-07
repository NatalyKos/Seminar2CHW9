// Написать программу вычисления функции Аккермана
Console.WriteLine(Achermann(5,0));

int Achermann(int N, int M)
{
    int count = 0;
    if (N == 0) return count = M + 1;
    if (N != 0 && M == 0) count = Achermann(N-1,1);
    if (N > 0 && M > 0) count = Achermann(N-1, Achermann(N,M-1));
    return count;
}
