﻿using System;

class BubbleSort : StrategySort
{
    public BubbleSort()
    {
        Title = "Сортировка пузырьком";
    }

    public override string ToString()
    {
        return Title;
    }

    public override void Sort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            
            for (int j = 0; j < n - i - 1; j++)
            {

                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j+1] = temp;
                    swapped = true;
                }
            }

            
            if (!swapped)
                break;
        }
    }
}
