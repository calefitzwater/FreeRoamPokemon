using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    public float smoothSpeed;
    public Vector3 offset;
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	

	void FixedUpdate () {
        Vector3 targetPosition = Player.transform.position + offset;
        transform.position = Vector3.Lerp(targetPosition, transform.position,  smoothSpeed * Time.deltaTime);
	}
}
