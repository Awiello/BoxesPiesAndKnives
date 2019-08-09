using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private GameObject playerObject;
    public GameObject deathEffect;
    private Vector3 playerPos;



    // Use this for initialization
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        Instantiate(deathEffect, playerPos, Quaternion.identity);
        print("You DIEDED!");
    }

    void Start(){
        playerObject = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update () {
        playerPos = playerObject.transform.position;
        print("Player Position:" + playerPos);


    }




}
