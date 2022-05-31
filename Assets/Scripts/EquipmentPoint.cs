using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentPoint : MonoBehaviour
{
    int point = 0;
    public Text textEquipment;



    // Start is called before the first frame update
    void Start()
    {
        //�|�C���g�l�̃��[�h
        point = ES3.Load("Pointkey", point);

        // ���j���[��ʕ\���p
        textEquipment.text = "" + point;
    }

    // Update is called once per frame
    void Update()
    {

    }


    //�|�C���g�����------------------------------------------
    void PointLabel()
    {
        textEquipment.text = point + "";

        //�|�C���g�l�̃Z�[�u
        ES3.Save<int>("Pointkey", point);
    }

    //�I���N���b�N--------------------------------------------

    public void OnClickPoint_1()
    {
        point = 1;
        PointLabel();
    }

    public void OnClickPoint_2()
    {
        point = 2;
        PointLabel();
    }

    public void OnClickPoint_3()
    {
        point = 3;
        PointLabel();
    }

    public void OnClickPoint_4()
    {
        point = 4;
        PointLabel();
    }

    public void OnClickPoint_5()
    {
        point = 5;
        PointLabel();
    }

    public void OnClickPoint_6()
    {
        point = 6;
        PointLabel();
    }

    public void OnClickPoint_7()
    {
        point = 7;
        PointLabel();
    }

    public void OnClickPoint_8()
    {
        point = 8;
        PointLabel();
    }

    public void OnClickPoint_9()
    {
        point = 9;
        PointLabel();
    }


















}
