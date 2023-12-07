
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay=1f;
    public GameObject completeLevelUI;
    public GameObject gameOverUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        gameHasEnded = true;
    }
    public void EndGame()
    {

        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
            
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
