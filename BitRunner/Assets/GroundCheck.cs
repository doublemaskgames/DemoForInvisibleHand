using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded = false;
    [SerializeField] private GameObject groundCheckObject =null;
    [SerializeField] private float groundCheckRadius=0;
    public LayerMask whatIsGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckObject.transform.position, groundCheckRadius, whatIsGround);        
    }
}
