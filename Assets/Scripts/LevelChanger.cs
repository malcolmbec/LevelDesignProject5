using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class LevelChanger : MonoBehaviour
{
    public int FoodThreshold;
    public GameObject ObjectToDeactivate;
    public GameObject ObjectToActivate;

    private void Awake() 
    {
        Collider collider = GetComponent<Collider>();
        collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player" && Inventory.Instance.Count >= FoodThreshold)
        {
            ObjectToDeactivate.SetActive(false);
            ObjectToActivate.SetActive(true);
        }
    }
}
