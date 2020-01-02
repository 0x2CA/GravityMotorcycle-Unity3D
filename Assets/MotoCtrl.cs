using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoCtrl : MonoBehaviour {

    [SerializeField]
    private WheelJoint2D right;

    [SerializeField]
    private WheelJoint2D left;

    [SerializeField]
    private float speed = 1500;

    [SerializeField]
    private float rotate = 2000;

    JointMotor2D motor;

    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start () {
        motor.maxMotorTorque = 10000;
        rigidbody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update () {
        motor.motorSpeed = -this.speed * Input.GetAxis ("Horizontal");
        right.motor = motor;
        left.motor = motor;
        rigidbody.AddTorque (this.rotate * Input.GetAxis ("Vertical") * Time.deltaTime);
    }
}