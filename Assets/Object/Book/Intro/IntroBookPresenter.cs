using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

public class IntroBookPresenter : MonoBehaviour
{
    [SerializeField] IntroBookView view;

    private void Start() {
        GameManager.I.Phase
        .Where(mt => mt==GamePhase.Intro)
        .Subscribe(_ => Intro().Forget())
        .AddTo(this);
    }

    private async UniTaskVoid Intro(){
        view.SetText("気がつくと見慣れぬ土地に立っていた");
        await UniTask.Delay(2000);
        view.SetText("私は誰だか思い出せない");
        await UniTask.Delay(2000);
        view.SetText("私は誰なのかを知るために");
        await UniTask.Delay(2000);
        view.SetText("歩きはじめた");
        await UniTask.Delay(2000);
        // await UniTask.Delay(100);
        GameManager.I.EndIntro();
    }
}
