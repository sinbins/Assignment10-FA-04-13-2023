using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().color = Color.yellow;
        GetComponent<Text>().text = "Coins: " + GameManager.instance.coinsCtr + " / " + GameManager.instance.maxNumOfCoins +
            "\nLives: " + GameManager.instance.lives;
        
    }

}
