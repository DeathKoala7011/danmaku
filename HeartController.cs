using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    [SerializeField] private float _Speed;

    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        // フレーム毎に等速で飛んでくる
        transform.Translate(_Speed, 0, 0);

        //画面外に出たらオブジェクトを破棄する
        if (transform.position.x > 11.0f)
        {
            Destroy(gameObject);
        }

        // 当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.75f;
        float r2 = 0.75f;

        if (d < r1 + r2)
        {
            //ハートを取得した場合に効果音が鳴る
            GetComponent<AudioSource>().Play();

            // 監督スクリプトに衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();

            //衝突した場合はハートを消す
            Destroy(gameObject);
        }
    }
}
