using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightIntensity : MonoBehaviour
{
    public float lightIntesity;
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;
    public Light light6;

    // Start is called before the first frame update
    void Start()
    {
        light1.intensity = lightIntesity;
        light2.intensity = lightIntesity;
        light3.intensity = lightIntesity;
        light4.intensity = lightIntesity;
        light5.intensity = lightIntesity;
        light6.intensity = lightIntesity;
    }

}
