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
    public GameObject gameOver;
    public GameObject nextLevel;
    public GameObject player;
    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
public void UpdateScoreText(){
    scoreText.text = totalScore.ToString();
}
public void ShowGameOver(){
gameOver.SetActive(true);
}
public void NextLevelPainel(){
nextLevel.SetActive(true);
player.SetActive(false);
}
   public void RestartGame(string lvlName){
    SceneManager.LoadScene(lvlName);
}
}
