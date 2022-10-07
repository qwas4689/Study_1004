using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private RobotBody _robotBody;
    private Vector3 _moveDir;
    private float _mouseX;
    private float _mouseZ;

    [SerializeField]
    private float _rotateSpeed = 2f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _robotBody = GetComponentInChildren<RobotBody>();
    }

    private void Update()
    {
        _moveDir.x = Input.GetAxisRaw("Horizontal");
        _moveDir.z = Input.GetAxisRaw("Vertical");
        _mouseX = Input.GetAxis("Mouse X");
        _mouseZ = Input.GetAxis("Mouse Z");
    }

    private void FixedUpdate()
    {
        RobotRotate();
        RobotMove();
    }

    private void RobotMove()
    {
        _rigidbody.MovePosition(transform.position + _moveDir.normalized * _robotBody.Speed);
    }
    private void RobotRotate()
    {
        gameObject.transform.Rotate(Vector3.up * _rotateSpeed * _mouseX);
    }
}
