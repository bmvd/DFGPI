using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject Fade;
    public GameObject endscreen;
    public GameObject endscreen2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
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
        endscreen2.SetActive(true);

    }
}
