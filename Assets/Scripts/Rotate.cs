using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Rotate(transform.forward * speed * Time.deltaTime);
    }
}
