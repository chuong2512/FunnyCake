using System;
using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using Sirenix.OdinInspector;
using UnityEngine;

public class Player : Singleton<Player>
{
    public Animator animator;

    public Rigidbody2D rigidbody2D;
    public Collider2D collider;

    public bool isJumping = false;

    private void OnValidate()
    {
        rigidbody2D = GetComponentInChildren<Rigidbody2D>();
        collider = GetComponentInChildren<Collider2D>();
    }

    public float CheckRight, CheckLeft;

    // Start is called before the first frame update
    void Start()
    {
        CheckRight = Camera.main.orthographicSize * Camera.main.aspect - 0.3f;
        CheckLeft = -Camera.main.orthographicSize * Camera.main.aspect + 0.3f;
    }

    private Vector3 Vec;
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        if (GameUI.Instance.currentState != State.Stop)
        {
#if UNITY_EDITOR
            Vec = transform.localPosition;
            Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;

            if (Vec.x >= CheckRight)
            {
                Vec.x = CheckRight;
            }

            if (Vec.x <= CheckLeft)
            {
                Vec.x = CheckLeft;
            }

            transform.localPosition = Vec;


#elif UNITY_ANDROID
           Vec = transform.localPosition;
            Vec.x += Input.acceleration.x * Time.deltaTime * speed;

            if (Vec.x >= CheckRight)
            {
                Vec.x = CheckRight;
            }

            if (Vec.x <= CheckLeft)
            {
                Vec.x = CheckLeft;
            }

            transform.localPosition = Vec;
#endif
        }


        if (isJumping)
        {
            if (rigidbody2D.velocity.y < 0)
            {
                isJumping = false;
                collider.isTrigger = false;
            }
        }
    }

    public float force = 1;
    private static readonly int Blend = Animator.StringToHash("Blend");

    [Button]
    public void Jump()
    {
        isJumping = true;
        collider.isTrigger = true;
        rigidbody2D.AddForce(Vector2.up * force);
        animator.SetTrigger("jump");
    }

    public void ForrceJump()
    {
        isJumping = true;
        collider.isTrigger = true;
        rigidbody2D.AddForce(Vector2.up * force);
        animator.SetTrigger("jump");
    }
}