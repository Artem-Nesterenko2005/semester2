// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// class for teleporting the player to the previous floor.
/// </summary>
public class PlayerTeleport : MonoBehaviour
{
    /// <summary>
    /// teleporting the player to the previous floor when interacting with a trigger.
    /// </summary>
    /// <param name="player">object player.</param>
    private void OnTriggerEnter(Collider player)
    {
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.75f, player.transform.position.z);
    }
}
