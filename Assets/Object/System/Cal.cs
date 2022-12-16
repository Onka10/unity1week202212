using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cal : Singleton<Cal>
{
    [SerializeField] TownStatusPresenter town;

    TownData townData;
    Item item;



    public int CalcPrice(Item it){
        townData = town.GetMowTownData();
        item = it;
        //定価 * 町の固定バフ * 町の需要と供給 * アイテム自体のバフ * (情勢のバフ) =　最終値段
        float price = (float)it.price * CalcTownBuff() * CalcDemandBuff() * CalcItemBuff();
        return (int)price;
    }


    //以下の関数で乱数の使用は禁止。再現性がなくなります。
    float CalcTownBuff(){
        if(townData.Type == TownType.MyTown) return 1f;
        else return WorldData.I.Economy;

    }

    float CalcDemandBuff(){
        //需要
        if(item.type == townData.Demand) return 1.5f;
        else return 1f;
    }

    float CalcItemBuff(){
        return 1f;
    }
}
