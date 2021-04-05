using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void QuitGame() {
        Application.Quit();
    }
    public void OpenMainMenu() {
        SceneManager.LoadScene(0);
    }
}
