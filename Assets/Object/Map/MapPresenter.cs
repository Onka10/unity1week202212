using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MapPresenter : Singleton<MapPresenter>
{
    [SerializeField] TownData firstTown;
    [SerializeField] TownData EndTown;
    [SerializeField] TownData[] towndata = new TownData[4];

    [SerializeField] List<TownData> TownList = new List<TownData>();
    private void Start() {
        GameManager.I.Phase
        .Where(s => s==GamePhase.Title)
        .Subscribe(_ => Ready())
        .AddTo(this);

        GameManager.I.InPhase
        .Where(s => s==InGamePhase.Map)
        .Subscribe(_ =>{
            StartCoroutine("ChangeT");
        })
        .AddTo(this);
    }

    void Ready(){
        TownList.Add(firstTown);
        for(int i=0;i<GameManager.MaxTownCount-1;i++){
            TownList.Add(towndata[i]);
        }
        TownList.Add(EndTown);
    }

    public TownData GetTownData(int i){
        return TownList[i];
    }


    IEnumerator ChangeT()
    {
        yield return new WaitForSeconds(2);
        GameManager.I.ToTown();
    }
}
