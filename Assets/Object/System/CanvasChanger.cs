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
        GameManager.I.State
        .Subscribe(s => Change(s))
        .AddTo(this);
    }

    void Change(GameState s){
        if(s==GameState.Title){
            title.SetActive(true);
        }else if(s==GameState.Town){
            title.SetActive(false);
            map.SetActive(false);
            town.SetActive(true);  
        }else if(s==GameState.Map){
            town.SetActive(false);
            map.SetActive(true);
        }else{
            town.SetActive(false);
            result.SetActive(true);
        }
    }
}
