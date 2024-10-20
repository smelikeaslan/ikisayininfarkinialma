
Console.Write("Birinci sayyıyı giriniz:");

int birincisayi = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz:");

int ikincisayi = Convert.ToInt32(Console.ReadLine());


if (birincisayi > ikincisayi)

{
    int fark = birincisayi - ikincisayi;

    Console.Write("İki sayının farkı:" + fark);

}
else if (ikincisayi > birincisayi)
{
    int fark2 = ikincisayi - birincisayi;
    Console.Write("iki sayının farkı:" + fark2);
}

else
{
    Console.Write("Sayıların farkı:0");

}

Console.ReadKey();