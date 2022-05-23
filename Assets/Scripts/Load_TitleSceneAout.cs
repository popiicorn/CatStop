using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_TitleSceneAout : MonoBehaviour
{

    void Start()
    {
        Invoke("LoadScene", 2.0f);
    }




    private void LoadScene()
    {
            SceneManager.LoadScene("Title");

    }

}
