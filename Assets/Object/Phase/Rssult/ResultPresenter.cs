using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

public class ResultPresenter : MonoBehaviour
{
    [SerializeField] ResultView view;

    private void Start() {
        view.Hide();

        GameManager.I.Phase
        .Where(mt => mt==GamePhase.Result)
        .Subscribe(_ => Result1().Forget())
        .AddTo(this);
    }

    private async UniTaskVoid Result1(){
        PlayerManager.I.Finish();
        var data = PlayerManager.I.GetData();
        

        view.SetText("こうして私は旅を終えて私の町へと帰ってきた");
        await UniTask.Delay(2000);
        view.SetText("しかし、結局記憶は戻らなかった");
        await UniTask.Delay(2000);
        view.SetText("町の住人から話を聞くと");
        await UniTask.Delay(2000);
        view.SetText("私はどうやら"+ data.Rank +"人間らしい");
        await UniTask.Delay(2000);
        view.SetText("それが分かっただけでも今はいいじゃないか");
        await UniTask.Delay(2000);
        view.SetText("そうして私の旅は終わった");
    }

}
