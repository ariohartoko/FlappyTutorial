using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBird : MonoBehaviour
{
    public Rigidbody2D RigidBird;
    public float FlapPower;
    public Utilities Util;
    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        Util = GameObject.FindGameObjectWithTag("Utility Burung").GetComponent<Utilities>();
    }

    // Update is called once per frame
    void OnJump()
    {
        if(isAlive)
            RigidBird.velocity = Vector2.up * FlapPower;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        Util.GameOver();
    }
}
