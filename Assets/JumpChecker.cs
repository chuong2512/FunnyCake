using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class JumpChecker : MonoBehaviour
{
    private bool check;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (GameUI.Instance.currentState != State.Stop)
        {
            GameUI.Instance.SetState(State.Running);

            if (col.gameObject.CompareTag("Player"))
            {
                if (check)
                {
                    return;
                }

                check = true;

                DOVirtual.DelayedCall(2, () => { check = false; });
                Player.Instance.Jump();
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (GameUI.Instance.currentState != State.Stop)
        {
            GameUI.Instance.SetState(State.Running);

            if (collision.gameObject.CompareTag("Player"))
            {
                if (check)
                {
                    return;
                }

                check = true;

                DOVirtual.DelayedCall(2, () => { check = false; });
                Player.Instance.Jump();
            }
        }
    }
}