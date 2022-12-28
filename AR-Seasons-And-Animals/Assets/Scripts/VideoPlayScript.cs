using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VideoPlayScript : MonoBehaviour
{
    public GameObject horse, koala, bird, elephant, monkey, lion;
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

        horse.SetActive(false);
        koala.SetActive(false);
        bird.SetActive(false);
        elephant.SetActive(false);
        monkey.SetActive(false);
        lion.SetActive(false);
    }

    public void Press(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "HorseButton")
        {
            horse.SetActive(true);
            koala.SetActive(false);
            bird.SetActive(false);
            elephant.SetActive(false);
            monkey.SetActive(false);
            lion.SetActive(false);
        }
        else if (vb.VirtualButtonName == "KoalaButton")
        {
            horse.SetActive(false);
            koala.SetActive(true);
            bird.SetActive(false);
            elephant.SetActive(false);
            monkey.SetActive(false);
            lion.SetActive(false);
        }
        else if (vb.VirtualButtonName == "BirdButton")
        {
            horse.SetActive(false);
            koala.SetActive(false);
            bird.SetActive(true);
            elephant.SetActive(false);
            monkey.SetActive(false);
            lion.SetActive(false);
        }
        else if (vb.VirtualButtonName == "ElephantButton")
        {
            horse.SetActive(false);
            koala.SetActive(false);
            bird.SetActive(false);
            elephant.SetActive(true);
            monkey.SetActive(false);
            lion.SetActive(false);
        }
        else if (vb.VirtualButtonName == "LionButton")
        {
            horse.SetActive(false);
            koala.SetActive(false);
            bird.SetActive(false);
            elephant.SetActive(false);
            monkey.SetActive(false);
            lion.SetActive(true);
        }
        else if (vb.VirtualButtonName == "MonkeyButton")
        {
            horse.SetActive(false);
            koala.SetActive(false);
            bird.SetActive(false);
            elephant.SetActive(false);
            monkey.SetActive(true);
            lion.SetActive(false);
        }
        else
        {
            Debug.Log(vb.VirtualButtonName+ "can not found!");
        }
    }

    public void Release(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName + "button released!");
    }
}
