using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookView : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _textobj; //startが呼ばれんかもやから手動


    //テキストを設定
    public void SetText(string text)
    {
        gameObject.SetActive(true);
        _textobj.text = text;
    }

    public void Hide(){
        gameObject.SetActive(false);
    }

}
