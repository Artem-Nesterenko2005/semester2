// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// class for randow slender spawn.
/// </summary>
public class RandomSlenderSpawn : MonoBehaviour
{
    /// <summary>
    /// object to spawn.
    /// </summary>
    [SerializeField]
    private GameObject slender;

    /// <summary>
    /// spawn slender with a 25 percent chance when interacting with a trigger.
    /// </summary>
    private void OnTriggerEnter()
    {
        System.Random random = new ();
        if (random.Next(1, 4) == 1)
        {
                Instantiate(this.slender);
                this.slender.transform.position = new Vector3(1.301f, 4.661f, -1.074f);
        }
    }
}
