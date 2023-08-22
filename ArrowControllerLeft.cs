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
        // �t���[�����ɓ����Ŕ��ł���
        transform.Translate(-0.1f, 0, 0);
         
        // ��ʊO�ɏo����I�u�W�F�N�g��j������
        if (transform.position.x < -11.0f)
        {
            Destroy(gameObject);
        }

         // �����蔻��
         Vector2 p1 = transform.position;                // ��̒��S���W
         Vector2 p2 = this.player.transform.position;    // �v���C���[�̒��S���W
         Vector2 dir = p1 - p2;
         float d = dir.magnitude;
         float r1 = 0.4f;    // ��̔��a
         float r2 = 0.75f;   // �v���C���[�̔��a

         if (d < r1 + r2)
         {
              // �ēX�N���v�g�Ƀv���C���[�ƏՓ˂������Ƃ�`����
              GameObject director = GameObject.Find("GameDirector");
              director.GetComponent<GameDirector>().DecreaseHp();

              // �Փ˂����ꍇ�͖������
              Destroy(gameObject);
         }
    }
}