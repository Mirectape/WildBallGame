using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinManActivate : MonoBehaviour
{
    public GameObject tinMan;
    public GameObject tinManInfoUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tinManInfoUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        tinManInfoUI.SetActive(false);
        tinMan.GetComponent<TinManBehavior>().tinManActivated = true;
    }
}
