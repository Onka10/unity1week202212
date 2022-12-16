using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopView : MonoBehaviour
{
    [SerializeField] List<GameObject> Items = new List<GameObject>(3);


    private void Start() {
        // for(int i=0;i<Items.Count;i++){
        //     Items[i] = gameObject.transform.GetChild(i).gameObject;
        // }
    }

    public void SetItem(Item a,Item b, Item c){
        // Debug.Log(a.name);

        Item[] It = new Item[3];
        It[0] = a;
        It[1] = b;
        It[2] = c;

        for(int i=0;i<Items.Count;i++){
            Items[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = It[i].itemName;
            Items[i].transform.GetChild(1).GetComponent<Image>().sprite = It[i].image;
            Items[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = It[i].price.ToString();

            if(It[i].price < Cal.I.CalcPrice(It[i])) Items[i].transform.GetChild(3).GetComponent<SellComponent>().ShowPlus(Cal.I.CalcPrice(It[i]));
            else if(It[i].price > Cal.I.CalcPrice(It[i])) Items[i].transform.GetChild(3).GetComponent<SellComponent>().ShowMinus(Cal.I.CalcPrice(It[i]));
            else Items[i].transform.GetChild(3).GetComponent<SellComponent>().Hide();
        }


        //名前・画像・価格
        // Item1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.itemName;
        // Item2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = b.itemName;   
        // Item3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = c.itemName;  

        // Item1.transform.GetChild(1).GetComponent<Image>().sprite = a.image;
        // Item2.transform.GetChild(1).GetComponent<Image>().sprite = b.image;  
        // Item3.transform.GetChild(1).GetComponent<Image>().sprite = c.image;

        // Item1.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Cal.I.CalcPrice(a).ToString();
        // Item2.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Cal.I.CalcPrice(b).ToString();  
        // Item3.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Cal.I.CalcPrice(c).ToString();        
    }

    public void Hide(int i){
        Items[i].SetActive(false);
    }

    public void ShowAll(){
        for(int i=0;i<Items.Count;i++){
            Items[i].SetActive(true);
        }
    }
}
