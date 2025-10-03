namespace ADP_HM02;
public class T4
{
    public void PrintPositiveNumbers(int[]? numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return;
        }

        Array.Sort(numbers);

        foreach (var number in numbers)
        {
            if (number > 0)
            {
                Console.WriteLine(number);
            }
        }
    }

}