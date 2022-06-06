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
        //�|�C���g�l�̃��[�h
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // ���j���[��ʕ\���p
        textClearPoint.text = "" + clearpoint;

        Debug.Log("���[�h");
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




    //�|�C���g�����------------------------------------------
    void AddPoint()
    {
        textClearPoint.text = clearpoint + "";

        //�|�C���g�l�̃Z�[�u
        ES3.Save<int>("Clearkey", clearpoint);
    }
}
