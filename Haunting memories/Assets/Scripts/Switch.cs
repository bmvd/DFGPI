using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject up;
    public GameObject on;
    public GameObject off;
    public bool isOn;
    public bool isUp;
    private MainScript mainScript;

    // Start is called before the first frame update
    void Start()
    {
        mainScript = MainScript.Instance;
        mainScript.SwitchChange(0);
    }

    void OnEnable()
    {
        Invoke("setSwitch", 0);
    }

    void setSwitch()
    {
        int OnOff = Random.Range(0, 2);
        //Debug.Log(OnOff);
        if (OnOff == 1)
        {
            isUp = false;
            isOn = true;
        }
        else
        {
            isUp = true;
            isOn = false;
        }
        on.SetActive(isOn);
        off.SetActive(!isOn);
        up.SetActive(isUp);
        if (isOn)
        {
            MainScript.Instance.SwitchChange(1);
        }
    }

    private void OnMouseUp()
    {
        isUp = !isUp;
        isOn = !isOn;
        on.SetActive(isOn);
        off.SetActive(!isOn);
        up.SetActive(isUp); 
        if (isOn)
        {
            MainScript.Instance.SwitchChange(1);
        }
        else
        {
            MainScript.Instance.SwitchChange(-1);
        }
    }
}
