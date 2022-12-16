using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GameManager : Singleton<GameManager>
{
    public static int MaxTownCount=5;
    public IReadOnlyReactiveProperty<GamePhase> Phase => _state;
    private readonly ReactiveProperty<GamePhase> _state = new ReactiveProperty<GamePhase>(global::GamePhase.Title);


    public IReadOnlyReactiveProperty<InGamePhase> InPhase => _instate;
    private readonly ReactiveProperty<InGamePhase> _instate = new ReactiveProperty<InGamePhase>(global::InGamePhase.OutGame);


    public IReadOnlyReactiveProperty<int> Step => step;
    private readonly ReactiveProperty<int> step = new ReactiveProperty<int>(0);
  

    private void Update() {
        // if(Input.GetKeyDown(KeyCode.N)) _state.Value = GameState.Town;
        // Debug.Log(step.Value);
    }
    public void Play(){
        _state.Value = GamePhase.InGame;
        _instate.Value = InGamePhase.Map;
    }

    public void ToTown(){
        _instate.Value = InGamePhase.BookIn;
    }

    public void ToNextInTown(){
        _instate.Value++;
    }

    public void ToMap(){
        step.Value +=1;
        _instate.Value = InGamePhase.Map;
    }

    // public void ToTown(){
    //     _instate.Value = InGamePhase.Town;
    // }



    public void Finish(){
        _state.Value = GamePhase.Result;
    }
}

public enum GamePhase{
    Title,
    InGame,
    Result
}

public enum InGamePhase{
    Map,
    BookIn,
    Town,
    BookOut,
    OutGame
}
