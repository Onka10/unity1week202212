using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Item")]
public class Item : ScriptableObject
{
    [SerializeField] public ItemType type;
    [SerializeField] public string ItemName;
    [SerializeField] public int price;
}

public enum ItemType{
    Food,
    IndustrialGoods,
    Entertainment,
}