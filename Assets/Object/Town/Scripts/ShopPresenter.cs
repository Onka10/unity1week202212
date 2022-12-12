using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ShopPresenter : MonoBehaviour
{
    //アイテムはmodelに隠蔽
    [SerializeField] ShopModel model;
    [SerializeField] ShopView view;

    [SerializeField] MyItemsPresenter myItems;

    void Start()
    {
        //タウンフェーズ開始を確認
        GameManager.I.State
        .Where(s => s==GameState.Town)
        .Subscribe(_ => Ready())
        .AddTo(this);
    }

    void Ready(){
        //アイテムのセット
        // modelに指示
        model.ShopModelG(ItemType.Food);
        // FIXME本来はデータを受け取る?モデルがもってるからいらん？
        view.ShowAll();
        view.SetItem(model.GetItemPrice(1),model.GetItemPrice(2),model.GetItemPrice(3));    
    }

    public void Buy(int i){
        var price =  model.GetItemPrice(i);
        if(MoneyManager.I.Money.Value < price) Debug.Log("お金がたりません");
        else{
            MoneyManager.I.Minus(price);
            myItems.Add(price);
            view.Hide(i);
        }
    }
}
