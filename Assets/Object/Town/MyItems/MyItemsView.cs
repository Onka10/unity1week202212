using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyItemsView : MonoBehaviour
{
    [SerializeField] List<GameObject> Hands = new List<GameObject>(7);

    /// <summary>
    /// 非表示
    /// </summary>
    public void HideAll()
    {
        for(int i=0;i<Hands.Count;i++){
            Hands[i].GetComponent<Image>().color = Color.black;
            Hands[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
        }
        
    }

    /// <summary>
    /// 表示
    /// </summary>
    public void Show(int max)
    {
        for(int i=0;i<max;i++){
            Hands[i].GetComponent<Image>().color = Color.white;
        }
    }

    public void Setdata(int i,int p){
        Hands[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = p.ToString();
    }
}
