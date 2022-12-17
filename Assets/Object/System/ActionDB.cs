using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDB : Singleton<ActionDB>
{
    [SerializeField] List<Action> Lis = new List<Action>();
    [SerializeField] List<Action> Final = new List<Action>();

    public Action GetRandomAction(){  
        var r = Random.Range(0,5);
        return Lis[r];
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