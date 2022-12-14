using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : Singleton<ItemDB>
{
    [SerializeField] List<Item> Ente = new List<Item>();
    [SerializeField] List<Item> Food = new List<Item>();
    [SerializeField] List<Item> Funi = new List<Item>();
    [SerializeField] List<Item> Starter = new List<Item>();

    public Item GetRandomItem(ItemType t){
        var item=Ente[0];

        //FIXME 仮で
        var r = Random.Range(0,4);
        if(t==ItemType.Food) item =Food[r];
        else if(t==ItemType.Furniture) item=Funi[r];
        else if(t==ItemType.Entertainment) item = Ente[r];
        else item = GetRandomItemt();

        return item;
    }


    Item GetRandomItemt(){
        var r = Random.Range(0,3);

        if(r==0) return Food[r];
        else if(r==1) return Funi[r];
        else  return Ente[r];
    }

}
