using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AktualizacjaMenagera : MonoBehaviour {

    public Klik klik;
    public UnityEngine.UI.Text przedmiot;
    public float koszt;
    public int count = 0;
    public int mocKlikniecia;
    public string nazwaPrzedmiotu;
    public Color standard;
    public Color affordable;
    public int poziom_ulepszenia = 0;
    private float bazowyKoszt;
    private Slider _slider;

    void Start()
    {
        bazowyKoszt = koszt;
        _slider = GetComponentInChildren<Slider> ();
    }
    void Update()
    {
        przedmiot.text = nazwaPrzedmiotu + " (" + poziom_ulepszenia + ")" + "\nKoszt: " + koszt + "\nMoc: " + mocKlikniecia;

        /*if (klik.zloto >= koszt)
        {
            GetComponent<Image> ().color = affordable;
        } else {
            GetComponent<Image> ().color = standard;
        }*/
        _slider.value = klik.zloto / koszt * 100;
        if (_slider.value >= 100)
        {
            GetComponent<Image> ().color = affordable;
        } else {
            GetComponent<Image> ().color = standard;
        }
    }

    public void Aktualizuj()
    {
        if(klik.zloto >= koszt)
        {
            klik.zloto -= koszt;
            count += 1;
            klik.zlotoNaKlik += mocKlikniecia;
            koszt = Mathf.Round (bazowyKoszt * Mathf.Pow(1.45f, count));
            poziom_ulepszenia++;
        }
    }
}
