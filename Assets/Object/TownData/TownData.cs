using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObject/TownData")]
public class TownData : ScriptableObject
{
    [SerializeField] public TownType Type;
    [SerializeField] public Material BackGround;

}

public enum TownType{
    Desert,
    Port,
    Kingdom,
    industrialCity,
    MyTown,
    FirstTown,
    
}