using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GameManager : Singleton<GameManager>
{
    public IReadOnlyReactiveProperty<GameState> State => _state;
    private readonly ReactiveProperty<GameState> _state = new ReactiveProperty<GameState>(GameState.Move);
    public IReadOnlyReactiveProperty<int> Step => step;
    private readonly ReactiveProperty<int> step = new ReactiveProperty<int>(1);  

    private void Update() {
        // if(Input.GetKeyDown(KeyCode.N)) _state.Value = GameState.Town;
    }

    public void ToMove(){
        _state.Value = GameState.Move;
        step.Value++;
    }

    public void ToTown(){
        _state.Value = GameState.Town;
    }
}

public enum GameState{
    Move,
    Town
}
