using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJump : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (GameUI.Instance.currentState != State.Stop)
        {
            GameUI.Instance.SetState(State.Running);
            
            if (col.gameObject.CompareTag("Col"))
            {
                Player.Instance.Jump();
            }
            else if (col.gameObject.CompareTag("Point"))
            {
                col.gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Point"))
        {
            col.gameObject.SetActive(false);
        }
    }
}