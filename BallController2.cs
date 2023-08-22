using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallController2 : MonoBehaviour
{
    private GameObject target;

    void Start()
    {
        // 名前でオブジェクトを特定するので一言一句まで合致させること
        target = GameObject.Find("player");
    }

    void Update()
    {
        //「LookAtメソッド」の活用
        this.gameObject.transform.LookAt(target.transform.position);



        // 画面外に出たらオブジェクトを破棄する
        if (transform.position.x < 10.0f)
        {
            Destroy(gameObject);
        }

        // 画面外に出たらオブジェクトを破棄する
        if (transform.position.y < 7.0f)
        {
            Destroy(gameObject);
        }

        // 当たり判定
        Vector2 p1 = transform.position;                // 矢の中心座標
        Vector2 p2 = this.target.transform.position;    // プレイヤーの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.4f; // ボールの半径
        float r2 = 0.75f; // プレイヤーの半径

        if (d < r1 + r2)
        {

            // 監督スクリプトにプレイヤーと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
        }
    }
}