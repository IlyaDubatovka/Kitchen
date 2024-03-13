using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private GameObject _waffle;
    [SerializeField] private Transform _wafflePosition;
    [SerializeField] private GameObject _toasterGO;

    private Toaster _toaster;
    //private Toaster toaster;

    private void Start()
    {
        _toaster = FindObjectOfType<Toaster>();
        _toaster.TimerIsUp += CreateWaffle;
    }

    private void CreateWaffle()
    {
        Instantiate(_waffle, _wafflePosition);
    }
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
}