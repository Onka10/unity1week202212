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

    public void SetItem(Item a,Item b,Item c){
        //名前・画像・価格
        Item1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.itemName;
        Item2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = b.itemName;   
        Item3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = c.itemName;  

        Item1.transform.GetChild(1).GetComponent<Image>().sprite = a.image;
        Item2.transform.GetChild(1).GetComponent<Image>().sprite = b.image;  
        Item3.transform.GetChild(1).GetComponent<Image>().sprite = c.image;

        Item1.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Cal.I.CalcPrice(a).ToString();
        Item2.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Cal.I.CalcPrice(b).ToString();  
        Item3.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Cal.I.CalcPrice(c).ToString();        
    }

    public void Hide(int i){
        if(i==0)    Item1.SetActive(false);
        if(i==1)    Item2.SetActive(false);
        if(i==2)    Item3.SetActive(false);
    }

    public void ShowAll(){
        Item1.SetActive(true);
        Item2.SetActive(true);
        Item3.SetActive(true);
    }
}
