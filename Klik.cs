using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klik : MonoBehaviour {

    public UnityEngine.UI.Text znk;
    public UnityEngine.UI.Text WyswietlZloto;
    public float zloto = 0.00f;
    public int zlotoNaKlik = 1;
    //public int ilosc_klikniec = 0;

    void Update()
    {
        WyswietlZloto.text = "" + zloto.ToString("F0");
        znk.text = zlotoNaKlik + " zlota/click";
    }

    public void Klikniecie()
    {
        zloto += zlotoNaKlik;
        /*ilosc_klikniec++;
        if (ilosc_klikniec == 20)
        {
            zloto += 100;
        };*/
    }
}
