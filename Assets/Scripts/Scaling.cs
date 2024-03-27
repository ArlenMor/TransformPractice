using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scalingForce;

    void Update()
    {
        transform.localScale += Vector3.one * _scalingForce;
    }
}
