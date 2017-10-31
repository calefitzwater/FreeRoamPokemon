using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaToss : MonoBehaviour {

    public int BaseDamage = 1;
    string DamageType = "Fire";
    HealthController HealthScript;
    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 1500 * Time.deltaTime);
    }

    // Update is called once per frame
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Enemy")
        {
            HealthScript = collision.gameObject.GetComponent<HealthController>();
            HealthScript.health = HealthScript.health - BaseDamage;
        }
    }
}
