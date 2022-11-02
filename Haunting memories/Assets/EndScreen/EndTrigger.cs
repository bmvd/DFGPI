using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject Fade;
    public GameObject endscreen;
    public GameObject endscreen2;
    public Light endLight;
    public GameObject enemy;
    public GameObject lights;
    public AudioSource audioSource;
    public AudioClip angelicChoir;
    private float counter;
    private bool endReached;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("Win");

            audioSource.PlayOneShot(angelicChoir, 1f);

            float counter = 0f;
            endReached = true;

            Invoke("EndScreen", 10f);
        }
    }

    private void Update()
    {
        if (endReached & counter < 500)
        {
            counter += 1;
            endLight.intensity = counter / 35;
        }
    }

    private void EndScreen()
    {
        player.SetActive(false);
        enemy.SetActive(false);
        lights.SetActive(false);
        Fade.SetActive(true);
        endscreen.SetActive(true);
        endscreen2.SetActive(true);

    }
}
