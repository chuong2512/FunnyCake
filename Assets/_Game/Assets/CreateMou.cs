using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMou : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Add Mou");
        
        if (other.gameObject.name == "Player")
        {
            MountainManager.Instance.AddMountain();
        }
    }
}
