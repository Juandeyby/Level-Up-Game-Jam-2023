using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudmovement : MonoBehaviour
{
    private Rigidbody2D rb;
    float _speed = 2f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.transform.Translate(new Vector2(-1,0) * Time.deltaTime * _speed);
    }
}
