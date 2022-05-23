using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGameOverColliedr : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Invoke("SceneGameOver", 1.0f);

    }



    private void SceneGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }


}
