using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokePickerAnimations : MonoBehaviour {
    Quaternion targetRot;

    public float turnSpeed = 6;

	// Update is called once per frame
	void Update () {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        targetRot = Quaternion.Euler(0.0f, 0.0f, rotationZ - 90);
        //SmoothRotate
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, turnSpeed * Time.deltaTime);
    }
}
