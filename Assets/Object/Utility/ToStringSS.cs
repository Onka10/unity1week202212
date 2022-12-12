using System.Collections;
using System.Collections.Generic;

public class ToStringSS
{
    /// <summary>
    /// stateからstringに変換
    /// </summary>
    public static string EnumToString(State s){
        return Sate2StringDict[s];
    }

    static private Dictionary<State, string> Sate2StringDict= new Dictionary<State, string>(){
        {State.hunger ,"食糧難"},
        {State.popular ,"流行"},
        {State.economy ,"景気"},
    };
}
