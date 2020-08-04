/*This is to trigger new level or end level*/
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        Debug.Log("Level Won");
    }
}
