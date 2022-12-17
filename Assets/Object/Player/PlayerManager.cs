using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    PlayerData playerData;

    void Start(){
        playerData = new PlayerData();
    }

    public PlayerData GetData(){
        return playerData;
    }

    public void AddData(Action act){
        playerData.Add(act);
    }

    public void Finish(){
        playerData.Finish();
        // Debug.Log(playerData.Rank);
    }
}
