using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObject/TownData")]
public class TownData : ScriptableObject
{
    [SerializeField] string TownName;
    [SerializeField] public Status status;

}