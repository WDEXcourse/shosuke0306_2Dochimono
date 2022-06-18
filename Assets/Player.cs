using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Text ScoreText;
    public static int Score;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))//もしDキーが押されたら
        { 
            transform.position += new Vector3(0.3f, 0, 0);//プレイヤーのX座標を0.3ずつ変える
        }

        if (Input.GetKey(KeyCode.A))//もしAキーが押されたら
        {
            transform.position += new Vector3(-0.3f, 0, 0);//プレイヤーのX座標を-0.3ずつ変える
        }
        ScoreText.text = Score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Falls1")
        {
            Score -= 500;
        }

        if (collision.gameObject.tag == "Falls2")
        {
            Score += 100;
        }

        if (collision.gameObject.tag == "Falls3")
        {
            Score += 300;
        }
    }
}
