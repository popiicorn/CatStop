using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�{�^����������I��F�����@EquipmentPoint�X�N���v�g����ǂݍ���ł�

public class ButtonSelect : MonoBehaviour
{
    //���̃X�N���v�g�ǂݍ���
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


    //�����O����------------------------------------------
     public void AllFalseSelectButton()
    {
        for (int i = 0; i < select.Length; i++)
        {
            select[i].gameObject.SetActive(false);
        }
    }





}
