using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iceberg : MonoBehaviour {
    public float timeLeft = 8.0f;
    // Use this for initialization
    void Start () {
        transform.localScale += new Vector3(Random.Range(-.3f, .3f), Random.Range(-.3f, .3f), 0);
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            transform.localScale += new Vector3(-.01f, -.01f, 0f);
        }
    }
}
