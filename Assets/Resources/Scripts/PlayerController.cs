using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Quaternion targetRot;
    Rigidbody2D rigid;
    SpriteController SpriteControllerScript;
    public GameObject spawnPoint;
    SpriteRenderer spriteRender;
    bool AttackOneDelaybool = false;
    bool AttackTwoDelaybool = false;
    bool AttackThreeDelaybool = false;
    

    public float turnSpeed = 6;
    public float forwardSpeed = 1500;
    public float backwardSpeed = 750;
    public float leftSpeed = 500;
    public float rightSpeed = 500;
    public string ChangeName;
    public string AttackOne;
    public string AttackTwo;
    public string AttackThree;
    public float AttackOneDelayTimer;
    public float AttackTwoDelayTimer;
    public float AttackThreeDelayTimer;
    public float AttackTwoDurationTimer;

    void Start () {
        //Get Instances
        rigid = GetComponent<Rigidbody2D>();
        SpriteControllerScript = gameObject.GetComponent<SpriteController>();
        spriteRender = GetComponent<SpriteRenderer>();
        SpriteControllerScript.ChangeCharacter(ChangeName, "Sythe", "LeafStorm", "LogBlock");
    }

	void FixedUpdate () {
        if (!PokePickerController.pokePicker)
        {
            //Rotate
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            targetRot = Quaternion.Euler(0.0f, 0.0f, rotationZ - 90);
            //SmoothRotate
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, turnSpeed * Time.deltaTime);

            //Move
            if (Input.GetKey("w"))
            {
                rigid.AddForce(transform.up * forwardSpeed * Time.deltaTime);
            }
            if (Input.GetKey("s"))
            {
                rigid.AddForce(transform.up * -backwardSpeed * Time.deltaTime);
            }
            if (Input.GetKey("a"))
            {
                rigid.AddForce(transform.right * -leftSpeed * Time.deltaTime);
            }
            if (Input.GetKey("d"))
            {
                rigid.AddForce(transform.right * rightSpeed * Time.deltaTime);
            }

            //Attacks
            if (Input.GetMouseButtonDown(0) && !AttackOneDelaybool)
            {
                StartCoroutine(StartAttackOneDelay());
                spawnPoint = GameObject.Find(spriteRender.sprite.name + "Collider/" + spriteRender.sprite.name + "SpawnPoint");
                Instantiate(Resources.Load<GameObject>("Attacks/" + AttackOne + "/" + AttackOne), spawnPoint.transform.position, spawnPoint.transform.rotation);
            }
            if (Input.GetMouseButton(1) && !AttackTwoDelaybool)
            {
                StartCoroutine(StartAttackTwoDelay());
                spawnPoint = GameObject.Find(spriteRender.sprite.name + "Collider/" + spriteRender.sprite.name + "SpawnPoint");
                Instantiate(Resources.Load<GameObject>("Attacks/" + AttackTwo + "/" + AttackTwo), spawnPoint.transform.position, spawnPoint.transform.rotation);
            }
            if (Input.GetMouseButtonDown(2) && !AttackThreeDelaybool)
            {
                StartCoroutine(StartAttackThreeDelay());
                spawnPoint = GameObject.Find(spriteRender.sprite.name + "Collider/" + spriteRender.sprite.name + "SpawnPoint");
                Instantiate(Resources.Load<GameObject>("Attacks/" + AttackThree + "/" + AttackThree), spawnPoint.transform.position, spawnPoint.transform.rotation);
            }
        }
    }

    //AttackDelays
    IEnumerator StartAttackOneDelay()
    {
        AttackOneDelaybool = true;
        yield return new WaitForSeconds(AttackOneDelayTimer);
        AttackOneDelaybool = false;
    }
    IEnumerator StartAttackTwoDelay()
    {
        yield return new WaitForSeconds(AttackTwoDurationTimer);
        AttackTwoDelaybool = true;
        yield return new WaitForSeconds(AttackTwoDelayTimer);
        AttackTwoDelaybool = false;
    }
    IEnumerator StartAttackThreeDelay()
    {
        AttackThreeDelaybool = true;
        yield return new WaitForSeconds(AttackThreeDelayTimer);
        AttackThreeDelaybool = false;
    }
}
