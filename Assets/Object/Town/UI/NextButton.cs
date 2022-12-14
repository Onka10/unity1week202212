using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class NextButton : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Where(_ => GameManager.I.Step.Value != GameManager.MaxTownCount)
        .Subscribe(_ => GameManager.I.ToMap())
        .AddTo(this);   

        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Where(_ => GameManager.I.Step.Value == GameManager.MaxTownCount)
        .Subscribe(_ => GameManager.I.Finish())
        .AddTo(this);  
    }
}
