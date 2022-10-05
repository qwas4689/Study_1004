using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private RobotBody _robotBody;
    private Vector3 _moveDir;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _robotBody = GetComponentInChildren<RobotBody>();
    }

    // Update is called once per frame
    void Update()
    {
        _moveDir.x = Input.GetAxisRaw("Horizontal");
        _moveDir.z = Input.GetAxisRaw("Vertical");

        RobotMove();
    }

    private void RobotMove()
    {
        _rigidbody.MovePosition(transform.position + _moveDir.normalized * _robotBody.Speed);
        gameObject.transform.LookAt(transform.position + _moveDir.normalized * _robotBody.Speed);
    }
}
