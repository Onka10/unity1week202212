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
        //町のバフを確認
        // 港＝供給と需要が価格安い
        // 王都＝供給も需要も価格高い

        if(townData.Type == TownType.Kingdom) return 1.5f;
        else if(townData.Type == TownType.Port) return 0.5f;
        else if(townData.Type == TownType.Desert) return WorldData.I.Economy;
        else return 1f;
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
