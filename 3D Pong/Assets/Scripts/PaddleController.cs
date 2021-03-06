using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    public KeyCode upKey, downKey, rightKey, leftKey;

    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector3.forward * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector3.back * speed;
        }
        if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }
}
