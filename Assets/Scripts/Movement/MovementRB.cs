using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRB : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb_player;

    public float moveSpeed = 15f;

    public Vector2 movement;


    void Start()
    {
        rb_player = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); 
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    private void moveCharacter(Vector2 direction)
    {
        rb_player.AddForce(direction*moveSpeed);
    }
}
