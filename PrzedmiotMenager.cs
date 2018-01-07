using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrzedmiotMenager : MonoBehaviour {

    public UnityEngine.UI.Text przedmiot;
    public Klik klik;
    public float koszt;
    public int wartosc;
    public int count;
    public string nazwaPrzedmiotu;
    private float bazowyKoszt;

    void Start()
    {
        bazowyKoszt = koszt;
    }

    void Update()
    {
        przedmiot.text = nazwaPrzedmiotu + "\nKoszt: " + koszt + "\nZloto: " + wartosc + "/s";
    }

    public void ZdobadzPrzedmiot()
    {
        if(klik.zloto >= koszt)
        {
            klik.zloto -= koszt;
            count += 1;
            koszt = Mathf.Round (bazowyKoszt * Mathf.Pow(1.15f, count));
        }
    }







}
