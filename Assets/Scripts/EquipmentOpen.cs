using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ポイントに応じて衣装ボタンが解放される　EquipmentPointスクリプトから読み込んでる

public class EquipmentOpen : MonoBehaviour
{
    //他のスクリプト読み込み
    public ClearPoint clear;

    public GameObject[] equipmentOpen;




    void Update()
    {
 
        //2のボタン
        if (clear.clearpoint >= 10)
        {
            equipmentOpen[2].SetActive(false);
        }

        //3のボタン
        if (clear.clearpoint >= 20)
        {
            equipmentOpen[3].SetActive(false);
        }

        //4のボタン
        if (clear.clearpoint >= 30)
        {
            equipmentOpen[4].SetActive(false);
        }

        //5のボタン
        if (clear.clearpoint >= 40)
        {
            equipmentOpen[5].SetActive(false);
        }

        //6のボタン
        if (clear.clearpoint >= 50)
        {
            equipmentOpen[6].SetActive(false);
        }

        //7のボタン
        if (clear.clearpoint >= 80)
        {
            equipmentOpen[7].SetActive(false);
        }

        //8のボタン
        if (clear.clearpoint >= 120)
        {
            equipmentOpen[8].SetActive(false);
        }

        //9のボタン
        if (clear.clearpoint >= 200)
        {
            equipmentOpen[9].SetActive(false);
        }

        //10のボタン
        if (clear.clearpoint >= 300)
        {
            equipmentOpen[10].SetActive(false);
        }

        //11のボタン
        if (clear.clearpoint >= 400)
        {
            equipmentOpen[11].SetActive(false);
        }

        //12のボタン
        if (clear.clearpoint >= 500)
        {
            equipmentOpen[12].SetActive(false);
        }

        //13のボタン
        if (clear.clearpoint >= 600)
        {
            equipmentOpen[13].SetActive(false);
        }

        //14のボタン
        if (clear.clearpoint >= 700)
        {
            equipmentOpen[14].SetActive(false);
        }

        //15のボタン
        if (clear.clearpoint >= 800)
        {
            equipmentOpen[15].SetActive(false);
        }


        //16のボタン
        if (clear.clearpoint >= 900)
        {
            equipmentOpen[16].SetActive(false);
        }

        //17のボタン
        if (clear.clearpoint >= 1000)
        {
            equipmentOpen[17].SetActive(false);
        }

        //18のボタン
        if (clear.clearpoint >= 1200)
        {
            equipmentOpen[18].SetActive(false);
        }

        //19のボタン
        if (clear.clearpoint >= 1400)
        {
            equipmentOpen[19].SetActive(false);
        }

        //20のボタン
        if (clear.clearpoint >= 1600)
        {
            equipmentOpen[20].SetActive(false);
        }

        //21のボタン
        if (clear.clearpoint >= 1800)
        {
            equipmentOpen[21].SetActive(false);
        }

        //22のボタン
        if (clear.clearpoint >= 2000)
        {
            equipmentOpen[22].SetActive(false);
        }

        //23のボタン
        if (clear.clearpoint >= 2200)
        {
            equipmentOpen[23].SetActive(false);
        }

        //24のボタン
        if (clear.clearpoint >= 2400)
        {
            equipmentOpen[24].SetActive(false);
        }

        //25のボタン
        if (clear.clearpoint >= 2600)
        {
            equipmentOpen[25].SetActive(false);
        }

        //26のボタン
        if (clear.clearpoint >= 2800)
        {
            equipmentOpen[26].SetActive(false);
        }

        //27のボタン
        if (clear.clearpoint >= 3000)
        {
            equipmentOpen[27].SetActive(false);
        }

        //28のボタン
        if (clear.clearpoint >= 3500)
        {
            equipmentOpen[28].SetActive(false);
        }

        //29のボタン
        if (clear.clearpoint >= 4000)
        {
            equipmentOpen[29].SetActive(false);
        }

        //30のボタン
        if (clear.clearpoint >= 4500)
        {
            equipmentOpen[30].SetActive(false);
        }

        //31のボタン
        if (clear.clearpoint >= 5000)
        {
            equipmentOpen[31].SetActive(false);
        }

        //32のボタン
        if (clear.clearpoint >= 5500)
        {
            equipmentOpen[32].SetActive(false);
        }

        //33のボタン
        if (clear.clearpoint >= 6000)
        {
            equipmentOpen[33].SetActive(false);
        }

        //34のボタン
        if (clear.clearpoint >= 6500)
        {
            equipmentOpen[34].SetActive(false);
        }

        //35のボタン
        if (clear.clearpoint >= 7000)
        {
            equipmentOpen[35].SetActive(false);
        }

        //36のボタン
        if (clear.clearpoint >= 7500)
        {
            equipmentOpen[36].SetActive(false);
        }

        //37のボタン
        if (clear.clearpoint >= 8000)
        {
            equipmentOpen[37].SetActive(false);
        }

        //38のボタン
        if (clear.clearpoint >= 9000)
        {
            equipmentOpen[38].SetActive(false);
        }

        //39のボタン
        if (clear.clearpoint >= 10000)
        {
            equipmentOpen[39].SetActive(false);
        }

        //40のボタン
        if (clear.clearpoint >= 11000)
        {
            equipmentOpen[40].SetActive(false);
        }

        //41のボタン
        if (clear.clearpoint >= 12000)
        {
            equipmentOpen[41].SetActive(false);
        }

        //42のボタン
        if (clear.clearpoint >= 13000)
        {
            equipmentOpen[42].SetActive(false);
        }

        //43のボタン
        if (clear.clearpoint >= 14000)
        {
            equipmentOpen[43].SetActive(false);
        }

        //44のボタン
        if (clear.clearpoint >= 15000)
        {
            equipmentOpen[44].SetActive(false);
        }

        //45のボタン
        if (clear.clearpoint >= 16000)
        {
            equipmentOpen[45].SetActive(false);
        }
    }



}
