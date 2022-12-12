using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopView : MonoBehaviour
{
    [SerializeField] GameObject Item1;
    [SerializeField] GameObject Item2;
    [SerializeField] GameObject Item3;

    public void SetItem(int a,int b,int c){
        Item1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.ToString();
        Item2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = b.ToString();    
        Item3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = c.ToString();           
    }

    public void Hide(int i){
        if(i==1)    Item1.SetActive(false);
        if(i==2)    Item2.SetActive(false);
        if(i==3)    Item3.SetActive(false);
    }

    public void ShowAll(){
        Item1.SetActive(true);
        Item2.SetActive(true);
        Item3.SetActive(true);
    }
}
