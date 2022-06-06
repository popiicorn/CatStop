using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearPoint : MonoBehaviour
{
    int clearpoint = 0;
    public Text textClearPoint;
    public GameObject clearScenes;
    bool pointswich = false;



   void Start()
    {
        //ポイント値のロード
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // メニュー画面表示用
        textClearPoint.text = "" + clearpoint;

        Debug.Log("ロード");
    }


    
    void Update()
    {
        if (!pointswich)
        { 
           if (clearScenes.activeSelf)
           {
            clearpoint += 5;
            AddPoint();
            pointswich = true;
           }
        }

        if (clearScenes.activeSelf == false)
        {
            pointswich = false;
        }
    }


    public void RewordButton()
    {
        clearpoint += 5;
        AddPoint();
    }




    //ポイント数代入------------------------------------------
    void AddPoint()
    {
        textClearPoint.text = clearpoint + "";

        //ポイント値のセーブ
        ES3.Save<int>("Clearkey", clearpoint);
    }
}
