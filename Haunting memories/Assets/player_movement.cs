using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_movement : MonoBehaviour
{
    public GameObject scare;
    public GameObject player;
    public int respawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }
     if (Input.GetKeyDown("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
        }
     if (Input.GetKeyDown("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
        }
     if (Input.GetKeyDown("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        }
     if (Input.GetKeyDown("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }
    }


}
