using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GameManager : Singleton<GameManager>
{
    public static int MaxTownCount=5;
    public IReadOnlyReactiveProperty<GamePhase> Phase => _state;
    private readonly ReactiveProperty<GamePhase> _state = new ReactiveProperty<GamePhase>(GamePhase.Title);


    public IReadOnlyReactiveProperty<InGameSate> MapTown => _mt;
    private readonly ReactiveProperty<InGameSate> _mt = new ReactiveProperty<InGameSate>(InGameSate.OutGame);


    public IReadOnlyReactiveProperty<int> Step => step;
    private readonly ReactiveProperty<int> step = new ReactiveProperty<int>(0);
  

    private void Update() {
        // if(Input.GetKeyDown(KeyCode.N)) _state.Value = GameState.Town;
    }

    public void ToMap(){
        _mt.Value = InGameSate.Map;
        step.Value++;
        Debug.Log(step.Value);
    }

    public void ToTown(){
        _mt.Value = InGameSate.Town;
    }

    public void Play(){
        _state.Value = GamePhase.InGame;
        _mt.Value = InGameSate.Town;
    }

    public void Finish(){
        _state.Value = GamePhase.Result;
    }
}

public enum GamePhase{
    Title,
    InGame,
    Result
}

public enum InGameSate{
    Map,
    Town,
    OutGame
}
