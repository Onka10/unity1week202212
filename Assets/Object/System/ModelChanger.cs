using UniRx;
using UnityEngine;
using DG.Tweening; 
using Cysharp.Threading.Tasks;

public class ModelChanger :Singleton<ModelChanger>
{
    [SerializeField] MeshRenderer rend;
    float ff=0;

    private void Start() {
        GameManager.I.InPhase
        .Where(s => s==InGamePhase.Map)
        .Subscribe(s => Change().Forget())
        .AddTo(this);

    }

    private async UniTaskVoid Change(){
        //1秒かけてffを1まで変化させる
        DOTween.To(() => ff, (x) => ff = x, 1f, 1);
        await UniTask.Delay(2000);
        DOTween.To(() => ff, (x) => ff = x, 0f, 1);
    }

    private void Update() {
        rend.material.SetFloat("_Transition",ff);
    }

}
