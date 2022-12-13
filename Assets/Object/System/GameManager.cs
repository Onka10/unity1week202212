using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GameManager : Singleton<GameManager>
{
    public static int MaxTownCount=5;
    public IReadOnlyReactiveProperty<GameState> State => _state;
    private readonly ReactiveProperty<GameState> _state = new ReactiveProperty<GameState>(GameState.Title);
    public IReadOnlyReactiveProperty<int> Step => step;
    private readonly ReactiveProperty<int> step = new ReactiveProperty<int>(0);
  

    private void Update() {
        // if(Input.GetKeyDown(KeyCode.N)) _state.Value = GameState.Town;
    }

    public void ToMap(){
        _state.Value = GameState.Map;
        step.Value++;
        Debug.Log(step.Value);
    }

    public void ToTown(){
        _state.Value = GameState.Town;
    }

    public void ToResult(){
        _state.Value = GameState.Result;
    }
}

public enum GameState{
    Title,
    Map,
    Town,
    Result
}
