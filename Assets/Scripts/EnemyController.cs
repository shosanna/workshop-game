using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    private Rigidbody2D _body;
    private float _direction = 1f;

	// Use this for initialization
	void Start () {
        _body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        _body.velocity = new Vector2(_direction, 0);
	}


    private void ChangeDirection()
    {
        _direction = - _direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            //Debug.Log(collision.gameObject.name);
            ChangeDirection();
        }
    }
}
