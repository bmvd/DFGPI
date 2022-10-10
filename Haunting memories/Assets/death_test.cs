using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_test : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public GameObject JumpScare;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ded");
            player.SetActive(false);
            JumpScare.SetActive(true);
            enemy.SetActive(false);
            Invoke("Respawn", 0.7f);
        }
    }
    void Respawn()
    {
        JumpScare.SetActive(false);
        enemy.transform.position = new Vector3(-6, 1, 0);
        player.transform.position = new Vector3(0, 1, 0);
        enemy.SetActive(true);
        player.SetActive(true);

    }
}
