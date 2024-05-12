using System;
using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;
using Random = UnityEngine.Random;

public class MountainManager : Singleton<MountainManager>
{
    public GameObject Mountain;
    public float speed = 4;

    private readonly float dis = 2.6f;
    private float countTime;
    private float timeee = 1f;

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            AddMountain();
        }
    }

    public void AddMountain()
    {
        var lastPos = transform.GetChild(transform.childCount - 1);

        var child = Instantiate(Mountain, transform);

        var range = Camera.main.orthographicSize * Camera.main.aspect - 0.8f;

        child.transform.localPosition = Vector3.up * lastPos.localPosition.y + Vector3.up * Random.Range(0.7f, 1.2f) +
                                        Vector3.right * Random.Range(-range, range);

        if (Random.Range(0, 3) == 0)
        {
            if (child.transform.localPosition.x > 1f)
            {
                var child2 = Instantiate(Mountain, transform);
                child2.transform.localPosition = Vector3.up * lastPos.localPosition.y +
                                                 Vector3.up * Random.Range(0.7f, 1.2f) +
                                                 Vector3.right * Random.Range(-range, -0.8f);
            }
            else if (child.transform.localPosition.x < -1f)
            {
                var child2 = Instantiate(Mountain, transform);
                child2.transform.localPosition = Vector3.up * lastPos.localPosition.y +
                                                 Vector3.up * Random.Range(0.7f, 1.2f) +
                                                 Vector3.right * Random.Range(0.8f, range);
            }
        }
    }

    public void Move()
    {
    }


    private void Update()
    {
        if (GameUI.Instance.currentState != State.Stop)
        {
            countTime -= Time.deltaTime;

            if (countTime <= 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    AddMountain();
                }

                countTime = timeee;
            }
        }

        /*if (GameUI.Instance.currentState != State.Stop)
        {
            transform.position = (Vector2)transform.position + Time.deltaTime * Vector2.left * speed;
        }*/
    }
}