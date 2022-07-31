using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public Text highScoreText;
    //public static int Score;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "Score:" + Player.highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
