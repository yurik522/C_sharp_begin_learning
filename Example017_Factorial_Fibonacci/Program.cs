// double Factorial(int n)
// {
//     if (n == 1) return n;
//     else return n * Factorial(n-1);
// }
// //Console.WriteLine(Factorial(25));
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


int Fibonacci(int n)
{
    if (n == 1 || n == 2) return n;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 46; i++)
{
    Console.WriteLine($"Fib{i} = {Fibonacci(i)}");
}