using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHomeIfBelowHeight : MonoBehaviour {

    public float verticalThreshold;
    public Vector3 homePosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < verticalThreshold)
            transform.position = homePosition;
    }
}
