using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform Target;
    [SerializeField] private Vector3 OffSet;
    [SerializeField] private float SmoothTime = .125f;

    Vector3 _velocity;

    void Update()
    {

        Vector3 targetPosition = Target.position + OffSet;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, SmoothTime);

    }
}
