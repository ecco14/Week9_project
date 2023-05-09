using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBeginAgain : MonoBehaviour
{

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
        GameManager.instance.wrong = 0;
        GameManager.instance.right = 0;
    }
}
