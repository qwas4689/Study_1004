using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private RobotBody _robotBody;
    private Vector3 _moveDir;
    private float _mouseX;
    private float _mouseMoveX;
    private float _mouseY;
    private float _mouseMoveY;

    [SerializeField]
    private float _rotateSpeed = 200f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _robotBody = GetComponentInChildren<RobotBody>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        RobotRotate();
        RobotMove();
    }

    private void RobotMove()
    {
        _moveDir.x = Input.GetAxisRaw("Horizontal");
        _moveDir.z = Input.GetAxisRaw("Vertical");

        _rigidbody.MovePosition(transform.position + _moveDir.normalized * _robotBody.Speed);
    }
    private void RobotRotate()
    {
        _mouseX = -Input.GetAxis("Mouse Y") * Time.deltaTime * _rotateSpeed;
        _mouseY = Input.GetAxis("Mouse X") * Time.deltaTime * _rotateSpeed;

        _mouseMoveX = _mouseMoveX + _mouseX;
        _mouseMoveY = transform.eulerAngles.y + _mouseY;

        _mouseMoveX = Mathf.Clamp(_mouseMoveX, 0f, 0f);

        transform.eulerAngles = new Vector3(_mouseMoveX, _mouseMoveY, 0f);
    }
}
