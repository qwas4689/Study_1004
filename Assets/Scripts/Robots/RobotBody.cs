using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBody : MonoBehaviour
{
    private int damage;
    private float _speed = 0.5f;

    public int Damage 
    { 
        get
        {
            if (damage == 0)
            {
                damage = Random.Range(10, 51);
            }
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    public float Speed { get; private set; }

    private void Awake()
    {
        Speed = _speed;
    }
}
