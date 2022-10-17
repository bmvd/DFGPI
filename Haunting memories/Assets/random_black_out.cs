using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class random_black_out : MonoBehaviour
{
    public GameObject Lights;
  
    // Start is called before the first frame update
    void Start()
    {
        Lights.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        int RandomNum = Random.Range(1, 2000);
        Debug.Log(RandomNum);
        if (RandomNum == 1)
        {
            Lights.SetActive(false);
            
            SceneManager.LoadScene(1);
        }
    }
}
