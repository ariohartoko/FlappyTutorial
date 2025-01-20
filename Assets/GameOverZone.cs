using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverZone : MonoBehaviour
{
    public Utilities Util;
    // Start is called before the first frame update
    void Start()
    {
        Util = GameObject.FindGameObjectWithTag("Utility Burung").GetComponent<Utilities>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
            Util.GameOver();
    }
}
