using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeGenerator : MonoBehaviour
{
    //enemyPrefabというGemaobjectがあることを記述
    public GameObject rope;

    void Start()
    {
        Spawn();
    }

    //生成する
    void Spawn()
    {
        //生成位置（x軸）をランダムにしたい
        Vector3 spawnPosition = new Vector3(
             transform.position.x,
             Random.Range(80.0f, 200.0f),
             transform.position.z
            );

        //（引数）をオブジェクト化する
        Instantiate(rope,//生成するもの
            spawnPosition,//生成する場所(今回はアタッチしているオブジェクトからになる)
            transform.rotation//生成時の向き
            );
    }
}
