// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

/// <summary>
/// class for removing an object slender.
/// </summary>
public class SlenderDelete : MonoBehaviour
{
    /// <summary>
    /// object to be deleted.
    /// </summary>
    [SerializeField]
    private GameObject slender;

    /// <summary>
    /// delete slender when interacting with a trigger.
    /// </summary>
    private void OnTriggerEnter()
    {
        Destroy(this.slender);
    }
}
