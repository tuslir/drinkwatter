using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTransform : MonoBehaviour
{
    public float speed;
    public float y;
    
    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), y));
    }

    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
