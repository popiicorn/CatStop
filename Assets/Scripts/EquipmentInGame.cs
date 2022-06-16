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

        if (equipmentpoint.point == 10)
        {
            equipmentInGame[10].SetActive(true);
        }

        if (equipmentpoint.point == 11)
        {
            equipmentInGame[11].SetActive(true);
        }

        if (equipmentpoint.point == 12)
        {
            equipmentInGame[12].SetActive(true);
        }

        if (equipmentpoint.point == 13)
        {
            equipmentInGame[13].SetActive(true);
        }

        if (equipmentpoint.point == 14)
        {
            equipmentInGame[14].SetActive(true);
        }

        if (equipmentpoint.point == 15)
        {
            equipmentInGame[15].SetActive(true);
        }

        if (equipmentpoint.point == 16)
        {
            equipmentInGame[16].SetActive(true);
        }

        if (equipmentpoint.point == 17)
        {
            equipmentInGame[17].SetActive(true);
        }

        if (equipmentpoint.point == 18)
        {
            equipmentInGame[18].SetActive(true);
        }

        if (equipmentpoint.point == 19)
        {
            equipmentInGame[19].SetActive(true);
        }

        if (equipmentpoint.point == 20)
        {
            equipmentInGame[20].SetActive(true);
        }

        if (equipmentpoint.point == 21)
        {
            equipmentInGame[21].SetActive(true);
        }

        if (equipmentpoint.point == 22)
        {
            equipmentInGame[22].SetActive(true);
        }

        if (equipmentpoint.point == 23)
        {
            equipmentInGame[23].SetActive(true);
        }

        if (equipmentpoint.point == 24)
        {
            equipmentInGame[24].SetActive(true);
        }

        if (equipmentpoint.point == 25)
        {
            equipmentInGame[25].SetActive(true);
        }

        if (equipmentpoint.point == 26)
        {
            equipmentInGame[26].SetActive(true);
        }

        if (equipmentpoint.point == 27)
        {
            equipmentInGame[27].SetActive(true);
        }

        if (equipmentpoint.point == 28)
        {
            equipmentInGame[28].SetActive(true);
        }

        if (equipmentpoint.point == 29)
        {
            equipmentInGame[29].SetActive(true);
        }

        if (equipmentpoint.point == 30)
        {
            equipmentInGame[30].SetActive(true);
        }

        if (equipmentpoint.point == 31)
        {
            equipmentInGame[31].SetActive(true);
        }

        if (equipmentpoint.point == 32)
        {
            equipmentInGame[32].SetActive(true);
        }

        if (equipmentpoint.point == 33)
        {
            equipmentInGame[33].SetActive(true);
        }

        if (equipmentpoint.point == 34)
        {
            equipmentInGame[34].SetActive(true);
        }

        if (equipmentpoint.point == 35)
        {
            equipmentInGame[35].SetActive(true);
        }

        if (equipmentpoint.point == 36)
        {
            equipmentInGame[36].SetActive(true);
        }

        if (equipmentpoint.point == 37)
        {
            equipmentInGame[37].SetActive(true);
        }

        if (equipmentpoint.point == 38)
        {
            equipmentInGame[38].SetActive(true);
        }

        if (equipmentpoint.point == 39)
        {
            equipmentInGame[39].SetActive(true);
        }

        if (equipmentpoint.point == 40)
        {
            equipmentInGame[40].SetActive(true);
        }

        if (equipmentpoint.point == 41)
        {
            equipmentInGame[41].SetActive(true);
        }

        if (equipmentpoint.point == 42)
        {
            equipmentInGame[42].SetActive(true);
        }

        if (equipmentpoint.point == 43)
        {
            equipmentInGame[43].SetActive(true);
        }

        if (equipmentpoint.point == 44)
        {
            equipmentInGame[44].SetActive(true);
        }

        if (equipmentpoint.point == 45)
        {
            equipmentInGame[45].SetActive(true);
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
