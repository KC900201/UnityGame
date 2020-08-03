/* 
 * This script is enable next level loading 
 * whenever current level is completed successfully
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
  public void LoadNextLevel()
   {
        // Load next level by referring to build index of next scene
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
