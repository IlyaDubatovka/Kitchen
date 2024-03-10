using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] private GameObject _lamp;
    [SerializeField] private Transform _lampPosition;

    private void Awake()
    {
        Instantiate(_lamp, _lampPosition);
    }
}