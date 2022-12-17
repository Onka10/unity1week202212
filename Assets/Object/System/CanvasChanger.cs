using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CanvasChanger : Singleton<CanvasChanger>
{
    // [SerializeField] GameState state;
    [SerializeField] GameObject intro;
    [SerializeField] GameObject title;
    [SerializeField] GameObject town;
    [SerializeField] GameObject map;
    [SerializeField] GameObject result;
    

    private void Start() {
        GameManager.I.InPhase
        .Subscribe(s => Change(s))
        .AddTo(this);


        GameManager.I.Phase
        .Subscribe(s =>{
            if(s==GamePhase.Intro) intro.SetActive(true);
            else  intro.SetActive(false);
        })
        .AddTo(this);

        GameManager.I.Phase
        .Subscribe(s =>{
            if(s==GamePhase.Title) title.SetActive(true);
            else  title.SetActive(false);
        })
        .AddTo(this);

        GameManager.I.Phase
        .Subscribe(s =>{
            if(s==GamePhase.Result) result.SetActive(true);
            else  result.SetActive(false);
        })
        .AddTo(this);
    }


    void Change(InGamePhase s){
        if(s==InGamePhase.Map){
            town.SetActive(false);
            map.SetActive(true);
        }else if(s==InGamePhase.Town){
            map.SetActive(false);
            town.SetActive(true);
        }else{
            map.SetActive(false);
            town.SetActive(false);
        }
    }
}
