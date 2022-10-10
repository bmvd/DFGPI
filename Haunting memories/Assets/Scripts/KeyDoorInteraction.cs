using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDoorInteraction : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            Object.Destroy(this.gameObject);
            Object.Destroy(other.gameObject);
        }
    }
}
