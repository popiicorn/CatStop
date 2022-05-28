using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChenger : MonoBehaviour
{
    public GameObject home;
    public GameObject inGame;
    public GameObject clear;
    public GameObject gameOver;
    public float second;

    public void Start()
    {
        HomeSetActive();
    }


    public void ToGameScene()
    {
        Invoke("GameSceneActive", second);
    }

    public void ToHome()
    {
        Invoke("HomeSetActive", second);
    }

    public void ToInGame()
    {
        Invoke("InGameSetActive", second);
    }

    public void ToInClear()
    {
        Invoke("ClearSetActive", second);
    }

    public void ToGameOver()
    {
        Invoke("GameOverSetActive", second);
    }



    //--------------------------------------
    public void GameSceneActive()
    {
        SceneManager.LoadScene("GameScene");
    }


    public void HomeSetActive()
    {
        home.SetActive(true);
        inGame.SetActive(false);
        clear.SetActive(false);
        gameOver.SetActive(false);
    }

    public void InGameSetActive()
    {
        home.SetActive(false);
        inGame.SetActive(true);
        clear.SetActive(false);
        gameOver.SetActive(false);
    }

    public void ClearSetActive()
    {
        home.SetActive(false);
        inGame.SetActive(false);
        clear.SetActive(true);
        gameOver.SetActive(false);
    }

    public void GameOverSetActive()
    {
        home.SetActive(false);
        inGame.SetActive(false);
        clear.SetActive(false);
        gameOver.SetActive(true);
    }

}
