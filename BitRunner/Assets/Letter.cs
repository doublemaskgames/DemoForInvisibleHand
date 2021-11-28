using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Letter : SpawnedObject
{
    public GameEventChannel gotHit;
    public GameEventChannel bossDamage;
    public StringVariable letterString;
    char[] alphabet;
    TextMeshProUGUI letter;
    KeyCode inputRequired;

    private void Start() {
        Invoke("Explode",2);
        letter = GetComponent<TextMeshProUGUI>();
        alphabet = letterString.line.ToCharArray();    
        GenerateLetter();
    }

    private void OnDisable() {
        Destroy(this.gameObject);    
    }

    void GenerateLetter(){
        int RandomNumber = Random.Range(0, alphabet.Length);
        string buttonPress = alphabet[RandomNumber].ToString().ToUpper();
        letter.SetText(alphabet[RandomNumber].ToString());
        inputRequired = (KeyCode) System.Enum.Parse(typeof(KeyCode), buttonPress) ;
    }

    new void Update(){
        base.Update();
        if(Input.GetKeyDown(inputRequired)){
            bossDamage.Raise();
            Destroy(this.gameObject);
        }
    }

    void Explode(){
        gotHit.Raise();
        Destroy(this.gameObject);
    }
}
