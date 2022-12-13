using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TownStatusPresenter : MonoBehaviour
{
    [SerializeField] TownStatusView view;
    [SerializeField] TownData firstTown;
    [SerializeField] TownData EndTown;
    [SerializeField] TownData[] t = new TownData[4];

    [SerializeField] TownData NowTown;

    private void Start() {
        GameManager.I.State
        .Where(s => s==GameState.Town)
        .Subscribe(_ => Ready())
        .AddTo(this);
    }

    void Ready(){
        if(GameManager.I.Step.Value == 0){
            TownData td = firstTown;
            NowTown = td;
            view.Setdata(td);

        }else if(GameManager.I.Step.Value == GameManager.MaxTownCount){
            TownData td = EndTown;
            NowTown = td;
            view.Setdata(td);
        }else{
            TownData td = t[Random.Range(0,4)];
            NowTown = td;
            view.Setdata(td);
        }
        

        
    }
}
