using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        numbers.Remove(numbers.DefaultIfEmpty().Min());

        return numbers;
    }
}