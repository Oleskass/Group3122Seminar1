//=============================================
// #1
// на входи принимает 2 числа и проверяет, 
// является ли первое число квадратом второго
//=============================================


string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    bool outputResult = (inputNumberA * inputNumberA == inputNumberB);

    //bool outpuResult = (inputNumberB/inputNumberA == inputNumberA);

    //bool outpuResult = (Math.Sqrt(inputNumberB)/ == inputNumberA);

    //int outNumber -(int0Math.Pow(inputNumber,2); старое с задания 0

    Console.WriteLine(outputResult);
}