using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ropeup : MonoBehaviour
{
    public GameObject VictoryColliedr;
    public　float fallSpeed;
    bool isSpace; // フラグを用意

    AudioSource audioSource;
    public AudioClip SE;

    public void Start()
    {
        fallSpeed = 100.0f + 50.0f * Random.value;

        //用意した入れ物にAudioSourceを入れる
        audioSource = GetComponent<AudioSource>();
    }

    /*void Update()
    {
        if (Input.touchCount > 0)
        {
            // タッチ情報の取得
            Touch touch = Input.GetTouch(0);


            // フラグがtrueならここで処理を終える
            if (isSpace)
            {
                return;
            }


            if (touch.phase == TouchPhase.Began)
            {
                audioSource.PlayOneShot(SE);

            }

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position += new Vector3(0, fallSpeed, 0) * Time.deltaTime;


            }


            if (touch.phase == TouchPhase.Ended)
            {
                //Debug.Log("離す");
                audioSource.Stop();

                VictoryColliedr.SetActive(true);
                Invoke("SceneGameOver", 1.2f);

                // スペースキーを押したらtrueにする
                isSpace = true;
            }

        }

    }
    */

    //ボタンを押している状態
    public void PushDown()
    {
        transform.position += new Vector3(0, fallSpeed, 0) * Time.deltaTime;
    }

    //ボタンを離している状態
    public void PushUp()
    {
        VictoryColliedr.SetActive(true);
        Invoke("SceneGameOver", 1.2f);
    }


    private void SceneGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

}
