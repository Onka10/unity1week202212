using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class InventoryPresenter : MonoBehaviour
{
    [SerializeField] InventoryView view;
    [SerializeField] InventoryModel model;
    [SerializeField] TownStatusPresenter townStatus;


    private void Start() {
        model.MyItems
        .ObserveCountChanged()
        .Subscribe(_ =>Fresh())
        .AddTo(this);


        townStatus.Decided
        .Subscribe(_ => Fresh())
        .AddTo(this);
    }

    void Fresh(){
        view.HideAll();
        for(int i=0;i<model.MyItems.Count;i++){
            view.Show(i,model.MyItems[i]);
        }
    }

    public void Add(Item item){
        model.Add(item);
    }

    public void Sell(int id){
        if(model.MyItems.Count <= id)   return;

        //売却
        MoneyManager.I.Add(Cal.I.CalcPrice(model.MyItems[id]));
        model.Remove(id);
    }
}
