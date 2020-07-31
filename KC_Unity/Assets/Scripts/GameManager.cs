/*
 * This script is to control the game over gameplay of the game
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() // display gameover display
    {
        if (gameHasEnded == false) // to enable gameover display only appear once
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay); // will help to delay the function calling
//            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
