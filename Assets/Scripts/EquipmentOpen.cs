using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�|�C���g�ɉ����Ĉߑ��{�^������������@EquipmentPoint�X�N���v�g����ǂݍ���ł�

public class EquipmentOpen : MonoBehaviour
{
    //���̃X�N���v�g�ǂݍ���
    public ClearPoint clear;

    public GameObject[] equipmentOpen;




    void Update()
    {
 
        //2�̃{�^��
        if (clear.clearpoint >= 10)
        {
            equipmentOpen[2].SetActive(false);
        }

        //3�̃{�^��
        if (clear.clearpoint >= 20)
        {
            equipmentOpen[3].SetActive(false);
        }

        //4�̃{�^��
        if (clear.clearpoint >= 30)
        {
            equipmentOpen[4].SetActive(false);
        }

        //5�̃{�^��
        if (clear.clearpoint >= 40)
        {
            equipmentOpen[5].SetActive(false);
        }

        //6�̃{�^��
        if (clear.clearpoint >= 50)
        {
            equipmentOpen[6].SetActive(false);
        }

        //7�̃{�^��
        if (clear.clearpoint >= 80)
        {
            equipmentOpen[7].SetActive(false);
        }

        //8�̃{�^��
        if (clear.clearpoint >= 120)
        {
            equipmentOpen[8].SetActive(false);
        }

        //9�̃{�^��
        if (clear.clearpoint >= 200)
        {
            equipmentOpen[9].SetActive(false);
        }

    }



}
