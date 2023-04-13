using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Results: " + GameManager.instance.coinsCtr + "/" + GameManager.instance.maxNumOfCoins + "C"; //Output results
    }
}
