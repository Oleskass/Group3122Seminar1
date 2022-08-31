//=============================================
// #1
// на входе принимает 2 числа и проверяет, 
// является ли первое число квадратом второго
//=============================================


string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    string[] dayOfWeek = new string[7]; //массив
    dayOfWeek[0] = "Monday";
    dayOfWeek[1] = "Tuesday";
    dayOfWeek[2] = "Wednesday";
    dayOfWeek[3] = "Thursday";
    dayOfWeek[4] = "Friday";
    dayOfWeek[5] = "Saturday";
    dayOfWeek[6] = "Sunday";

    if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    {
        Console.WriteLine("There is no day of week");
    }
    else
    {
        Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
    }


}

// string outDayOfWeek = string.Empty; //""
//switch (inputDayOfWeek)
//{
//  case 1: outDayOfWeek = "Monday"; break;
//  case 2: outDayOfWeek = "Tuesday"; break;
//  case 3: outDayOfWeek = "Wednesday"; break;
//  case 4: outDayOfWeek = "Thursday"; break;
//  case 5: outDayOfWeek = "Friday"; break;
//  case 6: outDayOfWeek = "Saturday"; break;
//  case 7: outDayOfWeek = "Sunday"; break;
//  default: outDayOfWeek = "There is not day of week"; break;
//    
//}
//Console.WriteLine(outDayOfWeek);


outDayOfWeek = System.Globalization.CultureInfo("ru-RU").DateTimeFormat.GetDayName()