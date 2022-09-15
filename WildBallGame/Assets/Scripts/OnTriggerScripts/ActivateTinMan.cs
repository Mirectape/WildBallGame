using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTinMan : MonoBehaviour
{
    public TinManBehavior tinMan;
    public GameObject uiInfo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") uiInfo.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") tinMan.tinManActivated = true;
        uiInfo.SetActive(false);
    }

}
