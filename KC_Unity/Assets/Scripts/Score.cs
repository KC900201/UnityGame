/*This script is to use text display in Unity to show the score in our gameplay*/
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");
//        Debug.Log(score.text);
    }
}
