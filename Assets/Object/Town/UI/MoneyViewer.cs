using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UniRx;

public class MoneyViewer : MonoBehaviour
{
    [SerializeField]  private TextMeshProUGUI _money;


    private void Start() {
        MoneyManager.I.Money
        .Subscribe(s => SetScore(s.ToString()))
        .AddTo(this);
    }

    void SetScore(string s)
    {
        _money.text = s;
    }
}
