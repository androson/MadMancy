using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    [SerializeField] private GameObject cameraOne;
    [SerializeField] private GameObject cameraTwo;
    [SerializeField] private GameObject cameraThree;

    //int buttonPress = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void ButtonPress()
    {/*
        int buttonPress = +1;
        if (buttonPress == 3)
        {
            buttonPress = 0;
        }
        */
        if (cameraOne.activeInHierarchy == true)
        {
            
            InsideHouse();
        }
        else if (cameraTwo.activeInHierarchy == true)
        {
            InsideBasement();
        }
        else if (cameraThree.activeInHierarchy == true)
        {
            OutsideHouse();
        }
    }
    /*

    public void ButtonManager()
    {
        if (buttonPress == 0)
        {
            OutsideHouse();
        }
        else if (buttonPress == 1)
        {
            InsideHouse();
        }
        else
        {
            OutsideHouse();
        }
       else if (buttonPress == 2)
        {

        }
       
    }*/

    public void OutsideHouse()
    {
        cameraOne.SetActive(true);
        cameraTwo.SetActive(false);
        cameraThree.SetActive(false);
    }

    public void InsideHouse()
    {
        cameraOne.SetActive(false);
        cameraTwo.SetActive(true);
        cameraThree.SetActive(false);
    }
    public void InsideBasement()
    {
        cameraOne.SetActive(false);
        cameraTwo.SetActive(false);
        cameraThree.SetActive(true);
    }
}
