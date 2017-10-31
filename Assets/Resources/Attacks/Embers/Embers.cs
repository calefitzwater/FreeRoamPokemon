using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embers : MonoBehaviour {

    public int BaseDamage = 50;
    string DamageType = "Fire";
    HealthController HealthScript;
    // Use this for initialization
    void Start()
    {
        HealthScript = GameObject.Find("Player").GetComponent<HealthController>();
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
