using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopModel : MonoBehaviour
{
    private int[] items = new int[3];

    public void ShopModelG(int a,int b,int c){
        // for(int i=0;i<items.Length;i++){
            
        // }

        items[0]=a;
        items[1]=b;
        items[2]=c;
    }

    public int GetItemPrice(int i){
        // return items[i-1];
        return 100;
    }
}
