using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincode : MonoBehaviour {

    public UnityEngine.UI.Text kahvidisplay;
    public UnityEngine.UI.Text purutdisplay;
    public UnityEngine.UI.Text perdisplay;
    public UnityEngine.UI.Text skindisplay2;
    public UnityEngine.UI.Text skindisplay3;
    public UnityEngine.UI.Text skindisplay4;
    public UnityEngine.UI.Text skindisplay5;

    public int kahvi = 0;
    public int kahviperclick = 1;
    public int puru = 50;
    public int purutbuy = 100;
    private float timerStart = 0.0f;
    private float test = 7.0f;
    public int kahvips = 200;
    public int kahviby = 200;
    private int perkahvi = 0;
    public bool timerTest = false;
    public int skin2 = 3000;
    public int skin3 = 5000;
    public int skin4 = 7000;
    public int skin5 = 9000;



    void Update() {
		kahvidisplay.text = "" + kahvi;
        purutdisplay.text = "Hinta: " + puru;
        perdisplay.text = "Hinta: " + kahvips;
        skindisplay2.text = "Hinta :" + skin2;
        skindisplay3.text = "Hinta :" + skin3;
        skindisplay4.text = "Hinta :" + skin4;
        skindisplay5.text = "Hinta :" + skin5;


        timerStart += Time.deltaTime;
        if (timerTest == true)
        {
            if (timerStart >= test)
            {
                timerStart = 0.0f;
                kahvi += perkahvi;
            }
        }

    }

    public void clicked() {
        kahvi += kahviperclick;

    }

    public void purut() {
        if (kahvi > puru)
        {
            kahvi -= puru;
            kahviperclick += 1;
            puru += purutbuy;  
        }
    }

    public void kahvipersecend() {
            if (kahvi > kahvips)
        {
            kahvi -= kahvips;
            timerTest = true;
            kahvips += kahviby;
            perkahvi += 1;

        }
    }




}
