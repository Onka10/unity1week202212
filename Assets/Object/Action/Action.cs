using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Action")]
public class Action : ScriptableObject
{
    
    [SerializeField] public string actionName;
    [SerializeField] public ActionType type;
    [SerializeField] public Sprite image;
}

public enum ActionType{
    H,
    A,
    B,
    S,
}