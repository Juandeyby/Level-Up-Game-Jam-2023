using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnDrag : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.eulerAngles += Vector3.forward * 45f;
            }
        }
            
    }

}
