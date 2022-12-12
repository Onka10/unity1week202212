using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MyItemsPresenter : MonoBehaviour
{
    [SerializeField] MyItemsView view;

    public IReactiveCollection<int> Hand => _hand;
    private readonly ReactiveCollection<int> _hand = new ReactiveCollection<int>{0};//初期化済み

    public void Add(int n){
        _hand.Add(n);
        view.Show(_hand.Count);
        view.Setdata(_hand.Count-1,n);
    }

    public void Sell(int n){
        // if(_hand[n] ? null) Debug.Log("うれません");
        //売却
        MoneyManager.I.Add(_hand[n]);

        _hand.RemoveAt(n);
        view.HideAll();
        view.Show(_hand.Count);
        view.Setdata(_hand.Count-1,n);
    }
}
