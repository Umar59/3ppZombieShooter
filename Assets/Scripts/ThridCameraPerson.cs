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

        gameObject.transform.position = new Vector3(_personPositionX , _personPositionY + 6.54f,
            _personPositionZ -4.54f);

       //gameObject.transform.rotation = person.transform.rotation;
    }
}