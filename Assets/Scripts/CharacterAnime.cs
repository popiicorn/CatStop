using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnime : MonoBehaviour
{
    public GameObject sweet;
    public GameObject DokiDoki;
    public GameObject Douyo;
    public GameObject button;


    void Start()
    {
        //Douyo.SetActive(false);
        //DokiDoki.SetActive(true);
    }


    //ボタンを押している状態
    public void PushDown()
    {
        sweet.SetActive(true);
    }

    //ボタンを離している状態
    public void PushUp()
    {
        sweet.SetActive(false);
        button.SetActive(false);
    }

}
