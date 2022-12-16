using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TownStatusView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TownName;

    public void Setdata(TownData td){
        TownName.text = ToStringSS.EnumToString2(td.Type);
    }

}
