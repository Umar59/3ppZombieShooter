using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThridCameraPerson : MonoBehaviour
{
    [SerializeField] private GameObject person;
    private float _personPositionX;
    private float _personPositionZ;
    private float _personPositionY;


    void Update()
    {
        _personPositionX = person.transform.position.x;

        _personPositionZ = person.transform.position.z;

        _personPositionY = person.transform.position.y;

        gameObject.transform.position = new Vector3(_personPositionX + 3.312369f, _personPositionY + 4.662919f,
            _personPositionZ - 1.460353f);
    }
}