using System;
using UnityEngine;
using UnityEngine.Events;

namespace App.Scripts.Paper
{
    public class PA_Camera : MonoBehaviour
    {
        public float movementSpeed = 1.0f; // Movement speed (adjust according to your preference)
        public float rotationSpeed = 1.0f; // Rotation speed (adjust according to your preference)

        private Transform originObject; // Object that will be moved (this script should be attached to it)
        private Transform targetObject; // Current target to move towards
        
        public UnityEvent onCameraSetTarget;

        private void Start()
        {
            originObject = transform; // The object with the script is the origin object
        }

        private void Update()
        {
            if (targetObject == null) return;
            // Interpolate the position and rotation of the origin object towards the target object
            Vector3 newPosition = Vector3.Lerp(originObject.position, targetObject.position, Time.deltaTime * movementSpeed);
            Quaternion newRotation = Quaternion.Lerp(originObject.rotation, targetObject.rotation, Time.deltaTime * rotationSpeed);

            // Update the position and rotation of the origin object
            originObject.position = newPosition;
            originObject.rotation = newRotation;
                
            if (Vector3.Distance(originObject.position, targetObject.position) < 0.1f)
            {
                targetObject = null;
                onCameraSetTarget.Invoke();
                onCameraSetTarget.RemoveAllListeners();
            }
        }

        // Method to set a new target
        public void SetTarget(Transform newTarget, UnityAction action = null)
        {
            targetObject = newTarget;
            if (action == null) return;
            onCameraSetTarget.AddListener(action);
        }

        // Method to return to the initial origin
        public void ReturnToOrigin()
        {
            targetObject = null;
            // Make sure the object returns to its original position and rotation.
            originObject.position = Vector3.zero; // Change "Vector3.zero" to the original position of the object.
            originObject.rotation = Quaternion.identity; // Change "Quaternion.identity" to the original rotation of the object.
        }
    }
}
