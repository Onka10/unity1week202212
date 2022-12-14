using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MapPresenter : MonoBehaviour
{
    [SerializeField] TownData firstTown;
    [SerializeField] TownData EndTown;
    [SerializeField] TownData[] t = new TownData[4];

    [SerializeField] List<TownData> TownList = new List<TownData>();
    private void Start() {
        GameManager.I.Phase
        .Where(s => s==GamePhase.Title)
        .Subscribe(_ => Ready())
        .AddTo(this);
    }

    void Ready(){
        TownList.Add(firstTown);
        for(int i=0;i<GameManager.MaxTownCount;i++){
            TownList.Add(t[Random.Range(0,4)]);
        }
        TownList.Add(EndTown);
    }

    public TownData GetTownData(int i){
        return TownList[i];
    }
}