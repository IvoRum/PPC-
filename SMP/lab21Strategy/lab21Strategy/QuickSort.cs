﻿namespace lab21Strategy;

public class QuickSort:SortStrategy
{
    public override void Sort(List<string> list)
    {
        list.Sort();
        Console.WriteLine( "QuickSorted list ");
    }

}