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
        GameManager.I.MapTown
        .Where(s => s==InGameSate.Town)
        .Subscribe(s => Change(s))
        .AddTo(this);
    }

    void Change(InGameSate s){
        renderer.material = mapP.GetTownData(GameManager.I.Step.Value).BackGround;
    }
}
