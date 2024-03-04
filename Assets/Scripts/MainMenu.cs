using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject creditsCanvas;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        mainMenuCanvas.SetActive(false);
        creditsCanvas.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        mainMenuCanvas.SetActive(true);
        creditsCanvas.SetActive(false);
    }
}
