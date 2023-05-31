using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class birdctroller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speedup;
    private bool levelstart;

    public GameObject tuberctroller;
    public GameObject masage;
    public Image image;

    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        levelstart = false;
        rb.gravityScale = 0;
        score = 0;
        scoreText.text = score.ToString();
        masage.GetComponent<SpriteRenderer>().enabled = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            sourceCtroller.instance.PlaythisSource("wing", 0.5f);
            if (levelstart == false)
            {

                rb.gravityScale = 2;
                levelstart = true;
                tuberctroller.GetComponent<tuberctroller>().enabletuber = true;
                masage.GetComponent<SpriteRenderer>().enabled = false;
                image.gameObject.SetActive(false);
            }

            moveup();
        }
    }
    
    public void moveup()
    {
        rb.velocity = Vector3.up * speedup;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sourceCtroller.instance.PlaythisSource("die", 0.5f);
        ReloadScene();
        score = 0;
        scoreText.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sourceCtroller.instance.PlaythisSource("point", 0.5f);
        score += 1;
        scoreText.text= score.ToString();
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
