using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    PlayerData playerData;

    public PlayerData GetData(){
        return new PlayerData();
    }
}
