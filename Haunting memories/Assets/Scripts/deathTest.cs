using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathTest : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public GameObject JumpScare;
    public AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            //audioSource.Play();
            audioSource.PlayOneShot(clip, 0.5f);
            Debug.Log("ded");
            player.SetActive(false);
            JumpScare.SetActive(true);
            //enemy.SetActive(false);
            Invoke("Respawn", 0.7f);
        }
    }
    void Respawn()
    {
        JumpScare.SetActive(false);
        enemy.transform.position = new Vector3(-14.11f, -0.498f, -5.8f);
        player.transform.position = new Vector3(-25.93f, 0f, -3.77f);
        //enemy.SetActive(true);
        player.SetActive(true);

    }
}
