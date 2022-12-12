using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GameManager : Singleton<GameManager>
{
    public IReadOnlyReactiveProperty<GameState> State => _state;

    private readonly ReactiveProperty<GameState> _state = new ReactiveProperty<GameState>(GameState.Move);

    private void Update() {
        if(Input.GetKeyDown(KeyCode.N)) _state.Value = GameState.Town;
    }

    public void ToMove(){
        _state.Value = GameState.Move;
    }
}

public enum GameState{
    Move,
    Town
}
