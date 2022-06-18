using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    private float TimeLimit;
    public Text TimerText;

    private float num1;

    // Start is called before the first frame update
    void Start()
    {
        TimeLimit = 61;
    }

    // Update is called once per frame
    void Update()
    {
        num1 = Mathf.Floor(TimeLimit);
        TimerText.text = "Time:" + num1.ToString();

        if (TimeLimit >= 0)
        {
            TimeLimit -= Time.deltaTime;
        }

        if (TimeLimit <= 0)
        {
            SceneManager.LoadScene("Finish");
        }
        
    }
}
