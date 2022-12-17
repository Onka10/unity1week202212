using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStringSS
{
    /// <summary>
    /// stateからstringに変換
    /// </summary>
    public static string EnumToString2(TownType s){
        return Sate2StringDict2[s];
    }

    public static string EnumToStringAction(ActionType a){
        return ActionStringDict[a];
    }

    static private Dictionary<TownType, string> Sate2StringDict2= new Dictionary<TownType, string>(){
        {TownType.Kingdom ,"王都"},
        {TownType.Desert ,"砂漠の町"},
        {TownType.Port ,"港町"},
        {TownType.Meadow,"放牧地"},
        {TownType.MyTown,"見覚えのある町"},
        {TownType.StartPoint,"小さな集落"}
    };

    static private Dictionary<ActionType, string> ActionStringDict= new Dictionary<ActionType, string>(){
        {ActionType.Extraversion ,"外交的な"},
        {ActionType.Agreeableness  ,"優しい"},
        {ActionType.Conscientiousness  ,"誠実な"},
        {ActionType.Neuroticism ,"落ち着いた"},
        {ActionType.Openness ,"創造的な"},
    };
}
