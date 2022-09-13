using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToOpenDoors : MonoBehaviour
{
    public Animator doorAnimation;
    public GameObject uiHelper; // "press E" text 
    private bool insideTrigger; // registrates if one is inside the area

    private void SetDefaultValues()
    {
        insideTrigger = false;
    }

    private IEnumerator timerToHint()
    {
        yield return new WaitForSeconds(3);
        uiHelper.SetActive(true);
    }

    private void OnTriggerEnter()
    {
        StartCoroutine(timerToHint());
        insideTrigger = true;
    }

    private void OnTriggerExit()
    {
        insideTrigger = false;
        uiHelper.SetActive(false);
        doorAnimation.SetBool("NeededButtonIsPressed", false);
    }

    private void OpenDoorConditions()
    {
        if (Input.GetKey(KeyCode.E) && insideTrigger) doorAnimation.SetBool("NeededButtonIsPressed", true);
    }  

    private void Awake()
    {
        SetDefaultValues();
    }

    private void Update()
    {
        OpenDoorConditions();
    }
}
