using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopModel : MonoBehaviour
{
    private Item[] items = new Item[3];

    public void ShopModelG(ItemType t){

        items[0]= ItemDB.I.GetRandomItem(t);
        items[1]= ItemDB.I.GetRandomItem(t);
        items[2]= ItemDB.I.GetRandomItem(t);
    }

    public int GetItemPrice(int i){
        return items[i-1].price;
    }
}
