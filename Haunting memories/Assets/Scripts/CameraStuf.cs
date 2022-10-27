// Make an empty game object and then just add this script to it
// Make sure you have 2 cameras, each with a differnt target display
// Not sure how well this translates to VR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStuf: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Display.displays.Length; i++)
            Display.displays[i].Activate(1920,1080,60);
    }

}
