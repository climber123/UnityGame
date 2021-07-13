using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class asd : MonoBehaviour {

    public float upF;                   //Upward force of the "flap".
    private Rigidbody2D rbd;
    public bool isDied = false;
    private float time1;
    private int score = 0;
    public Text score_text;
    private int best_scores;
    public Button gameOver;
    

    // Use this for initialization
    void Start () {
        
        rbd = GetComponent<Rigidbody2D>();
        time1 = Time.time;
        score_text.text = "Score: " + score.ToString();
        best_scores = PlayerPrefs.GetInt("Scores");
        gameOver.onClick.AddListener(ReturnToMenu);
    }
	
	// Update is called once per frame
	void Update () {
        if (isDied == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                //...zero out the birds current y velocity before...
                rbd.velocity = Vector2.zero;
                //	new Vector2(rb2d.velocity.x, 0);
                //..giving the bird some upward force.
                rbd.AddForce(new Vector2(0, 1.5f * upF));
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                //...zero out the birds current y velocity before...
                //rbd.velocity = Vector2.zero;
                //	new Vector2(rb2d.velocity.x, 0);
                //..giving the bird some upward force.
                rbd.AddForce(new Vector2(0, -upF));
            }
            if ((Time.time - time1) > 0.5f)
            {
                time1 = Time.time;
                score++;
                score_text.text = "Score: " + score.ToString();
                
            }
            
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "IsDiedCollider")
        {
                rbd.velocity = Vector2.zero;
                Died();
        }
    }
    public void Died()
    {
        
        isDied = true;
        if (score > best_scores)
        {
            PlayerPrefs.SetInt("Scores", score);
        }


        gameOver.gameObject.SetActive(true);
    }

    private void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
