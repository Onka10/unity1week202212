using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string Rank;
    List<Action> actionLog;

    public PlayerData(){
        actionLog = new List<Action>();
    }

    public void Add(Action a){
        actionLog.Add(a);
    }

    public void Finish(){
        Rank = ToStringSS.EnumToStringAction(actionLog[0].type);
    }
}
