using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�{�^����������C���Q�[���̈ߑ��ւ����邱�Ƃ��ł���@EquipmentPoint�X�N���v�g����ǂݍ���ł�

public class EquipmentInGame : MonoBehaviour
{
    //���̃X�N���v�g�ǂݍ���
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


    //�����O����------------------------------------------
     public void AllFalseIngame()
    {
        for (int i = 0; i < equipmentInGame.Length; i++)
        {
            equipmentInGame[i].gameObject.SetActive(false);
        }
    }





}
