using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klik : MonoBehaviour {

    public UnityEngine.UI.Text znk;
    public UnityEngine.UI.Text WyswietlZloto;
    public float zloto = 0.00f;
    public int zlotoNaKlik = 1;

    void Update()
    {
        WyswietlZloto.text = "Zloto: " + zloto;
        znk.text = zlotoNaKlik + " zlota/click";
    }

    public void Klikniecie()
    {
        zloto += zlotoNaKlik;
    }
}
