using UniRx;
using UnityEngine;

public class ModelChanger :Singleton<ModelChanger>
{
    [SerializeField] GameObject BackGround;
    [SerializeField] GameObject Map;

    private void Start() {
        GameManager.I.State
        .Subscribe(s => Change(s))
        .AddTo(this);
    }

    void Change(GameState s){
        if(s==GameState.Map){
            BackGround.SetActive(false);
            Map.SetActive(true);
        }else{
            Map.SetActive(false);
            BackGround.SetActive(true);
        }
    }

}
