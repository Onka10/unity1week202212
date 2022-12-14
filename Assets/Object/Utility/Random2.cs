using UnityEngine;

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
}
