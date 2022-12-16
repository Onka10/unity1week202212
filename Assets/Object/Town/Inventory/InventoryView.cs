using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryView : MonoBehaviour
{
    [SerializeField] List<GameObject> Hands = new List<GameObject>(7);

    private void Start() {
        for(int i=0;i<Hands.Count;i++){
            Hands[i] = gameObject.transform.GetChild(i).gameObject;
        }

        HideAll();
    }

    /// <summary>
    /// 非表示
    /// </summary>
    public void HideAll()
    {
        for(int i=0;i<Hands.Count;i++){
            Hands[i].GetComponent<Image>().color = Color.black;
            Hands[i].transform.GetChild(0).GetComponent<Image>().color = Color.black;
            Hands[i].transform.GetChild(2).GetComponent<SellComponent>().Hide();
        }
    }

    /// <summary>
    /// 表示
    /// </summary>
    public void Show(int i,Item item)
    {
        //表示
        Hands[i].GetComponent<Image>().color = Color.white;
        Hands[i].transform.GetChild(0).GetComponent<Image>().color = Color.white;

        //アイテム反映
        Hands[i].transform.GetChild(0).GetComponent<Image>().sprite =  item.image;
        Hands[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = item.price.ToString();

        if(item.price < Cal.I.CalcPrice(item)) Hands[i].transform.GetChild(2).GetComponent<SellComponent>().ShowPlus(Cal.I.CalcPrice(item));
        else if(item.price > Cal.I.CalcPrice(item)) Hands[i].transform.GetChild(2).GetComponent<SellComponent>().ShowMinus(Cal.I.CalcPrice(item));
        else Hands[i].transform.GetChild(2).GetComponent<SellComponent>().Hide();
    }
}
