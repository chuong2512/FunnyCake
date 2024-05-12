using System;
using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerSkin : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer Renderer;
    private static readonly int Blend = Animator.StringToHash("Blend");

    private void OnValidate()
    {
        Renderer = GetComponentInChildren<SpriteRenderer>();
    }

    [Button]
    private void Start()
    {
        animator.SetFloat(Blend, (float) Data.Player.currentSkin / 3);

        Renderer.sprite = SkinDataManager.Instance.CurrentSkin;
        animator.SetTrigger("jump");
    }
}