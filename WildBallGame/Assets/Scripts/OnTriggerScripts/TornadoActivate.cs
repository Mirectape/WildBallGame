using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoActivate : MonoBehaviour
{
    public GameObject tornados;
    public GameObject scoreSheet;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            tornados.SetActive(true);
            scoreSheet.SetActive(true);
        }
    }

}
