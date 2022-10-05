using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRobot : SelectRobot
{
    private bool isHead = false;

    private Vector3 _headPosition;
    private Vector3 _bodyToHead;

    private RobotMovement robotMovement;

    void Start()
    {
        _bodyToHead = new Vector3(0, 4f, 0);
    }

    void Update()
    {
        InputRobotNumber();
    }

    public override void InputRobotNumber()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            robotMovement = GetComponentInParent<RobotMovement>();
            robotMovement.enabled = true;

            _headPosition = gameObject.transform.position + _bodyToHead;
            Head.transform.SetParent(gameObject.transform);

            Head.transform.position = _headPosition;
            isHead = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            robotMovement = GetComponentInParent<RobotMovement>();
            robotMovement.enabled = false;
            isHead = false;
        }
    }
}
