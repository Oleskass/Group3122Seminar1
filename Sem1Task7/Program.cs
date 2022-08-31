====================================
// #7
// принимает на вход 3хзначное число и на 
// выходе показывает поледнюю цифру этого числа
//=============================================


string? inputLine = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99&&inputNumber<1000)
    {
        int lastDigit = inputNumber%10;
   
        Console.Write(startNumber+", ");
        startNumber=startNumber+1;
   
    }
}
