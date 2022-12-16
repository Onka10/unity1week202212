using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TownLook : MonoBehaviour
{
    [SerializeField] MeshRenderer renderer;
    [SerializeField] MapPresenter mapP;
    void Start()
    {
        GameManager.I.InPhase
        .Where(s => s==InGamePhase.Town)
        .Subscribe(s => Change(s))
        .AddTo(this);
    }

    void Change(InGamePhase s){
        renderer.material = mapP.GetTownData(GameManager.I.Step.Value).BackGround;
    }
}
