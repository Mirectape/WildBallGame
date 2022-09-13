using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownBehavior : MonoBehaviour
{
    public GameObject uiHelperInstruction;
    public bool triggerUp;
    public bool triggerDown;
    public bool triggerLeft;
    public bool triggerRight;
    [Header("Where to:")]
    public GameObject top;
    public GameObject bottom;
    public GameObject left;
    public GameObject right;
    [Header("What to:")]
    public GameObject drifter;

    private bool inTriggerZone;


    private void SetDefaulValues()
    {
        inTriggerZone = false;
    }

    private void Awake()
    {
        SetDefaulValues();
    }

    private void OnTriggerEnter()
    {
        inTriggerZone = true;
        uiHelperInstruction.SetActive(true);
    }

    private void OnTriggerExit()
    {
        inTriggerZone = false;
        uiHelperInstruction.SetActive(false);
    }

    private void MovePlatform()
    {
        if (triggerUp && Input.GetKey(KeyCode.E)) 
            drifter.transform.position = Vector3.MoveTowards(drifter.transform.position, top.transform.position, Time.deltaTime*2);
        if (triggerDown && Input.GetKey(KeyCode.E)) 
            drifter.transform.position = Vector3.MoveTowards(drifter.transform.position, bottom.transform.position, Time.deltaTime * 2);
        if (triggerLeft && Input.GetKey(KeyCode.E))
            drifter.transform.position = Vector3.MoveTowards(drifter.transform.position, left.transform.position, Time.deltaTime * 2);
        if (triggerRight && Input.GetKey(KeyCode.E))
            drifter.transform.position = Vector3.MoveTowards(drifter.transform.position, right.transform.position, Time.deltaTime * 2);
    }



    void Update()
    {
        if (inTriggerZone) MovePlatform();
    }

}
