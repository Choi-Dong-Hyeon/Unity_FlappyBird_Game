using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    [SerializeField] float jumpPower;
    Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOver");
        if (Score.scoretext > Score.bestScoretext)
        {
            Score.bestScoretext= Score.scoretext;
        }

    }
}
