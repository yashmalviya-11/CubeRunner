using UnityEngine;
using UnityEngine.SceneManagement;

public class gamecontroler : MonoBehaviour
{
    public GameObject gameoverpanel;
    public GameObject taptostart;
    public GameObject scoretext;

    void Start()
    {
        Time.timeScale = 1f;
        gameoverpanel.SetActive(false);
        taptostart.SetActive(true);
        scoretext.SetActive(false);
        PauseGame();
    }

    void Update()   // ✅ Corrected capitalization
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startgame();
        }
    }

    public void GameOver()
    {
        gameoverpanel.SetActive(true);
        scoretext.SetActive(false);
        Time.timeScale = 0f;
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quitgame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void startgame()
    {
        taptostart.SetActive(false);
        scoretext.SetActive(true);
        Time.timeScale = 1f;
    }
}
