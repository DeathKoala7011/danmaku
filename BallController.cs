using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BallController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    private void Update()
    {
        // フレーム毎に等速で飛んでくる
        transform.Translate(-0.1f, -0.1f, 0);
        
        // 画面外に出たらオブジェクトを破壊する
        if (transform.position.y < -7.0f)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }

         // 当たり判定
         Vector2 p1 = transform.position;                // ボールの中心座標
         Vector2 p2 = this.player.transform.position;    // プレイヤーの中心座標
         Vector2 dir = p1 - p2;
         float d = dir.magnitude;
         float r1 = 0.5f; // ボールの半径
         float r2 = 0.75f; // プレイヤーの半径

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