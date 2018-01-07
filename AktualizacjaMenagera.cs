using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktualizacjaMenagera : MonoBehaviour {

    public Klik klik;
    public UnityEngine.UI.Text przedmiot;
    public float koszt;
    public int count = 0;
    public int mocKlikniecia;
    public string nazwaPrzedmiotu;
    private float bazowyKoszt;

    void Start()
    {
        bazowyKoszt = koszt;
    }
    void Update()
    {
        przedmiot.text = nazwaPrzedmiotu + "\nKoszt: " + koszt + "\nMoc: " + mocKlikniecia;
    }

    public void Aktualizuj()
    {
        if(klik.zloto >= koszt)
        {
            klik.zloto -= koszt;
            count += 1;
            klik.zlotoNaKlik += mocKlikniecia;
            koszt = Mathf.Round (bazowyKoszt * Mathf.Pow(1.15f, count));
        }
    }
}
