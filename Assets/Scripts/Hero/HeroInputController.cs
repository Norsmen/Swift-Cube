using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class HeroInputController : MonoBehaviour
{
    private float horizontalvalue;
    public float Horizontalvalue { get { return horizontalvalue; } }

    void Update()
    {
        HandleHeroHorizontalInput();
    }
    private void HandleHeroHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalvalue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalvalue = 0;
        }
    }
}
