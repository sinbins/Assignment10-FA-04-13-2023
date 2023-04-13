using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToNewScene()
    {
        GameManager.instance.lives = 2;
        GameManager.instance.coinsCtr = 0;
        SceneManager.LoadScene("Title Screen");
        
    }
}