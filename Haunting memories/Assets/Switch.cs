using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject player;
    public GameObject Lights;
    public int RandomNum;
    public GameObject lightSwitch;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("on");
            Lights.SetActive(true);
            RandomNum = 2;
            lightSwitch.SetActive(false);
        }
    }
}
