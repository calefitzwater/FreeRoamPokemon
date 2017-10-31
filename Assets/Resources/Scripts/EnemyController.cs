using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    GameObject target;
    Quaternion targetRot;
    Rigidbody2D rigid;

    public float forwardSpeed = 700;
    public float turnSpeed = 6;
    // Use this for initialization
    void Start () {
        target = GameObject.Find("Player");
        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!PokePickerController.pokePicker)
        {
            Vector3 difference = target.transform.position - transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            targetRot = Quaternion.Euler(0.0f, 0.0f, rotationZ - 90);
            //SmoothRotate
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, turnSpeed * Time.deltaTime);

            //Move
            rigid.AddForce(transform.up * forwardSpeed * Time.deltaTime);
        }
    }

    void Attack()
    {
        float randInt = Random.Range(0f, 1f);
        if(randInt < .5)
        {
            //Fire Attack One
        }
        else
        {
            //Fire Attack Two
        }
    }
}
