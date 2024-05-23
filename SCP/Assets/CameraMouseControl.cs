// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

/// <summary>
/// class for camera movement.
/// </summary>
public class CameraMouseControl : MonoBehaviour
{
    /// <summary>
    /// implementation of camera movement.
    /// </summary>
    // Update is called once per frame
    private void Update()
    {
        var horizontal = Input.GetAxis("Mouse X");
        this.transform.Rotate(0, horizontal, 0);
    }
}
