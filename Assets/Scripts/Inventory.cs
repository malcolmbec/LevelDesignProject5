using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : Singleton<Inventory>
{
    public int Count { get => count; }
    private int count;

    public void PickUp()
    {
        count++;
    }
}
