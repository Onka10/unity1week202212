using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class HandePresenter : MonoBehaviour
{
    // [SerializeField] ShopPresenter shopP;
    [SerializeField] MyItemsPresenter myItemsP;
    [SerializeField] int ID;
    void Start()
    {
        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Subscribe(_ => myItemsP.Sell(ID))
        .AddTo(this);   
    }
}
