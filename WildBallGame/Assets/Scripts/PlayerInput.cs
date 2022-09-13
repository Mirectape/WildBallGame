using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WildBallGame.Features
{
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerInput : MonoBehaviour
    {
        private Vector3 movementForce;
        private PlayerMovement playerMovement;
        private float horizontal,
                      vertical;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        private void SetMotionCharacteristics()
        {
            horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);
            movementForce = new Vector3(horizontal, -vertical, 0);
        }

        void Update()
        {
            SetMotionCharacteristics();
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movementForce);
        }
    }
}


