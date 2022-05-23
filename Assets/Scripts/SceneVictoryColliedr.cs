using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneVictoryColliedr : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Invoke("SceneVictory", 1.0f);

    }



    private void SceneVictory()
    {
        SceneManager.LoadScene("Victory");
    }


}
