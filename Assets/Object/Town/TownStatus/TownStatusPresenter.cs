using System.Collections;
using System;
using UnityEngine;
using UniRx;

public class TownStatusPresenter : MonoBehaviour
{
    [SerializeField] TownStatusView view;
    [SerializeField] TownData firstTown;
    [SerializeField] TownData EndTown;
    [SerializeField] TownData[] t = new TownData[4];

    private TownData nowTown;

    public IObservable<Unit> Decided => _decided;
    private readonly Subject<Unit> _decided = new Subject<Unit>();

    private void Start() {
        GameManager.I.State
        .Where(s => s==GameState.Town)
        .Subscribe(_ => Ready())
        .AddTo(this);
    }

    void Ready(){
        //最初の町
        if(GameManager.I.Step.Value == 0){
            TownData td = firstTown;
            nowTown = td;
            view.Setdata(td);
        }else if(GameManager.I.Step.Value == GameManager.MaxTownCount){//最後の町
            TownData td = EndTown;
            nowTown = td;
            view.Setdata(td);
        }else{
            TownData td = t[UnityEngine.Random.Range(0,4)];
            nowTown = td;
            view.Setdata(td);
        }

        _decided.OnNext(Unit.Default);
    }

    public TownData GetTownData(){
        return nowTown;
    }
}
