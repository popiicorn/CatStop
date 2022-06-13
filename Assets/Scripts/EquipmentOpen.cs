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

    }



}
