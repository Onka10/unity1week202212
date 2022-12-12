using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObject/TownData")]
public class TownData : ScriptableObject
{
    [SerializeField] public string TownName;
    [SerializeField] public State status1;
    [SerializeField] public State status2;

}

public enum State{
    hunger,//うえ
    popular,//流行
    economy//景気
}