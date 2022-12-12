using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopModel : MonoBehaviour
{
    private int[] items = new int[3];

    public void ShopModelG(){
        items[0]= Random.Range(1, 9) * 100;
        items[1]= Random.Range(1, 9) * 100;
        items[2]= Random.Range(1, 9) * 100;
    }

    public int GetItemPrice(int i){
        return items[i-1];
        // return 100;
    }
}
