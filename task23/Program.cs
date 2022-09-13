// Кубы от 1 до N
Console.WriteLine("Введите число N");
Int32 n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i<=n; i++){
    System.Console.WriteLine($"{Math.Pow(i, 3)}");
}
