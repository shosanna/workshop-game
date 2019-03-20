using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour {
    public GameObject Player;

	// Use this for initialization
	void Start () {
        // Show as an alternastive method
        // Player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        // First show with wrong Z
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
	}
}
