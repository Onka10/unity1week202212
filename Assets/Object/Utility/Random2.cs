using UnityEngine;
using System.Collections.Generic;

public static class Random2
{
    /**  
    <summary>
    randomのラップもどき。0.5か1.5になる
    </summary>
    */
    public static float Random50(){
        if(Random.Range(0,2) == 1)  return 0.5f;
        else return 1.5f;
    }

    public static List<int> RandomNoDouble(int start , int end)
    {
        List<int> numbers = new List<int>();

        for (int i = start; i < end; i++) {
            numbers.Add(i);
        }

        while (numbers.Count > 0) {
            int index = Random.Range(0, numbers.Count);
            int ransu = numbers[index];
            numbers.RemoveAt(index);
        }

        return numbers;
    }
}
