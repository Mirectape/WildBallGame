using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinManBehavior : MonoBehaviour
{
    public GameObject player1;
    public bool tinManActivated;
    private Vector3 moveDirection;
    Animator animationType;
    private int randomNumberOfStaticPosture;
    private int numberOfCyclesPassed;
    private int maxNumberOfCyclesForOnePosture;

    void Start()
    {
        SetDefaultValues();
    }

    void Update()
    {
        TinManWalks();
    }

    private bool TinManWalks()
    {
        if (tinManActivated)
        {
            transform.position = Vector3.MoveTowards(transform.position, player1.transform.position, Time.deltaTime * 11);
            transform.LookAt(player1.transform);
            return true;
        }

        else return false;
    }

    private void SetDefaultValues()
    {
        moveDirection = transform.position;
        animationType = GetComponent<Animator>();
        numberOfCyclesPassed = 0;
        maxNumberOfCyclesForOnePosture = 3;
    }

    private void StaticPostureConditions()
    {
        if (numberOfCyclesPassed == maxNumberOfCyclesForOnePosture)
        {
            animationType.SetInteger("AnimationNumber", RandomizeStaticPosition());
            numberOfCyclesPassed = 0;
        }
        numberOfCyclesPassed++;
    }

    private void TinManDoesHisThing()
    {
        if (TinManWalks())
        {
            animationType.SetInteger("AnimationNumber", 0);
            animationType.SetBool("InMotion", true);
        }
        if (!TinManWalks())
        {
            animationType.SetBool("InMotion", false);
            StaticPostureConditions();
        }
    }

    private int RandomizeStaticPosition() => randomNumberOfStaticPosture = Random.Range(0, 3);
}
