using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneVictoryColliedr : MonoBehaviour
{
    public GameObject inGame;
    public GameObject clear;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("ClearSetActive", 0.8f);
        Debug.Log("クリアコリジョンに当たった");
    }


    public void ClearSetActive()
    {
        inGame.SetActive(false);
        clear.SetActive(true);
    }

    /*
    private void SceneVictory()
    {
        SceneManager.LoadScene("Victory");
    }
    */

}
