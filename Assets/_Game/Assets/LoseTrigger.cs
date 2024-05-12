using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Losee");
        
        if (other.gameObject.CompareTag("Player"))
        {
            GameUI.Instance.ShowLose();
            Destroy(this.gameObject);
        }
    }
}
