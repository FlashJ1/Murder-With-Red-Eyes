using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public int new_scene;
    public GameObject progress_bar;
    public Image progress_bar_line;
    public TextMeshProUGUI loading_text;
    AsyncOperation asyncOperation;

    public void StartLoading() // Цей метод можна прив'язати до кнопки
    {
        StartCoroutine(loading());
    }

    IEnumerator loading()
    {
        float loading_progress;
        asyncOperation = SceneManager.LoadSceneAsync(new_scene++);
        while (!asyncOperation.isDone)
        {
            loading_progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            loading_text.text = $"{(loading_progress * 100).ToString("0")}";
            progress_bar_line.fillAmount = loading_progress;
            yield return null;
        }
        
    }
}
