﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        // Get the current screen position of the mouse from Input
        Vector3 mousePos2D =
        Input.mousePosition; // a
                             // The Camera's z position sets how far to push the mouse into 3D
        mousePos2D.z = -
        Camera.main.transform.position.z; // b
                                          // Convert the point from 2D screen space into 3D game world spac
        e
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D)
        ; // c
          // Move the x position of this Basket to the x position of the Mo
        use
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

}
