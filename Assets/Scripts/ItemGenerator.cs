using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject item;
    public GameObject button;

   
    //ボタンを押している状態
    public void PushDown()
    {
        item.SetActive(true);
    }

    //ボタンを離している状態
    public void PushUp()
    {
        item.SetActive(false);
        button.SetActive(false);
    }

}
