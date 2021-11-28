using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private GroundCheck groundCheck;
    private PlayerParameters player;
    private SoundManager soundManager;
    private Animator animator;
    private Rigidbody2D rb2D;
    void Awake(){
        Physics2D.IgnoreLayerCollision(9,10);
        soundManager = GameObject.FindObjectOfType<SoundManager>();
        animator = GetComponent<Animator>();
        groundCheck = GetComponent<GroundCheck>();
        rb2D=GetComponent<Rigidbody2D>();
    }

    void Update(){
        if(GameStateScript.state == GameState.paused) return;

        Move();
        Jump();
    }

    private void Move(){
         rb2D.velocity = new Vector2(PlayerParameters.MoveSpeed, rb2D.velocity.y);
    }
    private void Jump(){
        if(!groundCheck.isGrounded) return;

        if(Input.GetKeyDown(KeyCode.Space) == true){
            soundManager.PlaySound(soundManager.jump); 
            animator.SetTrigger("didJump");
            rb2D.velocity = new Vector2(rb2D.velocity.x, PlayerParameters.JumpSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(groundCheck.isGrounded) return;

        if(other.CompareTag("Ground")){
            animator.SetTrigger("didLand");
        }
    }
}
