using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using TMPro;

public class NextButton : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Where(_ => GameManager.I.Step.Value <= GameManager.MaxTownCount)
        .Subscribe(_ => GameManager.I.ToMap())
        .AddTo(this);   

        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Where(_ => GameManager.I.Step.Value > GameManager.MaxTownCount)
        .Subscribe(_ => GameManager.I.Finish())
        .AddTo(this);  


        GameManager.I.InPhase
        .Where(_ => GameManager.I.Step.Value == GameManager.MaxTownCount)
        .Subscribe(_ =>{
            this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "旅を終える";
        })
        .AddTo(this);
    }
}
