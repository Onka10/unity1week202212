using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TownStatusPresenter : MonoBehaviour
{
    [SerializeField] TownStatusView view;
    [SerializeField] TownData[] t = new TownData[4];

    [SerializeField] TownData NowTown;

    private void Start() {
        GameManager.I.State
        .Where(s => s==GameState.Town)
        .Subscribe(_ => Ready())
        .AddTo(this);
    }

    void Ready(){
        TownData td = t[Random.Range(0,4)];
        NowTown = td;
        view.Setdata(td);
    }
}
