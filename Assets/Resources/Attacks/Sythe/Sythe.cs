using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sythe : MonoBehaviour {
    public int BaseDamage = 10;
    string DamageType = "Grass";
    HealthController HealthScript;
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 12000 * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * 600 * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Enemy")
        {
            HealthScript = collision.gameObject.GetComponent<HealthController>();
            HealthScript.health = HealthScript.health - BaseDamage;
        }
    }
}
