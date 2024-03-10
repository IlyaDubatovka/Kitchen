using System;
using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    [SerializeField] private GameObject _refrigerator;
    private Refrigerator Refrigerator;

    private void Start()
    {
        Refrigerator = _refrigerator.GetComponent<Refrigerator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Refrigerator.Interact();
        }
    }
}