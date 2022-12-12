using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CanvasPresenter : MonoBehaviour
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
        if(s==GameState.Move){
            move.SetActive(true);
            town.SetActive(false);
        }else{
            move.SetActive(false);
            town.SetActive(true);           
        }
    }
}
