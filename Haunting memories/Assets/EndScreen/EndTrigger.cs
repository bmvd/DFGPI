using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject Fade;
    public GameObject endscreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Win");
            player.SetActive(false);
            Fade.SetActive(true);
            Invoke("EndScreen", 1.7f);
        }
    }
    private void EndScreen()
    {
        endscreen.SetActive(true);
    }
}
