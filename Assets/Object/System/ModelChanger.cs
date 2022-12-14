using UniRx;
using UnityEngine;

public class ModelChanger :Singleton<ModelChanger>
{
    [SerializeField] GameObject BackGround;
    [SerializeField] GameObject Map;

    private void Start() {
        GameManager.I.MapTown
        .Subscribe(s => Change(s))
        .AddTo(this);

        GameManager.I.Phase
        .Subscribe(s => ChangePhase(s))
        .AddTo(this);
    }

    void Change(InGameSate s){
        if(s==InGameSate.Map){
            BackGround.SetActive(false);
            Map.SetActive(true);
        }else{
            Map.SetActive(false);
            BackGround.SetActive(true);
        }
    }

    void ChangePhase(GamePhase s){
        if(s==GamePhase.InGame) return;
        
        Map.SetActive(false);
        BackGround.SetActive(true);       
    }

}
