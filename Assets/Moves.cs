// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// class for player movement.
/// </summary>
public class Moves : MonoBehaviour
{
    /// <summary>
    /// implementation of player movement.
    /// </summary>
    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        Vector3 velocity = direction * 0.003f;

        this.transform.Translate(velocity);
    }
}
