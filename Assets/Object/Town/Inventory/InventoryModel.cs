using UnityEngine;
using UniRx;

public class InventoryModel : MonoBehaviour
{
    public IReactiveCollection<Item> MyItems => _hand;
    private readonly ReactiveCollection<Item> _hand = new ReactiveCollection<Item>{};

    public void Add(Item item){
        //ほんとはboolにする
        _hand.Add(item);
    }

    public void Remove(int n){
        _hand.RemoveAt(n);
    }
}