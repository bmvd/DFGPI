using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{
    //public GameObject JumpScare;
    //public GameObject player;
    public int respawn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.CompareTag("player"))
        {
            Debug.Log("ded");
            //SceneManager.LoadScene(SceneManager.getActiveScene().buildIndex);
            SceneManager.LoadScene(respawn);
            //player.SetActive(false);
            //JumpScare.SetActive(true);
            //Invoke("Respawn", 1f);
        }
    }
    void Respawn()
    {
        SceneManager.LoadScene(respawn);
        
    }
}
