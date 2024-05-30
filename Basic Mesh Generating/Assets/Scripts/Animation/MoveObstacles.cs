using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveObstacles : MonoBehaviour
{
    [SerializeField] private float X;
    [SerializeField] private float Y;
    [SerializeField] private float Z;
    [SerializeField] private float ForcePower;
    [SerializeField] private float _timer;
    Rigidbody _rb;
    Vector3 _forceVector;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _forceVector = new Vector3(X, Y, Z);

        _rb.AddForce(_forceVector * ForcePower * Time.fixedDeltaTime, ForceMode.Force);
        
    }
}
