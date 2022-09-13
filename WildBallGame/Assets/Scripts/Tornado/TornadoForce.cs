using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class TornadoForce : MonoBehaviour
{
    public GameObject tornadoCrone; // WhereToPush

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "ObjectsToThrow")
            other.gameObject.GetComponent<Rigidbody>().AddForce(tornadoCrone.transform.position*5);
    }
}
