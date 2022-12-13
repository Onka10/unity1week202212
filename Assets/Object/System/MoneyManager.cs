using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MoneyManager : Singleton<MoneyManager>
{
    public IReadOnlyReactiveProperty<int> Money => money;
    private readonly ReactiveProperty<int> money = new ReactiveProperty<int>(1000);  

    public void Set(int m){
        money.Value = m;
    }

    public void Add(int m){
        money.Value += m;
    }

    public void Minus(int m){
        money.Value -= m;
    }

    public void Reset(){
        money.Value = 0;
    }
}
