using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public PipeSpawnScript pipeSpawnScriptReference;

    [ContextMenu("Increase Score")]
    public void addScore(int score){
        playerScore = playerScore + score;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        pipeSpawnScriptReference.isRunning = false;
    }

}
