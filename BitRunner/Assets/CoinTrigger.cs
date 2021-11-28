using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public GameEventChannel coinChannel;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            gainCoin();
        }    
    }

    public void gainCoin(){
        coinChannel.Raise();
    }
}
