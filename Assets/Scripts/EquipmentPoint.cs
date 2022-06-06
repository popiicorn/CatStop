using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentPoint : MonoBehaviour
{
    int point = 0;
    public Text textEquipment;
    public GameObject[] equipmentImage;




    void Start()
    {
        //ポイント値のロード
        point = ES3.Load("Pointkey", point);

        // メニュー画面表示用
        textEquipment.text = "" + point;
    }



    void Update()
    {
        if (point == 1)
        {
            equipmentImage[1].SetActive(true);
        }

        if (point == 2)
        {
            equipmentImage[2].SetActive(true);
        }

        if (point == 3)
        {
            equipmentImage[3].SetActive(true);
        }

        if (point == 4)
        {
            equipmentImage[4].SetActive(true);
        }

        if (point == 5)
        {
            equipmentImage[5].SetActive(true);
        }

        if (point == 6)
        {
            equipmentImage[6].SetActive(true);
        }

        if (point == 7)
        {
            equipmentImage[7].SetActive(true);
        }

        if (point == 8)
        {
            equipmentImage[8].SetActive(true);
        }

        if (point == 9)
        {
            equipmentImage[9].SetActive(true);
        }

    }


    //ポイント数代入------------------------------------------
    void PointLabel()
    {
        textEquipment.text = point + "";

        //ポイント値のセーブ
        ES3.Save<int>("Pointkey", point);
    }

    //装備前消す------------------------------------------
    void AllFalse()
    {
        for (int i = 0; i < equipmentImage.Length; i++)
        {
            equipmentImage[i].gameObject.SetActive(false);
        }
    }



    //オンクリック--------------------------------------------

    public void OnClickPoint_1()
    {
        point = 1;
        PointLabel();
        AllFalse();
    }

    public void OnClickPoint_2()
    {
        point = 2;
        PointLabel();
        AllFalse();
    }

    public void OnClickPoint_3()
    {
        point = 3;
        PointLabel();
        AllFalse();
    }

    public void OnClickPoint_4()
    {
        point = 4;
        PointLabel();
        AllFalse();
    }

    public void OnClickPoint_5()
    {
        point = 5;
        PointLabel();
        AllFalse();
    }

    public void OnClickPoint_6()
    {
        point = 6;
        PointLabel();
        AllFalse();
    }

    public void OnClickPoint_7()
    {
        point = 7;
        PointLabel();
        AllFalse();
    }

    public void OnClickPoint_8()
    {
        point = 8;
        PointLabel();
        AllFalse();
    }

    public void OnClickPoint_9()
    {
        point = 9;
        PointLabel();
        AllFalse();
    }


















}
