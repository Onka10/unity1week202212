using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectModel : MonoBehaviour
{
    private Action[] actions = new Action[3];

    public void ShopModelG(TownType it){
        if(it == TownType.MyTown){
            actions[0]= ActionDB.I.GetFinalAction(0);
            actions[1]= ActionDB.I.GetFinalAction(1);
            actions[2]= ActionDB.I.GetFinalAction(2);
        }else{
            actions[0]= ActionDB.I.GetRandomAction(it);
            actions[1]= ActionDB.I.GetRandomAction(it);
            actions[2]= ActionDB.I.GetRandomAction(it);
        }


    }

    public Action GetAction(int i){
        return actions[i];
    }
}
