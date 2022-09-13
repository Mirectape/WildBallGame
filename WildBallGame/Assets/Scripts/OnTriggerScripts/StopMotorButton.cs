using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMotorButton : MonoBehaviour
{
    [SerializeField] private GameObject crazyHammer;
    
    private void OnCollisionEnter()
    {
        crazyHammer.GetComponent<HingeJoint>().useMotor = false;
    }
}
