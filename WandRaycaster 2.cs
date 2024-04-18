
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VolumetricLines;

public class WandRaycaster : MonoBehaviour
{
    public float rayLength = 5f; // Length of the ray
    public int wandID = 1;
    public CAVE2.Button laserButton = CAVE2.Button.Button2;

    public GameObject cylinder;
    public GameObject button;
    private AddButton ab;
    public SliderHandle slider;

    void Start()
    {

    }

    void Update()
    {
        if (CAVE2.Input.GetButton(wandID, laserButton))
        {
            cylinder.SetActive(true);
        }

        if (CAVE2.Input.GetButtonUp(wandID, laserButton))
        {
            cylinder.SetActive(false);

            if (button != null)
            {
                button.GetComponent<AddButton>().Push();
                button = null;
            }

            if (slider != null)
            {
                slider.isGrabbed = false;
                slider.handTransform = null;
                slider = null;
            }
        }
    }
}
