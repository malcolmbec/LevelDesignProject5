using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Outline))]
public class Loot : MonoBehaviour
{
    private static float pickUpRange = 4f;

    private static Transform playerTransform;

    private bool hovered = false;

    private Outline outline;

    private void Awake() 
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;

        if (!playerTransform)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    private void Update() 
    {
        if (hovered && Input.GetButtonDown("PickUp"))
        {
            Inventory.Instance.PickUp();
            Destroy(gameObject);
        }
    }

    private void OnMouseOver() 
    {
        if (Vector3.Distance(transform.position, playerTransform.position) <= pickUpRange)
        {
            outline.enabled = true;
            hovered = true;
        }
    }
    
    private void OnMouseExit() 
    {
        outline.enabled = false;
        hovered = false;
    }
}
