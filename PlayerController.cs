using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //�v���C���[�̈ړ����x
    [SerializeField] private float _Speed = 0.15f;

    // X�������̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minX = -8;

    // X�������̈ړ��͈�
    [SerializeField] private float _maxX = 8;

    // Y���͈͂̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minY = -4;

    // Y�������̈ړ��͈�
    [SerializeField] private float _maxY = 4;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        var pos = transform.position;

        // X���͈͂̈ړ��͈͐���
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);

        // Y���͈͂̈ړ��͈͐���
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;

        //���󂪉����ꂽ��
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, _Speed, 0); // ��ɓ�����
        }

        //����󂪉����ꂽ��
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -_Speed, 0); // ���ɓ�����
        }

        //����󂪉����ꂽ��
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-_Speed, 0, 0); // ���ɓ�����
        }

        //�E��󂪉����ꂽ��
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(_Speed, 0, 0); // �E�ɓ�����
        }
    }
}