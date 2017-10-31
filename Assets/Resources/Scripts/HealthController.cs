using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour {
    public int health;
    public static bool dead;
    public Text HealthText;
	// Use this for initialization
	void Start () {
        dead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            health = 0;
            dead = true;
            Destroy(gameObject);
        }
        HealthText.text = "" + health;
	}
}
