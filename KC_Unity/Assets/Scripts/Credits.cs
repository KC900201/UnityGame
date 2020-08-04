/*
 * This script is to enable player quit game
 */
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

}
