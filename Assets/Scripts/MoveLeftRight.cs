using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Movement Speed")]
    public float movementSpeed;

    [Header("Distance of platform")]
    public float toLeft;
    public float toRight;

    [Header("Debug bool")]
    public bool isLeft;

    Vector3 startPos;
    Vector3 leftPos;
    Vector3 rightPos;

    Rigidbody rb;

    void Start()
    {
        startPos = this.transform.position;
        leftPos = new Vector3((this.transform.position.x - toLeft), this.transform.position.y, this.transform.position.z);
        rightPos = new Vector3((this.transform.position.x + toRight), this.transform.position.y, this.transform.position.z);

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= (leftPos).x) isLeft = true;
        if (transform.position.x >= (rightPos).x) isLeft = false;

        if (isLeft == false)
            rb.MovePosition(transform.position + (-transform.right * movementSpeed));
        else
            rb.MovePosition(transform.position + (transform.right * movementSpeed));
    }
}
