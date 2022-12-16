using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class SelectButton : MonoBehaviour
{
    [SerializeField] int ID;

    void Start()
    {
        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Subscribe(_ => SelectPresenter.I.Act(ID))
        .AddTo(this);   
    }
}
