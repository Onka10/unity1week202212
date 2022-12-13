using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class BuyButton : MonoBehaviour
{
    [SerializeField] ShopPresenter shopPresenter;
    [SerializeField] int ID;

    void Start()
    {
        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Subscribe(_ => shopPresenter.Buy(ID))
        .AddTo(this);   
    }
}
