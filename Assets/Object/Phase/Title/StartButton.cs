using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace Title
{
    public class StartButton : MonoBehaviour
    {
        void Start()
        {
            this.gameObject.GetComponent<Button>().OnClickAsObservable()
            .Subscribe(_ => GameManager.I.Play())
            .AddTo(this);  
        }

    }
}

