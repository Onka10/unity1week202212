using System.Collections;
using System;
using UnityEngine;
using UniRx;

public class TownStatusPresenter : MonoBehaviour
{
    [SerializeField] TownStatusView view;
    [SerializeField] MapPresenter mapP;

    private TownData nowTown;

    public IObservable<Unit> Decided => _decided;
    private readonly Subject<Unit> _decided = new Subject<Unit>();

    private void Start() {
        GameManager.I.MapTown
        .Where(s => s==InGameSate.Town)
        .Subscribe(s => Ready())
        .AddTo(this);
    }

    void Ready(){
        nowTown = mapP.GetTownData(GameManager.I.Step.Value);
        view.Setdata(nowTown);

        _decided.OnNext(Unit.Default);
    }

    public TownData GetMowTownData(){
        return nowTown;
    }
}
