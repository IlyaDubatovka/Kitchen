using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private Lamp[] lamps;

    private void Start()
    {
        lamps = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (var i = 0; i < lamps.Length; i++)
            {
                lamps[i].Interact();
            }
        }
    }
}