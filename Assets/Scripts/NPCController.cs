using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathUtil;

public class NPCController : MonoBehaviour
{

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Util.CanSeeObj(player, gameObject, 0.5f))
        {
            Debug.Log("I can see the player!");
        }

        Util.ObjSide(player, gameObject);

    }
}
