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
        // �t���[�����ɓ����Ŕ��ł���
        transform.Translate(_Speed, 0, 0);

        //��ʊO�ɏo����I�u�W�F�N�g��j������
        if (transform.position.x > 11.0f)
        {
            Destroy(gameObject);
        }

        // �����蔻��
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.75f;
        float r2 = 0.75f;

        if (d < r1 + r2)
        {
            //�n�[�g���擾�����ꍇ�Ɍ��ʉ�����
            GetComponent<AudioSource>().Play();

            // �ēX�N���v�g�ɏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();

            //�Փ˂����ꍇ�̓n�[�g������
            Destroy(gameObject);
        }
    }
}
