// проверка пятизначного на полиндром
Console.WriteLine("Введите пятизначное число N");
int n = Convert.ToInt32(Console.ReadLine());
Int32 N = Math.Abs(n);
if (N<10000 || N>=100000){
    System.Console.WriteLine($"{n} - не пятизначное");
}
while (N>=10000 && N<100000){
    if (N/10000==N%10 && (N/1000)%10==(N%100)/10){
        System.Console.WriteLine($"{n} - полиндром");
    }
    else
    System.Console.WriteLine($"{n} - не полиндром");
    break;
}

  
