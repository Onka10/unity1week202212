using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class BookPresenter : Singleton<BookPresenter>
{
    [SerializeField] BookView view;

    private void Start() {
        view.Hide();

        GameManager.I.InPhase
        .Where(mt => mt==InGamePhase.BookIn)
        .Subscribe(_ => In())
        .AddTo(this);

        GameManager.I.InPhase
        .Where(mt => mt==InGamePhase.Map)
        .Subscribe(_ => view.Hide())
        .AddTo(this);


        GameManager.I.InPhase
        .Where(mt => mt==InGamePhase.BookOut)
        .Subscribe(_ => Out())
        .AddTo(this);
    }

    void In(){
        var town = TownStatusPresenter.I.GetMowTownData(); 
        view.SetText(ToStringSS.EnumToString2(town.Type) + "へたどり着いた");
        if(town.Type==TownType.MyTown) StartCoroutine("ChangeIR");
        else StartCoroutine("ChangeI");
    }
    IEnumerator ChangeI()
    {
        yield return new WaitForSeconds(2);
        view.Hide();
        GameManager.I.ToNextInTown();
    }    
    IEnumerator ChangeIR()
    {
        yield return new WaitForSeconds(2);
        view.SetText("町の住人に迎え入れられた");
        yield return new WaitForSeconds(2);
        view.SetText("どうやらここが私の町らしい");
        yield return new WaitForSeconds(2);
        view.Hide();
        GameManager.I.Finish();
    }
    
    void Out(){
        view.SetText(SelectPresenter.I.GetNowAction().bookText);
        StartCoroutine("ChangeO");
    }

    IEnumerator ChangeO()
    {
        yield return new WaitForSeconds(2);
        var st = ToStringSS.EnumToStringAction(SelectPresenter.I.GetNowAction().type);
        view.SetText("私は"+st+"人間だったのかもしれない");
        yield return new WaitForSeconds(2);
        view.Hide();

        GameManager.I.ToMap();
    }
}
