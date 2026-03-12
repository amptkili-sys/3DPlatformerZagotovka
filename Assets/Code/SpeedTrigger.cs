using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        other.GetComponent<Jump>().jumpStrength = 7;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
        other.GetComponent<Jump>().jumpStrength = 2;
    }

}
