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
        enemy.transform.position = new Vector3(-6, 1, -20);
        player.transform.position = new Vector3(0, 0, 0);
        //enemy.SetActive(true);
        player.SetActive(true);

    }
}
