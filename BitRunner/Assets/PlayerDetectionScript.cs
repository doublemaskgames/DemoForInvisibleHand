using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectionScript : MonoBehaviour
{
    private Animator parentAnimator;

    void Start(){
        parentAnimator = this.gameObject.GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            print("something");
            parentAnimator.SetTrigger("Attack");
        }
    }
}
