// MIT License
// Copyright (c) 2024 Artem-Nesterenko2005
// All rights reserved

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// class for implementing the death of a player when meeting a slender.
/// </summary>
public class PlayerDeath : MonoBehaviour
{
    /// <summary>
    /// sound source for screamer.
    /// </summary>
    [SerializeField]
    private AudioSource source;

    /// <summary>
    /// death poster
    /// </summary>
    [SerializeField]
    private TMP_Text poster;

    /// <summary>
    /// player
    /// </summary>
    [SerializeField]
    private Camera player;

    /// <summary>
    /// limits the movement of the player, the camera, triggers a screamer when interacting with a trigger.
    /// </summary>
    private void OnTriggerEnter()
    {
        player.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        player.transform.position = new Vector3(0.939f, 5.267f, -1.254f);
        player.transform.rotation = Quaternion.Euler(20, 65, 0);

        player.GetComponent<Rigidbody>().isKinematic = true;
        player.GetComponent<Moves>().enabled = false;
        player.GetComponent<CameraMouseControl>().enabled = false;
        player.GetComponent<AudioSource>().enabled = false;

        this.source.PlayOneShot(this.source.clip, 0.5f);
        Instantiate(this.poster);
        Invoke("SpawnPoster", source.clip.length);
    }

    /// <summary>
    /// spawn death poster
    /// </summary>
    private void SpawnPoster()
    {
        this.poster.transform.position = new Vector3(0.537f, 4.404f, -6.526f);
        player.transform.position = new Vector3(0.701f, 4.543f, -4.737f);
        player.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
