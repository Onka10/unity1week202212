using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDB : Singleton<ShopDB>
{
    [SerializeField] List<Item> Ente = new List<Item>();
    [SerializeField] List<Item> Food = new List<Item>();
    [SerializeField] List<Item> Inds = new List<Item>();

    public Item GetRandomItem(ItemType t){
        var item=Ente[0];

        var r = Random.Range(0,4);
        if(t==ItemType.Food) item =Food[r];
        else if(t==ItemType.IndustrialGoods) item=Inds[r];
        else item = Ente[r];

        return item;
    }

}
