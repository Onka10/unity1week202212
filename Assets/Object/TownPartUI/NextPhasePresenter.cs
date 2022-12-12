using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class NextPhasePresenter : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Subscribe(_ => GameManager.I.ToMove())
        .AddTo(this);   
    }
}
