using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ShopPresenter : MonoBehaviour
{
    //アイテムはmodelに隠蔽
    [SerializeField] ShopModel model;
    [SerializeField] ShopView view;

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
        model.ShopModelG(100,200,300);
        // FIXME本来はデータを受け取る
        view.SetItem(100,200,300);    
    }

    public void Buy(int i){
        var price =  model.GetItemPrice(i);
        if(MoneyManager.I.Money.Value < price) Debug.Log("お金がたりません");
        else{
            MoneyManager.I.Minus(price);
        }
        Debug.Log(i);
    }
}
