using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTornado : MonoBehaviour
{
    public GameObject tornados;
    public GameObject scoreSheet;

    private void OnTriggerExit()
    {
        tornados.SetActive(true);
        scoreSheet.SetActive(true);
    }
}
