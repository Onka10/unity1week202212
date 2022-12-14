using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class InventoryPresenter : MonoBehaviour
{
    [SerializeField] InventoryView view;
    [SerializeField] InventoryModel model;


    private void Start() {
        model.MyItems
        .ObserveCountChanged()
        .Subscribe(_ =>{
            view.HideAll();
            for(int i=0;i<model.MyItems.Count;i++){
                view.Show(i,model.MyItems[i]);
            }
        })
        .AddTo(this);

    }

    public void Add(Item item){
        model.Add(item);
    }

    public void Sell(int id){
        if(model.MyItems.Count <= id)   return;

        //売却
        MoneyManager.I.Add(model.MyItems[id].price);
        model.Remove(id);
    }
}
