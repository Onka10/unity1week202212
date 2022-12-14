using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopModel : MonoBehaviour
{
    private Item[] items = new Item[3];

    public void ShopModelG(ItemType it){
        items[0]= ItemDB.I.GetRandomItem(it);
        items[1]= ItemDB.I.GetRandomItem(it);
        items[2]= ItemDB.I.GetRandomItem(it);
    }

    public Item GetItem(int i){
        return items[i];
    }
}
