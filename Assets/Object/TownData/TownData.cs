using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObject/TownData")]
public class TownData : ScriptableObject
{
    [SerializeField] public TownType Type;
    [SerializeField] public State status1;
    [SerializeField] public ItemType Production;//売り物
    [SerializeField] public ItemType Demand;//需要
    [SerializeField] public Material BackGround;

}

public enum TownType{
    Desert,
    Port,
    Kingdom,
    industrialCity,
    MyTown,
    
}

public enum State{
    hunger,//うえ
    popular,//流行
    economy,//景気
    None,
}