using System;
using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;

public class tat : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Add point");
        Debug.Log($"{other.gameObject.name}");
        Data.Player.Gem++;
        Destroy(this.gameObject);
    }
}