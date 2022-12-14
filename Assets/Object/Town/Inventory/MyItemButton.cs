using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class MyItemButton : MonoBehaviour
{
    [SerializeField] InventoryPresenter myItemsP;
    [SerializeField] int ID;
    void Start()
    {
        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Where(_ => GameManager.I.MapTown.Value == InGameSate.Town)
        .Subscribe(_ => myItemsP.Sell(ID))
        .AddTo(this);   
    }
}
