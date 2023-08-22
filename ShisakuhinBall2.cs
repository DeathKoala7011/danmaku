using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShisakuhinBall2 : MonoBehaviour
{
    // �^�[�Q�b�g�}�[�J�[
    public Vector3 target;

    private Vector3 d;

    // ���˒n�_
    private Vector3 start = new Vector3(0f, -5.0f, 0f);

    // Speed in units per sec.
    public float speed;

    public GameObject player;

    void Start()
    {

        d = (player.transform.position - start) / 5;

        //target = player.transform.position;
    }

    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        gameObject.transform.position = gameObject.transform.position + d * step;

        if (gameObject.transform.position.x < -10 || gameObject.transform.position.x > 10
            || gameObject.transform.position.y < -6 || gameObject.transform.position.y > 6)
        {
            gameObject.transform.position = start;
            d = (player.transform.position - start) / 5;
        }

        // �����蔻��
        Vector2 p1 = transform.position;                // �ʂ̒��S���W
        Vector2 p2 = this.player.transform.position;    // �v���C���[�̒��S���W
        Vector2 dir = p1 - p2;
        float distance = dir.magnitude;
        float r1 = 0.4f; // �ʂ̔��a
        float r2 = 0.75f; // �v���C���[�̔��a

        if (distance < r1 + r2)
        {

            // �ēX�N���v�g�Ƀv���C���[�ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            // �Փ˂����ꍇ�͒e�������ʒu�ɖ߂�
            gameObject.transform.position = start; ;


            GetComponent<AudioSource>().Play();

            // Move our position a step closer to the target.
            //gameObject.transform.position = Vector3.MoveTowards
            //(gameObject.transform.position, target, step);
        }
    }
}