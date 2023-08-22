using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControllerLeft : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        // フレーム毎に等速で飛んでくる
        transform.Translate(-0.1f, 0, 0);
         
        // 画面外に出たらオブジェクトを破棄する
        if (transform.position.x < -11.0f)
        {
            Destroy(gameObject);
        }

         // 当たり判定
         Vector2 p1 = transform.position;                // 矢の中心座標
         Vector2 p2 = this.player.transform.position;    // プレイヤーの中心座標
         Vector2 dir = p1 - p2;
         float d = dir.magnitude;
         float r1 = 0.4f;    // 矢の半径
         float r2 = 0.75f;   // プレイヤーの半径

         if (d < r1 + r2)
         {
              // 監督スクリプトにプレイヤーと衝突したことを伝える
              GameObject director = GameObject.Find("GameDirector");
              director.GetComponent<GameDirector>().DecreaseHp();

              // 衝突した場合は矢を消す
              Destroy(gameObject);
         }
    }
}