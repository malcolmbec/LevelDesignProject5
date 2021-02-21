using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : Singleton<Inventory>
{
    public int Count { get => count; }
    private int count;

    private AudioClip pickUpSound;
    private Transform playerTransform;

    private void Awake() 
    {
        pickUpSound = Resources.Load<AudioClip>(@"Audio/PickUp");
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void PickUp()
    {
        count++;
        AudioSource.PlayClipAtPoint(pickUpSound, playerTransform.position);
    }
}
