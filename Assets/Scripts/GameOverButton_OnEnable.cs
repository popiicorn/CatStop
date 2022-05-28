using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverButton_OnEnable : MonoBehaviour
{
    public GameObject button;
    public float second;


    void OnEnable()
    {
        Invoke("ButtonSetActive", second);
    }


    public void ButtonSetActive()
    {
        button.SetActive(true);
    }
}
