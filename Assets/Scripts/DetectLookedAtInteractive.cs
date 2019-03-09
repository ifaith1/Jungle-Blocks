using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects interactive elemennts the player is looking at
/// 
/// </summary>

public class DetectLookedAtInteractive : MonoBehaviour
{
    [Tooltip("Starting point of raycast used to detect interactives.")]
    [SerializeField]
    private Transform raycastOrigin;

    [Tooltip("How far from the raycastOrigin we will search for interactive elements.")]
    [SerializeField]
    private float maxRange = 5.0f;

    //private Vector3 raycastDirection;

    private void FixedUpdate()
    {
        //Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, maxRange);
        Debug.DrawRay(raycastOrigin.position, raycastOrigin.forward, Color.red);
        RaycastHit hitInfo;
        bool objectWasDetected = Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out hitInfo, maxRange);

        if (objectWasDetected)
        {
            Debug.Log($"Player is looking at: {hitInfo.collider.gameObject.name}");
        }
    }
}
