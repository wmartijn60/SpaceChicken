using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevels : MonoBehaviour
{
    private float highScore;

    public Button[] levels;
	// Use this for initialization
    void Start()
    {
       highScore = PlayerPrefs.GetFloat("highScore", 0);
        for (int i = 0; i < levels.Length; i++)
        {
            //Changes the button's Normal color to the new color.
            levels[i].enabled = false;
        }
    }

    void FixedUpdate()
    {
        //moon
        if (highScore >= 0)
        {
            levels[0].enabled = true;

            ColorBlock colors = levels[0].colors;
            colors.normalColor = Color.magenta;
            colors.highlightedColor = new Color32(255, 0, 255 , 255);
            levels[0].colors = colors;

           
        }
        //mars
        if (highScore >= 400)
        {
            levels[1].enabled = true;

            ColorBlock colors = levels[1].colors;
            colors.normalColor = Color.red;
            colors.highlightedColor = new Color32(255, 0, 0, 255);
            levels[1].colors = colors;

        }
        //venus
        if (highScore >= 500)
        {
            levels[2].enabled = true;

            ColorBlock colors = levels[2].colors;
            colors.normalColor = Color.green;
            colors.highlightedColor = new Color32(0, 255, 0, 255);
            levels[2].colors = colors;

        }
        //jupiter
        if (highScore >= 600)
        {
            levels[3].enabled = true;

            ColorBlock colors = levels[3].colors;
            colors.normalColor = Color.blue;
            colors.highlightedColor = new Color32(0, 0, 255, 255);
            levels[3].colors = colors;

        }
    }
}
