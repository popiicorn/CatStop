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
