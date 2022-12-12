using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopView : MonoBehaviour
{
    [SerializeField] Button Item1;
    [SerializeField] Button Item2;
    [SerializeField] Button Item3;

    public void SetItem(int a,int b,int c){
        Item1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.ToString();
        Item2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = b.ToString();    
        Item3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = c.ToString();           
    }
}
