using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameController : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreText;
    public GameObject player;
    public static GameController instance;
    
    void Start()
    {
        instance = this;
    }
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }


}
