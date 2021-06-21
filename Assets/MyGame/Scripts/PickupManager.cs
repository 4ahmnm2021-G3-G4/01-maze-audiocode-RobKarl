using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    [SerializeField] int pickupCount;
    [SerializeField] GameObject endDoorGO;
    [SerializeField] GameObject endDoorOpenGO;

    public void CollectPickup ()
    {
        pickupCount +=1;

        if (pickupCount==3)
        {
            // Debug.Log("alle 3 gesammelt");
            endDoorGO.SetActive(false);
            endDoorOpenGO.SetActive(true);

        }
    }
}