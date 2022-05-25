using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ropeup : MonoBehaviour
{
    public GameObject VictoryColliedr;
    float fallSpeed;
    bool fallswich = false;
    //bool isSpace; // フラグを用意

    AudioSource audioSource;
    public AudioClip SE;

    public void Start()
    {
        fallSpeed = 10.0f + 40.0f * Random.value;
        Debug.Log(fallSpeed);

        //用意した入れ物にAudioSourceを入れる
        audioSource = GetComponent<AudioSource>();

        //生成位置（y軸）をランダムに
        transform.position += new Vector3(0, Random.Range(80.0f, 200.0f), 0);

    }

    public void Update()
    {
        if (fallswich == true)
        {
            transform.position += new Vector3(0, fallSpeed, 0) * Time.deltaTime;
        }
    }



    //ボタンを押している状態
    public void PushDown()
    {
        fallswich = true;
    }

    //ボタンを離している状態
    public void PushUp()
    {
        fallswich = false;
        VictoryColliedr.SetActive(true);
        Invoke("SceneGameOver", 1.2f);
    }


    private void SceneGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

}
