using Cinemachine;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public CinemachineVirtualCamera chaptersCamera;
    public GameObject chaptersSelect;
    public GameObject mainMenuObject;
    public void PlayGame()
    {
        chaptersCamera.gameObject.SetActive(true);
        mainMenuObject.SetActive(false);
        chaptersSelect.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Гра закрилася!");
        Application.Quit();
    }
}
