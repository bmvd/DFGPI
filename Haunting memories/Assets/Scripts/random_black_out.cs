using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class random_black_out : MonoBehaviour
{
    public GameObject Lights;
    public GameObject lights_task;
    public GameObject player;
    public int RandomNum;

    // Start is called before the first frame update
    void Start()
    {
        Lights.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        RandomNum = Random.Range(1, 700);
        //Debug.Log(RandomNum);
        if (RandomNum == 1)
        {
            Debug.Log("player disabled");
            Lights.SetActive(false);
            player.SetActive(false);
            lights_task.SetActive(true);
        }
    }
}
