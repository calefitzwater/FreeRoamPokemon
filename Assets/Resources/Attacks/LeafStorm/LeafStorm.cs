using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafStorm : MonoBehaviour {
    public int BaseDamage = 2;
    string DamageType = "Grass";
    HealthController HealthScript;
    // Use this for initialization
    void Start () {
        HealthScript = GameObject.Find("Player").GetComponent<HealthController>();
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 5500 * Time.deltaTime);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(Vector3.forward * 450 * Time.deltaTime);     
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Enemy")
        {
            HealthScript = collision.gameObject.GetComponentInParent<HealthController>();
            HealthScript.health = HealthScript.health - BaseDamage;
        }
    }
}
