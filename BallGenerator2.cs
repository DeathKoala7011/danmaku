using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator2 : MonoBehaviour
{
    //[SerializeField] private float _Span = 0.5f;

    public GameObject ball2Prefab;

    float span = 0.5f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(ball2Prefab);
            float px = Random.Range(-8.0f, 8.0f);
            go.transform.position = new Vector3(px, -6.0f, 0);
            //go.transform.position = new Vector3(0, 6, 0);
        }
    }
}
