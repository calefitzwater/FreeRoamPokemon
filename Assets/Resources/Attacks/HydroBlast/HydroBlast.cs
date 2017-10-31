using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydroBlast : MonoBehaviour {
    public int BaseDamage = 1;
    string DamageType = "Water";
    HealthController HealthScript;
    // Use this for initialization
    void Start () {
        int RandNum = Random.Range(0, 4);
        if (RandNum < 2)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (RandNum < 1)
        {
            gameObject.GetComponent<SpriteRenderer>().flipY = true;
        }
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
