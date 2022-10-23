using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class button_pressed : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clipButtonPress;
    public AudioClip clipFailure;
    public GameObject door;

    private string inputSeqStr;

    public void OnPress(Hand hand) // string name
    {
        audioSource.PlayOneShot(clipButtonPress, 1f);
        Debug.Log("SteamVR Button pressed!");
        Debug.Log(name);
    }

    public void OnPressNorm(string buttonNumber)
    {
        string solution = "74482";
        audioSource.PlayOneShot(clipButtonPress, 1f);
        Debug.Log(buttonNumber);
        inputSeqStr += buttonNumber;
        if (inputSeqStr.Length >= 5)
        {
            if (inputSeqStr == "74482")
            {
                Debug.Log("Success");
                Object.Destroy(door);
            }
            else
            {
                Debug.Log("Failure");
                audioSource.PlayOneShot(clipFailure, 2.5f);
            }
            inputSeqStr = "";
        }
    }

    public void OnCustomButtonPress()
    {
        Debug.Log("We pushed our custom button!");
    }
}
