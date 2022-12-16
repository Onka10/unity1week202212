using System.Collections;
using System;
using UnityEngine;
using UniRx;

public class TownStatusPresenter : Singleton<TownStatusPresenter>
{
    [SerializeField] TownStatusView view;
    [SerializeField] TownStatusModel model;
    public IObservable<Unit> Decided => _decided;
    private readonly Subject<Unit> _decided = new Subject<Unit>();


    private void Start() {
        GameManager.I.InPhase
        .Where(s => s==InGamePhase.Map)
        .Subscribe(s => Ready())
        .AddTo(this);

        GameManager.I.InPhase
        .Where(s => s==InGamePhase.Town)
        .Subscribe(s => view.Setdata(model.nowTown))
        .AddTo(this);
    }

    void Ready(){
        Debug.Log(GameManager.I.Step.Value);
        model.nowTown = MapPresenter.I.GetTownData(GameManager.I.Step.Value);
        _decided.OnNext(Unit.Default);
    }

    public TownData GetMowTownData(){
        return model.nowTown;
    }
}
