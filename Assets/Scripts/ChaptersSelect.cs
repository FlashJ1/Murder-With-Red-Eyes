using Cinemachine;
using UnityEngine;

public class ChaptersSelect : MonoBehaviour
{
    public GameObject loadingUI;
    public GameObject chaptersSelect;
    public GameObject mainMenuObject;
    public CinemachineVirtualCamera chaptersCamera;

    public void chapterButton()
    {
        loadingUI.SetActive(true);
        chaptersSelect.SetActive(false);
    }

    public void backButton()
    {
        chaptersSelect.SetActive(false);
        mainMenuObject.SetActive(true);
        chaptersCamera.gameObject.SetActive(false);
    }
    
}
