using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PrzedmiotMenager : MonoBehaviour {

    public UnityEngine.UI.Text przedmiot;
    public Klik klik;
    public float koszt;
    public int wartosc;
    public int count;
    public string nazwaPrzedmiotu;
    public Color standard;
    public Color affordable;
    public int poziom_ulepszenia = 0;
    private float bazowyKoszt;
    private Slider _slider;

    void Start()
    {
        bazowyKoszt = koszt;
        _slider = GetComponentInChildren<Slider>();
    }

    void Update()
    {
        przedmiot.text = nazwaPrzedmiotu + " (" + poziom_ulepszenia + ")" + "\nKoszt: " + koszt + "\nZloto: " + wartosc + "/s";
        _slider.value = klik.zloto / koszt * 100;
        if (klik.zloto >= koszt)
        {
            GetComponent<Image> ().color = affordable;
        } else {
            GetComponent<Image> ().color = standard;
        }
    }

    public void ZdobadzPrzedmiot()
    {
        if(klik.zloto >= koszt)
        {
            klik.zloto -= koszt;
            count += 1;
            koszt = Mathf.Round (bazowyKoszt * Mathf.Pow(1.45f, count));
            poziom_ulepszenia++;
        }
    }







}
