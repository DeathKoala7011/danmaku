using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //プレイヤーの移動速度
    [SerializeField] private float _Speed = 0.15f;

    // X軸方向の移動範囲の最小値
    [SerializeField] private float _minX = -8;

    // X軸方向の移動範囲
    [SerializeField] private float _maxX = 8;

    // Y軸範囲の移動範囲の最小値
    [SerializeField] private float _minY = -4;

    // Y軸方向の移動範囲
    [SerializeField] private float _maxY = 4;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        var pos = transform.position;

        // X軸範囲の移動範囲制限
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);

        // Y軸範囲の移動範囲制限
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;

        //上矢印が押された時
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, _Speed, 0); // 上に動かす
        }

        //下矢印が押された時
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -_Speed, 0); // 下に動かす
        }

        //左矢印が押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-_Speed, 0, 0); // 左に動かす
        }

        //右矢印が押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(_Speed, 0, 0); // 右に動かす
        }
    }
}