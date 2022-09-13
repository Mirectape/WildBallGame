using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinManBehavior : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection.z += 0.002f;
            transform.position = moveDirection;
            return true;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection.z -= 0.002f;
            transform.position = moveDirection;
            return true;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            moveDirection.x -= 0.002f;
            transform.position = moveDirection;
            return true;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection.x += 0.002f;
            transform.position = moveDirection;
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
        if(numberOfCyclesPassed == maxNumberOfCyclesForOnePosture)
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
