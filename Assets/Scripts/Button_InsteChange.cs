using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_InsteChange : MonoBehaviour
{
    public GameObject buttonNormal;
    public GameObject buttonInterstitial;
    int x = 0;

    void OnEnable()
    {
        x = ES3.Load("cancelkey", x);
        x += 1;
        CancelButton();


        //Debug.Log("���Ⴙ��{�^���̕\����" + x);

    }

    void OnDisable()
    {
        ResetCount();

        ES3.Save<int>("cancelkey", x);
        //Debug.Log("���[��" + x);
    }


    void ResetCount()
    {
        if (x >= 4)
        {
            x = 0;
        }

        //Debug.Log("���Z�b�g" + x);
    }

    void CancelButton()
    {
        if (x == 3)
        {
            buttonNormal.SetActive(false);
            buttonInterstitial.SetActive(true);
        }

        else
        {
            buttonNormal.SetActive(true);
            buttonInterstitial.SetActive(false);
        }

    }

}
