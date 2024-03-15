using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField]private Shelf[] _shelves;

    private void Start()
    {
        for (var i = 0; i < _shelves.Length; i++)
        {
            _shelves[i].ItemSpawned += CheckStrengthShelf;
        }
    }

    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    private void CheckStrengthShelf()
    {
        for (var i = 0; i < _shelves.Length; i++)
        {
            if (_shelves[i].ItemsCount==3)
            {
                _shelves[i].Fall();
            }
        }
    }
}