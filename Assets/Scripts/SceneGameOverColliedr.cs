using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGameOverColliedr : MonoBehaviour
{
    public GameObject inGame;
    public GameObject gameOver;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        Invoke("SceneGameOver", 1.0f);

    }



    private void SceneGameOver()
    {
        inGame.SetActive(false);
        gameOver.SetActive(true);

    }


}
