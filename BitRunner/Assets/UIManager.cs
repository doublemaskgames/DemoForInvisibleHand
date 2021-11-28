using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    void Update(){
        coinText.SetText("Coins: " + PlayerParameters.coins.ToString());
        healthText.SetText("Health: " + PlayerParameters.health.ToString());
    }
}
