using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyyyy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameUI.Instance.ShowLose();
            return;
        }
        
        Debug.Log($"{col.gameObject.tag}");
        if (!col.gameObject.CompareTag("Die"))
        {
          Destroy(col.gameObject);
        }
        
    }
}
