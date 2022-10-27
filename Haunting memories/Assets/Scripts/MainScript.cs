using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    static public MainScript Instance;
    public int Count;
    public GameObject Win;
    public GameObject player;
    public GameObject light;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void SwitchChange(int points)
    {
        onCount = onCount + points;
        if (onCount == Count)
        {
            Win.SetActive(false);
            player.SetActive(true);
            light.SetActive(true);
        }
    }
}