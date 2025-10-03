namespace ADP_HM02;

public class PrintNumbers
{
    public void ProcessNumbers(int[]? numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return;
        }

        foreach (var number in numbers)
        {
            if (number > 0)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}