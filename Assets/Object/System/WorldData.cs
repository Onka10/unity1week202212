using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class WorldData : Singleton<WorldData>
{
    //経済
    public float Economy => economy;
    float economy;

    private void Start() {
        GameManager.I.MapTown
        .Subscribe(_ => economy = Random2.Random50())
        .AddTo(this);
    }

}
