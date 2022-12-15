using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SellComponent : MonoBehaviour
{
    public void ShowPlus(int a){
        gameObject.SetActive(true);
        this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.ToString();
        this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.red;
    }

    public void ShowMinus(int a){
        gameObject.SetActive(true);
        this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = a.ToString();
        this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.blue;
    }

    public void Hide(){
        gameObject.SetActive(false);
    }
}
