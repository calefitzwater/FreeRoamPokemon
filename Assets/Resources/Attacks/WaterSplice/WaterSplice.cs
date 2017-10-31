using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSplice : MonoBehaviour {

    public int BaseDamage = 10;
    string DamageType = "Water";
    HealthController HealthScript;
    // Use this for initialization
    void Start()
    {
        int RandNum = Random.Range(0, 4);
        if(RandNum < 2)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (RandNum < 1)
        {
            gameObject.GetComponent<SpriteRenderer>().flipY = true;
        }
        HealthScript = GameObject.Find("Player").GetComponent<HealthController>();
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 40000 * Time.deltaTime);
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
