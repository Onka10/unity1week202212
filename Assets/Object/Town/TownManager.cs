using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TownManager : Singleton<TownManager>
{
    public IReadOnlyReactiveProperty<TownPhase> Phase => _state;
    private readonly ReactiveProperty<TownPhase> _state = new ReactiveProperty<TownPhase>(TownPhase.Start);
}

public enum TownPhase{
    Start,
    Main,
    Last
}