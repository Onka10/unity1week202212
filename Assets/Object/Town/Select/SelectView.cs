using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectView : MonoBehaviour
{
    [SerializeField] List<GameObject> _actions = new List<GameObject>(3);


    public void SetItem(Action a,Action b, Action c){

        Action[] It = new Action[3];
        It[0] = a;
        It[1] = b;
        It[2] = c;

        for(int i=0;i<_actions.Count;i++){
            _actions[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = It[i].actionName;
            _actions[i].transform.GetChild(1).GetComponent<Image>().sprite = It[i].image;
            // Items[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = It[i].price.ToString();
        }     
    }

    public void Hide(int i){
        _actions[i].SetActive(false);
    }

    public void ShowAll(){
        for(int i=0;i<_actions.Count;i++){
            _actions[i].SetActive(true);
        }
    }
}
