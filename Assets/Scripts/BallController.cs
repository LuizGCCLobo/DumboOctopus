using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    [SerializeField] bool isFlat = true;
    private Rigidbody rigid;

    [SerializeField] float speed;
    private float velocity;
    [SerializeField] bool grounded = false;
    
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        MovingBall();
    }

    void MovingBall()
    {
        Vector3 tilt = Input.acceleration;
    
        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        rigid.AddForce(tilt);

        if (Input.GetMouseButtonDown(0) && grounded)
        {
            rigid.AddForce(Vector3.up * speed);
            grounded = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag.Equals("Ground"))
            grounded = true;
    }
}
