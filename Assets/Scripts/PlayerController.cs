using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D _body;
    private Animator _anim;
    // Show in editor - change is not permanent!
    public float Speed;
    public float JumpSpeed;

	// Use this for initialization
	void Start () {
        _body = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();

        Speed = 2f;
        JumpSpeed = 5f;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        // First use GetAxis, then switch to Raw
        var axis = Input.GetAxisRaw("Horizontal");
        //Debug.Log(axis);


        Vector2 force = new Vector2(axis * Speed, _body.velocity.y);
        _body.velocity = force;

        if(Input.GetKeyDown("space"))
        {
            // First without speed
            _body.AddForce(Vector2.up * JumpSpeed, ForceMode2D.Impulse);
            _anim.SetTrigger("Jump");
        }
    }
}
