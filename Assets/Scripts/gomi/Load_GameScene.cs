using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_GameScene : MonoBehaviour
{
    public float second;


    public void OnClickStartButton()
    {
        Invoke("toGameScene", second);
    }


    public void toGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

}
