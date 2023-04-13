using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToNeWScene()
    {
        GameManager.instance.coinsCtr = 0;
        GameManager.instance.lives = 2;
        SceneManager.LoadScene("Title Screen");
    }
}
