using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool hasPlayerDied = false;
    public float respawnDelay = 2f;
    public ScoreScript scoreScript;
    public GameObject completeLevelText;

    public void EndGame() {
        if (hasPlayerDied == false) {
            hasPlayerDied = true;
            scoreScript.enabled = false;
            Invoke("RestartGame", respawnDelay);
        }
    }

    private void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        completeLevelText.SetActive(true);
    }
}

