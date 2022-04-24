using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallsDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("a");
        if (collision.gameObject.tag == "Takarabako")
        {
            Debug.Log("b");
            Destroy(gameObject, 0.1f);
        }
    }
}
