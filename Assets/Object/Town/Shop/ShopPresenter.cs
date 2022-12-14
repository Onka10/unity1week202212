using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ShopPresenter : MonoBehaviour
{
    //アイテムはmodelに隠蔽
    [SerializeField] ShopModel model;
    [SerializeField] ShopView view;

    [SerializeField] InventoryPresenter inventory;
    [SerializeField] TownStatusPresenter townStatus;

    void Start()
    {
        townStatus.Decided
        .Subscribe(_ => Ready())
        .AddTo(this);
    }

    void Ready(){
        //情報の入手
        var towndata = townStatus.GetTownData();
        // modelに指示
        model.ShopModelG(towndata.Supply);
        // FIXME本来はデータを受け取る?モデルがもってるからいらん？

        //README viewは仕様変更の可能性あり
        view.ShowAll();
        view.SetItem(model.GetItem(0),model.GetItem(1),model.GetItem(2));    
    }

    public void Buy(int id){
        var item =  model.GetItem(id);

        if(MoneyManager.I.Minus(item.price)){
            inventory.Add(item);
            view.Hide(id);
        }else{
            Debug.Log("お金がたりません");
        }
    }
}
