/* This is to configure dice enginer */
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Text score;
    public Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void RollDice ()
    {
        int diceScore = Random.Range(1, 99);
        
        score.text = diceScore.ToString();

        // update high score if random score is higher than current high score
        if (diceScore > PlayerPrefs.GetInt("HighScore", 0)) {
            PlayerPrefs.SetInt("HighScore", diceScore);
            highScore.text = diceScore.ToString();
        } 
    }

    public void Reset ()
    {
        PlayerPrefs.DeleteAll(); // delete all preferences to reset
        highScore.text = "0";
    }
}
