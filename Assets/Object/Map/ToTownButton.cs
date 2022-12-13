using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class ToTownButton : MonoBehaviour
{
    [SerializeField] int step;
    void Start()
    {
        this.gameObject.GetComponent<Button>().OnClickAsObservable()
        .Where(_ => GameManager.I.Step.Value == step)
        .Subscribe(_ => GameManager.I.ToTown())
        .AddTo(this);   
    }
}
