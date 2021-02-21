using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Outline))]
public class Loot : MonoBehaviour
{
    private bool hovered = false;

    private Outline outline;

    private void Awake() 
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
    }

    private void Update() 
    {
        if (hovered && Input.GetButtonDown("PickUp"))
        {
            Inventory.Instance.PickUp();
            Destroy(gameObject);
        }
    }

    private void OnMouseEnter() 
    {
        outline.enabled = true;
        hovered = true;
    }
    
    private void OnMouseExit() 
    {
        outline.enabled = false;
        hovered = false;
    }
}
