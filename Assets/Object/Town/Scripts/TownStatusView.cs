using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TownStatusView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TownName;
    [SerializeField] TextMeshProUGUI st1;
    [SerializeField] TextMeshProUGUI st2;

    public void Setdata(TownData td){
        TownName.text = td.TownName;
        st1.text = ToStringSS.EnumToString(td.status1);
        st2.text = ToStringSS.EnumToString(td.status2);

    }

}
