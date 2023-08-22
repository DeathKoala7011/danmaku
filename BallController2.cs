using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallController2 : MonoBehaviour
{
    private GameObject target;

    void Start()
    {
        // ���O�ŃI�u�W�F�N�g����肷��̂ňꌾ���܂ō��v�����邱��
        target = GameObject.Find("player");
    }

    void Update()
    {
        //�uLookAt���\�b�h�v�̊��p
        this.gameObject.transform.LookAt(target.transform.position);



        // ��ʊO�ɏo����I�u�W�F�N�g��j������
        if (transform.position.x < 10.0f)
        {
            Destroy(gameObject);
        }

        // ��ʊO�ɏo����I�u�W�F�N�g��j������
        if (transform.position.y < 7.0f)
        {
            Destroy(gameObject);
        }

        // �����蔻��
        Vector2 p1 = transform.position;                // ��̒��S���W
        Vector2 p2 = this.target.transform.position;    // �v���C���[�̒��S���W
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.4f; // �{�[���̔��a
        float r2 = 0.75f; // �v���C���[�̔��a

        if (d < r1 + r2)
        {

            // �ēX�N���v�g�Ƀv���C���[�ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
        }
    }
}