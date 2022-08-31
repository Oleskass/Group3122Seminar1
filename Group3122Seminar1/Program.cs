//==================
// #0
//
//==================


string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outputNumber = inputNumber*inputNumber;

    Console.WriteLine(outputNumber);
}