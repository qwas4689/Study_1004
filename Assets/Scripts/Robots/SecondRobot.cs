using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRobot : SelectRobot
{
    private bool isHead = false;

    private Vector3 _headPosition;
    private RobotMovement robotMovement;

    void Start()
    {
        
    }

    void Update()
    {
        InputRobotNumber();
        
    }

    public override void InputRobotNumber()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            robotMovement = GetComponentInParent<RobotMovement>();
            robotMovement.enabled = true;

            _headPosition = gameObject.transform.position + new Vector3(0, 4f, 0);
            Head.transform.SetParent(gameObject.transform);

            isHead = true;
            Head.transform.position = _headPosition;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            robotMovement = GetComponentInParent<RobotMovement>();
            robotMovement.enabled = false;
            isHead = false;
        }
    }
}
