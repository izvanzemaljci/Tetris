using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    private static Button button = default;
    public static GameObject panel = default;

    private void Awake() {
        button = GameObject.Find("PlayAgain").GetComponent<Button>();
        panel = GameObject.Find("GameOver");
    }

    private void Start() {
        button.onClick.AddListener(PlayAgain);
        panel.SetActive(false);
    }

    private static void PlayAgain() {
        SceneManager.LoadScene("SampleScene",  LoadSceneMode.Single);
        panel.SetActive(false);
    }

    public static void GameOver() {
        panel.SetActive(true);
    }
}
