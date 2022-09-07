// Показать натуральные числа от M до N, N и M заданы
ShowNumbersBetween(1, 5);

int ShowNumbersBetween(int M, int N)
{
        if (M > N) return M; Console.Write($"{M} ");
        return ShowNumbersBetween(M+1, N);
}
