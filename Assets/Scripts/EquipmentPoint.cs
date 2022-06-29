using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ボタン押したらホーム画面の衣装替えすることができる　大元のポイントスクリプト

public class EquipmentPoint : MonoBehaviour
{
    //他のスクリプト読み込み
    public EquipmentInGame equipmentingame;
    public ButtonSelect buttonselect;

    public int point = 0;
    public Text textEquipment;
    public GameObject smork;
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

        if (point == 10)
        {
            equipmentImage[10].SetActive(true);
        }

        if (point == 11)
        {
            equipmentImage[11].SetActive(true);
        }

        if (point == 12)
        {
            equipmentImage[12].SetActive(true);
        }

        if (point == 13)
        {
            equipmentImage[13].SetActive(true);
        }

        if (point == 14)
        {
            equipmentImage[14].SetActive(true);
        }

        if (point == 15)
        {
            equipmentImage[15].SetActive(true);
        }

        if (point == 16)
        {
            equipmentImage[16].SetActive(true);
        }

        if (point == 17)
        {
            equipmentImage[17].SetActive(true);
        }

        if (point == 18)
        {
            equipmentImage[18].SetActive(true);
        }

        if (point == 19)
        {
            equipmentImage[19].SetActive(true);
        }

        if (point == 20)
        {
            equipmentImage[20].SetActive(true);
        }

        if (point == 21)
        {
            equipmentImage[21].SetActive(true);
        }

        if (point == 22)
        {
            equipmentImage[22].SetActive(true);
        }

        if (point == 23)
        {
            equipmentImage[23].SetActive(true);
        }

        if (point == 24)
        {
            equipmentImage[24].SetActive(true);
        }

        if (point == 25)
        {
            equipmentImage[25].SetActive(true);
        }

        if (point == 26)
        {
            equipmentImage[26].SetActive(true);
        }

        if (point == 27)
        {
            equipmentImage[27].SetActive(true);
        }

        if (point == 28)
        {
            equipmentImage[28].SetActive(true);
        }

        if (point == 29)
        {
            equipmentImage[29].SetActive(true);
        }

        if (point == 30)
        {
            equipmentImage[30].SetActive(true);
        }

        if (point == 31)
        {
            equipmentImage[31].SetActive(true);
        }

        if (point == 32)
        {
            equipmentImage[32].SetActive(true);
        }

        if (point == 33)
        {
            equipmentImage[33].SetActive(true);
        }

        if (point == 34)
        {
            equipmentImage[34].SetActive(true);
        }

        if (point == 35)
        {
            equipmentImage[35].SetActive(true);
        }

        if (point == 36)
        {
            equipmentImage[36].SetActive(true);
        }

        if (point == 37)
        {
            equipmentImage[37].SetActive(true);
        }

        if (point == 38)
        {
            equipmentImage[38].SetActive(true);
        }

        if (point == 39)
        {
            equipmentImage[39].SetActive(true);
        }

        if (point == 40)
        {
            equipmentImage[40].SetActive(true);
        }

        if (point == 41)
        {
            equipmentImage[41].SetActive(true);
        }

        if (point == 42)
        {
            equipmentImage[42].SetActive(true);
        }

        if (point == 43)
        {
            equipmentImage[43].SetActive(true);
        }

        if (point == 44)
        {
            equipmentImage[44].SetActive(true);
        }

        if (point == 45)
        {
            equipmentImage[45].SetActive(true);
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

    //煙エフェクト出現して消す------------------------------------------
    void Smork()
    {
       smork.SetActive(true);
        Invoke("SmorkFalse", 0.4f);
    }

    //煙エフェクト消す------------------------------------------
    void SmorkFalse()
    {
        smork.SetActive(false);
    }

    //関数集合------------------------------------------
    void AllSelection()
    {
        PointLabel();
        AllFalse();
        equipmentingame.AllFalseIngame();
        buttonselect.AllFalseSelectButton();
        Smork();
    }



    //オンクリック--------------------------------------------

    public void OnClickPoint_1()
    {
        point = 1;
        AllSelection();
    }

    public void OnClickPoint_2()
    {
        point = 2;
        AllSelection();
    }

    public void OnClickPoint_3()
    {
        point = 3;
        AllSelection();
    }

    public void OnClickPoint_4()
    {
        point = 4;
        AllSelection();
    }

    public void OnClickPoint_5()
    {
        point = 5;
        AllSelection();
    }

    public void OnClickPoint_6()
    {
        point = 6;
        AllSelection();
    }

    public void OnClickPoint_7()
    {
        point = 7;
        AllSelection();
    }

    public void OnClickPoint_8()
    {
        point = 8;
        AllSelection();
    }

    public void OnClickPoint_9()
    {
        point = 9;
        AllSelection();
    }

    public void OnClickPoint_10()
    {
        point = 10;
        AllSelection();
    }

    public void OnClickPoint_11()
    {
        point = 11;
        AllSelection();
    }

    public void OnClickPoint_12()
    {
        point = 12;
        AllSelection();
    }

    public void OnClickPoint_13()
    {
        point = 13;
        AllSelection();
    }

    public void OnClickPoint_14()
    {
        point = 14;
        AllSelection();
    }

    public void OnClickPoint_15()
    {
        point = 15;
        AllSelection();
    }

    public void OnClickPoint_16()
    {
        point = 16;
        AllSelection();
    }

    public void OnClickPoint_17()
    {
        point = 17;
        AllSelection();
    }

    public void OnClickPoint_18()
    {
        point = 18;
        AllSelection();
    }

    public void OnClickPoint_19()
    {
        point = 19;
        AllSelection();
    }

    public void OnClickPoint_20()
    {
        point = 20;
        AllSelection();
    }

    public void OnClickPoint_21()
    {
        point = 21;
        AllSelection();
    }

    public void OnClickPoint_22()
    {
        point = 22;
        AllSelection();
    }

    public void OnClickPoint_23()
    {
        point = 23;
        AllSelection();
    }

    public void OnClickPoint_24()
    {
        point = 24;
        AllSelection();
    }

    public void OnClickPoint_25()
    {
        point = 25;
        AllSelection();
    }

    public void OnClickPoint_26()
    {
        point = 26;
        AllSelection();
    }

    public void OnClickPoint_27()
    {
        point = 27;
        AllSelection();
    }

    public void OnClickPoint_28()
    {
        point = 28;
        AllSelection();
    }

    public void OnClickPoint_29()
    {
        point = 29;
        AllSelection();
    }

    public void OnClickPoint_30()
    {
        point = 30;
        AllSelection();
    }

    public void OnClickPoint_31()
    {
        point = 31;
        AllSelection();
    }

    public void OnClickPoint_32()
    {
        point = 32;
        AllSelection();
    }

    public void OnClickPoint_33()
    {
        point = 33;
        AllSelection();
    }

    public void OnClickPoint_34()
    {
        point = 34;
        AllSelection();
    }

    public void OnClickPoint_35()
    {
        point = 35;
        AllSelection();
    }

    public void OnClickPoint_36()
    {
        point = 36;
        AllSelection();
    }

    public void OnClickPoint_37()
    {
        point = 37;
        AllSelection();
    }

    public void OnClickPoint_38()
    {
        point = 38;
        AllSelection();
    }

    public void OnClickPoint_39()
    {
        point = 39;
        AllSelection();
    }

    public void OnClickPoint_40()
    {
        point = 40;
        AllSelection();
    }

    public void OnClickPoint_41()
    {
        point = 41;
        AllSelection();
    }

    public void OnClickPoint_42()
    {
        point = 42;
        AllSelection();
    }

    public void OnClickPoint_43()
    {
        point = 43;
        AllSelection();
    }

    public void OnClickPoint_44()
    {
        point = 44;
        AllSelection();
    }

    public void OnClickPoint_45()
    {
        point = 45;
        AllSelection();
    }





















}
