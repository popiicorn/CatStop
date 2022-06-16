using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボタン押したら選択色がつく　EquipmentPointスクリプトから読み込んでる

public class ButtonSelect : MonoBehaviour
{
    //他のスクリプト読み込み
    public EquipmentPoint equipmentpoint;

    public GameObject[] select;




    void Update()
    {
        if (equipmentpoint.point == 1)
        {
            select[1].SetActive(true);
        }

        if (equipmentpoint.point == 2)
        {
            select[2].SetActive(true);
        }

        if (equipmentpoint.point == 3)
        {
            select[3].SetActive(true);
        }

        if (equipmentpoint.point == 4)
        {
            select[4].SetActive(true);
        }

        if (equipmentpoint.point == 5)
        {
            select[5].SetActive(true);
        }

        if (equipmentpoint.point == 6)
        {
            select[6].SetActive(true);
        }

        if (equipmentpoint.point == 7)
        {
            select[7].SetActive(true);
        }

        if (equipmentpoint.point == 8)
        {
            select[8].SetActive(true);
        }

        if (equipmentpoint.point == 9)
        {
            select[9].SetActive(true);
        }

        if (equipmentpoint.point == 10)
        {
            select[10].SetActive(true);
        }

        if (equipmentpoint.point == 11)
        {
            select[11].SetActive(true);
        }

        if (equipmentpoint.point == 12)
        {
            select[12].SetActive(true);
        }

        if (equipmentpoint.point == 13)
        {
            select[13].SetActive(true);
        }

        if (equipmentpoint.point == 14)
        {
            select[14].SetActive(true);
        }

        if (equipmentpoint.point == 15)
        {
            select[15].SetActive(true);
        }

        if (equipmentpoint.point == 16)
        {
            select[16].SetActive(true);
        }

        if (equipmentpoint.point == 17)
        {
            select[17].SetActive(true);
        }

        if (equipmentpoint.point == 18)
        {
            select[18].SetActive(true);
        }

        if (equipmentpoint.point == 19)
        {
            select[19].SetActive(true);
        }

        if (equipmentpoint.point == 20)
        {
            select[20].SetActive(true);
        }

        if (equipmentpoint.point == 21)
        {
            select[21].SetActive(true);
        }

        if (equipmentpoint.point == 22)
        {
            select[22].SetActive(true);
        }

        if (equipmentpoint.point == 23)
        {
            select[23].SetActive(true);
        }

        if (equipmentpoint.point == 24)
        {
            select[24].SetActive(true);
        }

        if (equipmentpoint.point == 25)
        {
            select[25].SetActive(true);
        }

        if (equipmentpoint.point == 26)
        {
            select[26].SetActive(true);
        }

        if (equipmentpoint.point == 27)
        {
            select[27].SetActive(true);
        }

        if (equipmentpoint.point == 28)
        {
            select[28].SetActive(true);
        }

        if (equipmentpoint.point == 29)
        {
            select[29].SetActive(true);
        }

        if (equipmentpoint.point == 30)
        {
            select[30].SetActive(true);
        }

        if (equipmentpoint.point == 31)
        {
            select[31].SetActive(true);
        }

        if (equipmentpoint.point == 32)
        {
            select[32].SetActive(true);
        }

        if (equipmentpoint.point == 33)
        {
            select[33].SetActive(true);
        }

        if (equipmentpoint.point == 34)
        {
            select[34].SetActive(true);
        }

        if (equipmentpoint.point == 35)
        {
            select[35].SetActive(true);
        }

        if (equipmentpoint.point == 36)
        {
            select[36].SetActive(true);
        }

        if (equipmentpoint.point == 37)
        {
            select[37].SetActive(true);
        }

        if (equipmentpoint.point == 38)
        {
            select[38].SetActive(true);
        }

        if (equipmentpoint.point == 39)
        {
            select[39].SetActive(true);
        }

        if (equipmentpoint.point == 40)
        {
            select[40].SetActive(true);
        }

        if (equipmentpoint.point == 41)
        {
            select[41].SetActive(true);
        }

        if (equipmentpoint.point == 42)
        {
            select[42].SetActive(true);
        }

        if (equipmentpoint.point == 43)
        {
            select[43].SetActive(true);
        }

        if (equipmentpoint.point == 44)
        {
            select[44].SetActive(true);
        }

        if (equipmentpoint.point == 45)
        {
            select[45].SetActive(true);
        }
    }


    //装備前消す------------------------------------------
     public void AllFalseSelectButton()
    {
        for (int i = 0; i < select.Length; i++)
        {
            select[i].gameObject.SetActive(false);
        }
    }





}
