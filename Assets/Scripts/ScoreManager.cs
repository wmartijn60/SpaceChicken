using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
    public Text scoreText;
    public Text highScoreText;
    public Transform player;
    public Rigidbody2D prefab;
    private bool oneTime = true;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

	// Use this for initialization
	void Start () 
	{
	    if(PlayerPrefs.HasKey("highScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("highScore");
        }
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if(scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("highScore", highScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);


	    if (Input.GetKeyDown("p"))
	    {
	        PlayerPrefs.DeleteAll();
	    }

	    //if (scoreCount >= 300)
	    //{
	        //if (oneTime == true)
	        //{
	         //   Vector2 a = new  Vector2(player.position.x + 20, player.position.y);
	        //    Rigidbody2D b = Instantiate(prefab, a, Quaternion.identity);
	         //   oneTime = false;
	      //  }
            
       // }
	}

    public void AddScore(int pointsScored)
    {
        scoreCount += pointsScored;
    }
}
