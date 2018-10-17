using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallParentController : MonoBehaviour {

    [SerializeField] GameObject ballChild;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = ballChild.transform.position;
	}
}
