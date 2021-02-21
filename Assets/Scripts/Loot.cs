using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Outline))]
public class Loot : MonoBehaviour
{
    private Outline outline;

    private void Awake() 
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
    }

    private void OnMouseEnter() 
    {
        outline.enabled = true;
    }
    
    private void OnMouseExit() 
    {
        outline.enabled = false;
    }
}
