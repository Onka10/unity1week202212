using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TownStatusPresenter : MonoBehaviour
{
    [SerializeField] TownStatusView view;

    [SerializeField] TownData t1;
    [SerializeField] TownData t2;

    private void Start() {
        GameManager.I.State
        .Where(s => s==GameState.Town)
        .Subscribe(_ => Ready())
        .AddTo(this);
    }

    void Ready(){
        TownData td = t1;
        view.Setdata(td);
    }
}
