using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class maincode : MonoBehaviour {

    public UnityEngine.UI.Text kahvidisplay;
    public UnityEngine.UI.Text purutdisplay;
    public UnityEngine.UI.Text perdisplay;
    public UnityEngine.UI.Text skindisplay2;
    public UnityEngine.UI.Text skindisplay3;
    public UnityEngine.UI.Text skindisplay4;
    public UnityEngine.UI.Text skindisplay5;
    public UnityEngine.UI.Text puruperclick_display;
    public UnityEngine.UI.Text autoclick_display;



    public int kahvi = 0;
    public int kahviperclick = 1;
    public int puru = 50;
    public int purutbuy = 100;
    private float timerStart = 0.0f; 
    private float time = 1.0f;
    public int kahvips = 200;
    public int kahviby = 200;
    private int perkahvi = 0;
    public bool timerTest = false;

    private float saveTimeStart = 0.0f;
    private float saveTime = 5.0f;

    //skini juttuja
    public int skin2 = 3000;
    public int skin3 = 5000;
    public int skin4 = 7000;
    public int skin5 = 9000;

    public Button skin1_button;

    public Sprite skin1_sprite;
    public Sprite skin2_sprite;
    public Sprite skin3_sprite;
    public Sprite skin4_sprite;
    public Sprite skin5_sprite;

    public bool skin2_countter = false;
    public bool skin3_countter = false;
    public bool skin4_countter = false;
    public bool skin5_countter = false;


    void Start()
    {
        load();//lataa pelin datan heti kun peli avautuu
    }

    void Update() {
		kahvidisplay.text = "" + kahvi;
        purutdisplay.text = "Hinta: " + puru;
        perdisplay.text = "Hinta: " + kahvips;
        skindisplay2.text = "Hinta :" + skin2;
        skindisplay3.text = "Hinta :" + skin3;
        skindisplay4.text = "Hinta :" + skin4;
        skindisplay5.text = "Hinta :" + skin5;
        puruperclick_display.text = kahviperclick + " Per. click";
        autoclick_display.text = "auto click: " + time;

        save();

        //piste joka sekuntti
        timerStart += Time.deltaTime;
        if (timerTest == true)
        {
            if (timerStart >= time)
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


    //Skinien osto koodi
    public void skin2_osto()
    {


        if (kahvi > skin2)
        {
            skin2_countter = true;
            if (skin2_countter == true)
            {
                skin1_button.image.overrideSprite = skin2_sprite;
            }
            else
            {
                skin1_button.image.overrideSprite = skin1_sprite;
            }
            if (skin3_countter == false)
            {
                kahvi -= skin2;
            }
        }

    }

    public void skin3_osto()
    {
        if (kahvi > skin3)
        {
            skin3_countter = true;
            if (skin3_countter == true)
            {
                skin1_button.image.overrideSprite = skin3_sprite;
            }
            else
            {
                skin1_button.image.overrideSprite = skin1_sprite;
            }

            if (skin3_countter == false)
            {
                kahvi -= skin3;
            }

        }
    }

    public void skin4_osto()
    {
        if (kahvi > skin4)
        {
            skin4_countter = true;
            if (skin4_countter == true)
            {
                skin1_button.image.overrideSprite = skin4_sprite;
            }
            else
            {
                skin1_button.image.overrideSprite = skin1_sprite;
            }

            if (skin3_countter == false)
            {
                kahvi -= skin4;
            }
        }
    }

    public void skin5_osto()
    {
        if (kahvi > skin5)
        {
            skin5_countter = true ;
            if (skin5_countter == true)
            {
                skin1_button.image.overrideSprite = skin5_sprite;
            }
            else
            {
                skin1_button.image.overrideSprite = skin1_sprite;
            }
            if (skin3_countter == false)
            {
                kahvi -= skin5;
            }
        }
    }

    public void norm_skini()
    {
        skin1_button.image.overrideSprite = skin1_sprite;
    }

    public void save()
    {
        PlayerPrefs.SetInt("click", kahvi);
        PlayerPrefs.SetInt("kahviperclick", kahviperclick);
        PlayerPrefs.SetInt("puru", puru);
        PlayerPrefs.SetInt("purutbuy", purutbuy);
        PlayerPrefs.SetInt("kahvips", kahvips);
        PlayerPrefs.SetInt("kahviby", kahviby);
        PlayerPrefs.SetInt("perkahvi", perkahvi);
        PlayerPrefs.SetFloat("time", time);
        PlayerPrefs.SetFloat("timerStart", timerStart);
        PlayerPrefs.SetInt("timerTest", timerTest ? 1:0);
        PlayerPrefs.SetInt("skin2_countter", skin2_countter ? 1 : 0);
        PlayerPrefs.SetInt("skin3_countter", skin3_countter ? 1 : 0);
        PlayerPrefs.SetInt("skin4_countter", skin4_countter ? 1 : 0);
        PlayerPrefs.SetInt("skin5_countter", skin5_countter ? 1 : 0);


    }

    public void load()
    {
        kahvi = PlayerPrefs.GetInt("click", 0);
        kahviperclick = PlayerPrefs.GetInt("kahviperclick", 1);
        puru = PlayerPrefs.GetInt("puru", 50);
        purutbuy = PlayerPrefs.GetInt("purutbuy", 100);
        kahvips = PlayerPrefs.GetInt("kahvips", 100);
        kahviby = PlayerPrefs.GetInt("kahviby", 200);
        perkahvi = PlayerPrefs.GetInt("perkahvi", 0);
        timerStart = PlayerPrefs.GetFloat("timerStart", 0.0f);
        time = PlayerPrefs.GetFloat("time", 1.0f);
        timerTest = PlayerPrefs.GetInt("timerTest") > 0;
        skin2_countter = PlayerPrefs.GetInt("skin2_countter") > 0;
        skin3_countter = PlayerPrefs.GetInt("skin3_countter") > 0;
        skin4_countter = PlayerPrefs.GetInt("skin4_countter") > 0;
        skin5_countter = PlayerPrefs.GetInt("skin5_countter") > 0;




    }
}
