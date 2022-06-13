using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ボタン押したらインゲームの衣装替えすることができる　EquipmentPointスクリプトから読み込んでる

public class EquipmentInGame : MonoBehaviour
{
    //他のスクリプト読み込み
    public EquipmentPoint equipmentpoint;

    public GameObject[] equipmentInGame;




    void Update()
    {
        if (equipmentpoint.point == 1)
        {
            equipmentInGame[1].SetActive(true);
        }

        if (equipmentpoint.point == 2)
        {
            equipmentInGame[2].SetActive(true);
        }

        if (equipmentpoint.point == 3)
        {
            equipmentInGame[3].SetActive(true);
        }

        if (equipmentpoint.point == 4)
        {
            equipmentInGame[4].SetActive(true);
        }

        if (equipmentpoint.point == 5)
        {
            equipmentInGame[5].SetActive(true);
        }

        if (equipmentpoint.point == 6)
        {
            equipmentInGame[6].SetActive(true);
        }

        if (equipmentpoint.point == 7)
        {
            equipmentInGame[7].SetActive(true);
        }

        if (equipmentpoint.point == 8)
        {
            equipmentInGame[8].SetActive(true);
        }

        if (equipmentpoint.point == 9)
        {
            equipmentInGame[9].SetActive(true);
        }

    }


    //装備前消す------------------------------------------
     public void AllFalseIngame()
    {
        for (int i = 0; i < equipmentInGame.Length; i++)
        {
            equipmentInGame[i].gameObject.SetActive(false);
        }
    }





}
