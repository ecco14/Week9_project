using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text myText;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinalScore()
    {
        myText.text = "You answered " + GameManager.instance.right + " correctly!" + " You answered " + GameManager.instance.wrong + " incorrectly.";
        
    }
}
