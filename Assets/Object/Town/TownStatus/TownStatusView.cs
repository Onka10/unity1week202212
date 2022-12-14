using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TownStatusView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TownName;
    [SerializeField] TextMeshProUGUI st1;

    public void Setdata(TownData td){
        TownName.text = ToStringSS.EnumToString2(td.Type);
        st1.text = ToStringSS.EnumToString(td.status1);
    }

}
