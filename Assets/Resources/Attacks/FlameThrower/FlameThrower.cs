using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour {

    public int BaseDamage = 1;
    string DamageType = "Fire";
    HealthController HealthScript;
    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 40000 * Time.deltaTime);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Enemy")
        {
            HealthScript = collision.gameObject.GetComponentInParent<HealthController>();
            HealthScript.health = HealthScript.health - BaseDamage;
        }
    }
}
