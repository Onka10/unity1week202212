using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDB : Singleton<ActionDB>
{
    // [SerializeField] List<Action> Ente = new List<Action>();
    // [SerializeField] List<Action> Food = new List<Action>();
    // [SerializeField] List<Action> Funi = new List<Action>();
    [SerializeField] List<Action> Starter = new List<Action>();
    [SerializeField] List<Action> Final = new List<Action>();

    public Action GetRandomAction(TownType t){
        //FIXME 仮で
        var r = Random.Range(0,4);
        
        return Starter[r];
    }

    public Action GetFinalAction(int n){
        return Final[n];
    }

    // Action GetRandomItemt(){
    //     var r = Random.Range(0,3);

    //     if(r==0) return Food[r];
    //     else if(r==1) return Funi[r];
    //     else  return Ente[r];
    // }

}