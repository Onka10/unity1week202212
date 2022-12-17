using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SelectPresenter : Singleton<SelectPresenter>
{
    //アイテムはmodelに隠蔽
    [SerializeField] SelectModel model;
    [SerializeField] SelectView view;
    Action nowAct;

    void Start()
    {
        TownStatusPresenter.I.Decided
        .Subscribe(_ => Ready())
        .AddTo(this);
    }

    void Ready(){
        //情報の入手
        var towndata = TownStatusPresenter.I.GetMowTownData();

        // 商品の用意
        model.ShopModelG(towndata.Type);
        
        view.ShowAll();
        view.SetItem(model.GetAction(0),model.GetAction(1),model.GetAction(2));    
    }

    public void Act(int id){
        nowAct =  model.GetAction(id);
        PlayerManager.I.AddData(nowAct);
        GameManager.I.ToNextInTown();
    }

    public Action GetNowAction(){
        return nowAct;
    }
}
