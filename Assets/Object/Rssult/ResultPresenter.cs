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
        var data = PlayerManager.I.GetData();

        view.SetText("こうして私は旅を終えて私の町へと帰ってきた");
        await UniTask.Delay(2000);
        view.SetText("旅を振り返ってみると");
        await UniTask.Delay(2000);
        view.SetText("私はどうやら"+ data.Rank +"な人間らしい");
    }

}
