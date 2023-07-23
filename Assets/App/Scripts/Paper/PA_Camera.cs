using System;
using UnityEngine;
using UnityEngine.Events;

namespace App.Scripts.Paper
{
    public class PA_Camera : MonoBehaviour
    {
        public float movementSpeed = 1.0f; // Movement speed (adjust according to your preference)
        public float rotationSpeed = 1.0f; // Rotation speed (adjust according to your preference)

        private Transform _originObject; // Object that will be moved (this script should be attached to it)
        private Transform _targetObject; // Current target to move towards
        
        public UnityEvent onCameraSetTarget;

        private void Start()
        {
            _originObject = transform;
        }

        public void SetOrigin(Transform newOrigin)
        {
            var t = transform;
            t.position = newOrigin.position;
            t.rotation = newOrigin.rotation;
        }

        private void Update()
        {
            if (_targetObject == null) return;
            // Interpolate the position and rotation of the origin object towards the target object
            var newPosition = Vector3.Lerp(_originObject.position, _targetObject.position, Time.deltaTime * movementSpeed);
            var newRotation = Quaternion.Lerp(_originObject.rotation, _targetObject.rotation, Time.deltaTime * rotationSpeed);

            // Update the position and rotation of the origin object
            _originObject.position = newPosition;
            _originObject.rotation = newRotation;
                
            if (Vector3.Distance(_originObject.position, _targetObject.position) < 0.1f)
            {
                _targetObject = null;
                onCameraSetTarget.Invoke();
                onCameraSetTarget.RemoveAllListeners();
            }
        }

        // Method to set a new target
        public void SetTarget(Transform newTarget, UnityAction action = null)
        {
            _targetObject = newTarget;
            if (action == null) return;
            onCameraSetTarget.AddListener(action);
        }
    }
}
