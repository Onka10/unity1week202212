using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using TMPro;

namespace Kari
{
    public class Testnannka : MonoBehaviour
    {
        [SerializeField] MapPresenter mapp;
        [SerializeField] int id;
        void Start()
        {

            GameManager.I.Step
            .Where(s => id < s)
            .Subscribe(s =>{
                this.gameObject.GetComponent<Image>().color = Color.red;
                this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text ="済";
            })
            .AddTo(this);


            GameManager.I.Phase
            .Where(s => s==GamePhase.InGame)
            .Subscribe(_ =>{
               this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = ToStringSS.EnumToString2(mapp.GetTownData(id).type);
            })
            .AddTo(this);
        }
    }
}

