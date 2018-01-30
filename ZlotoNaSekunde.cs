using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZlotoNaSekunde : MonoBehaviour {

    public UnityEngine.UI.Text znsDisplay;
    public Klik klik;
    public PrzedmiotMenager[] przedmioty;

    void Start()
    {
        StartCoroutine(AutomatycznyTick());
    }
    //----------------------------------------------------------------
    void Update()
    {
        znsDisplay.text = ZlotoNaSek() + " zloto/sek";
    }
    //----------------------------------------------------------------
    public float ZlotoNaSek()
    {
        float tick = 0;
        foreach (PrzedmiotMenager przedmiot in przedmioty) {
            tick += przedmiot.count * przedmiot.wartosc;
        }
        return tick;
    }
    //----------------------------------------------------------------
        public void AutomatycznyGoldNaSekunde()
    {
        klik.zloto += ZlotoNaSek() / 10;
    }
    //----------------------------------------------------------------
     IEnumerator AutomatycznyTick()
    {
        while (true)
        {
            AutomatycznyGoldNaSekunde();
            yield return new WaitForSeconds(0.10f);
        }
    }
    }
