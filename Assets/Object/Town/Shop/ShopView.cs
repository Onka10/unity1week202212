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
        Item1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.ItemName;
        Item2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.ItemName;   
        Item3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.ItemName;  

        Item1.transform.GetChild(1).GetComponent<Image>().sprite = a.image;
        Item2.transform.GetChild(1).GetComponent<Image>().sprite = b.image;  
        Item3.transform.GetChild(1).GetComponent<Image>().sprite = c.image;

        Item1.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = a.price.ToString();
        Item2.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = b.price.ToString();    
        Item3.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = c.price.ToString();         
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
