using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class BookPresenter : MonoBehaviour
{
    [SerializeField] BookView view;

    private void Start() {
        view.Hide();

        GameManager.I.MapTown
        .Where(mt => mt==InGameSate.Town)
        .Subscribe(_ => hoge())
        .AddTo(this);

        GameManager.I.MapTown
        .Where(mt => mt==InGameSate.Map)
        .Subscribe(_ => view.Hide())
        .AddTo(this);
    }

    void hoge(){
        view.SetText("町に着きました");
        StartCoroutine("ChangeT");
    }

    IEnumerator ChangeT()
    {
        yield return new WaitForSeconds(2);
        view.Hide();
    }
}
