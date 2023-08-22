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
        // �t���[�����ɓ����Ŕ��ł���
        transform.Translate(-0.1f, -0.1f, 0);
        
        // ��ʊO�ɏo����I�u�W�F�N�g��j�󂷂�
        if (transform.position.y < -7.0f)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }

         // �����蔻��
         Vector2 p1 = transform.position;                // �{�[���̒��S���W
         Vector2 p2 = this.player.transform.position;    // �v���C���[�̒��S���W
         Vector2 dir = p1 - p2;
         float d = dir.magnitude;
         float r1 = 0.5f; // �{�[���̔��a
         float r2 = 0.75f; // �v���C���[�̔��a

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