using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStringSS
{
    /// <summary>
    /// stateからstringに変換
    /// </summary>
    public static string EnumToString(State s){
        return Sate2StringDict[s];
    }

    public static string EnumToString2(TownType s){
        return Sate2StringDict2[s];
    }

    static private Dictionary<State, string> Sate2StringDict= new Dictionary<State, string>(){
        {State.hunger ,"食糧難"},
        {State.popular ,"流行"},
        {State.economy ,"景気"},
        {State.None ,"なし"},
    };

    static private Dictionary<TownType, string> Sate2StringDict2= new Dictionary<TownType, string>(){
        {TownType.Kingdom ,"王都"},
        {TownType.Desert ,"砂漠の町"},
        {TownType.Port ,"港町"},
        {TownType.industrialCity,"工業都市"},
        {TownType.MyTown,"最初の町"}
    };
}
