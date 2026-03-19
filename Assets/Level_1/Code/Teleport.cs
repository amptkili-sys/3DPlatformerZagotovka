using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleprtPoint;

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleprtPoint.position;
    }
}
