// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;

/// <summary>
/// class for change poster text.
/// </summary>
public class ChangePoster : MonoBehaviour
{
    /// <summary>
    /// object poster.
    /// </summary>
    [SerializeField]
    private TMP_Text poster;

    /// <summary>
    /// poster text changes randomly.
    /// </summary>
    /// <param name="player">object player.</param>
    private void OnTriggerEnter(Collider player)
    {
        System.Random random = new ();
        switch (random.Next(1, 3))
        {
            case 1:
                this.poster.text = "\nТы его видел?";
                break;

            case 2:
                this.poster.text = "\nГде остальные?";
                break;

            case 3:
                this.poster.text = "\nСлышишь?";
                break;
        }
    }
}
