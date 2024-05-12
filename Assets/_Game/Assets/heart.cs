using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;

public class heart : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Data.Player.Gem++;
        gameObject.SetActive(false);
    }
}