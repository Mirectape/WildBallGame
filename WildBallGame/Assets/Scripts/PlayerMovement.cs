using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WildBallGame.Features
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed;
        private Rigidbody playerRigidBody;

        private void SetDefaultValues() => speed = 4.0f;

        public void MoveCharacter(Vector3 movementForce) => playerRigidBody.AddRelativeForce(movementForce * speed);

        private void Awake()
        {
            playerRigidBody = GetComponent<Rigidbody>();
            SetDefaultValues();
        }

#if UNITY_EDITOR
        [ContextMenu("ResetValues")]
        public void ResetValues() => SetDefaultValues();
#endif

    }
}