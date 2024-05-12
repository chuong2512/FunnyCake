using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Destroyer");
        
        Destroy(other.gameObject);
        
        /*
        MountainManager.Instance.AddMountain();*/
    }
}