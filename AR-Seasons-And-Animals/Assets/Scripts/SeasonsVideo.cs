using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SeasonsVideo : MonoBehaviour
{
    public GameObject winter, summer, spring, autumn;
    VirtualButtonBehaviour[] vbtn;
    // Start is called before the first frame update
    void Start()
    {
        vbtn = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbtn.Length; i++)
        {
            vbtn[i].RegisterOnButtonPressed(Press);
            vbtn[i].RegisterOnButtonReleased(Release);
        }

        winter.SetActive(false);
        summer.SetActive(false);
        spring.SetActive(false);
        autumn.SetActive(false);

    }

    public void Press(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "WinterButton")
        {
            winter.SetActive(true);
            summer.SetActive(false);
            spring.SetActive(false);
            autumn.SetActive(false);

        }
        else if (vb.VirtualButtonName == "SummerButton")
        {
            winter.SetActive(false);
            summer.SetActive(true);
            spring.SetActive(false);
            autumn.SetActive(false);

        }
        else if (vb.VirtualButtonName == "SpringButton")
        {
            winter.SetActive(false);
            summer.SetActive(false);
            spring.SetActive(true);
            autumn.SetActive(false);

        }
        else if (vb.VirtualButtonName == "AutumnButton")
        {
            winter.SetActive(false);
            summer.SetActive(false);
            spring.SetActive(false);
            autumn.SetActive(true);

        }
        else
        {
            Debug.Log(vb.VirtualButtonName + "can not found!");
        }
    }

    public void Release(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName + "button released!");
    }
}
