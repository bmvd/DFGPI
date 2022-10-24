using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject up;
    public GameObject on;
    public bool isOn;
    public bool isUp;
    private bool activeAgain;

    // Start is called before the first frame update
    void Start()
    {
        int OnOff = Random.Range(0, 2);
        Debug.Log(OnOff);
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
        up.SetActive(isUp);
        if (isOn)
        {
            MainScript.Instance.SwitchChange(1);
        }
        activeAgain = true;
    }
    void Update()
    {
        if (gameObject.activeSelf && activeAgain)
        {
            int OnOff = Random.Range(0, 2);
            Debug.Log(OnOff);
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
            activeAgain = false;
        }
        else if (!gameObject.activeSelf)
        {
            activeAgain = true;
        }
    }


    private void OnMouseUp()
    {
        isUp = !isUp;
        isOn = !isOn;
        on.SetActive(isOn);
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
