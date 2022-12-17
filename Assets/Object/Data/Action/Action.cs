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
    Extraversion,//外向性
    Agreeableness,//協調性
    Conscientiousness,//誠実性
    Neuroticism,//精神的安定性
    Openness//創造性
}