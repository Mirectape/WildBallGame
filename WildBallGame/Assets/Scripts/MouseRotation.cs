using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    public GameObject player;
    private Vector2 turn;

    private void SetDefaultValues()
    {
        turn.y = -104f; // that's how the camera is initially set
    }

    private void ConductRotation()
    {
        turn.x += Input.GetAxis("Mouse X"); 
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);
        player.transform.rotation = Quaternion.Euler(-90, turn.x, 0); // -90f to account for an initial position of the player
    }

    void Start()
    {
        SetDefaultValues();
    }

    void Update()
    {
        ConductRotation();
    }
}
