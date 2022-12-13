using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CanvasChanger : Singleton<CanvasChanger>
{
    // [SerializeField] GameState state;
    [SerializeField] GameObject move;
    [SerializeField] GameObject town;

    private void Start() {
        GameManager.I.State
        .Subscribe(s => Change(s))
        .AddTo(this);
    }

    void Change(GameState s){
        if(s==GameState.Map){
            move.SetActive(true);
            town.SetActive(false);
        }else{
            move.SetActive(false);
            town.SetActive(true);           
        }
    }
}
