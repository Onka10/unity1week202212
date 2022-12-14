using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CanvasChanger : Singleton<CanvasChanger>
{
    // [SerializeField] GameState state;
    [SerializeField] GameObject title;
    [SerializeField] GameObject town;
    [SerializeField] GameObject map;
    [SerializeField] GameObject result;
    

    private void Start() {
        GameManager.I.MapTown
        .Subscribe(s => Change(s))
        .AddTo(this);


        GameManager.I.Phase
        .Subscribe(s => ChangePhase(s))
        .AddTo(this);
    }


    void Change(InGameSate s){
        if(s==InGameSate.Map){
            town.SetActive(false);
            map.SetActive(true);
        }else if(s==InGameSate.Town){
            map.SetActive(false);
            town.SetActive(true);
        }else{
            map.SetActive(false);
            town.SetActive(false);
        }
    }

    void ChangePhase(GamePhase s){
        if(s==GamePhase.Title){
            title.SetActive(true);
        }else if(s==GamePhase.Result){
            result.SetActive(true);
        }else{
            title.SetActive(false);
            result.SetActive(false);
        }
    }
}
