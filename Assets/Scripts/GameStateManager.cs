using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    private static Button button = default;
    private static GameObject panel = default;
    private static Button playMusicButton = default;
    private static GameObject pauseMusicImage = default;
    private static bool isPlaying = true;
    private static Button playGameButton = default;
    private static Image playImage = default;
    private static Image pauseImage = default;
    private static bool isGameRunning = true;
  
    private void Awake() {
        button = GameObject.Find("PlayAgain").GetComponent<Button>();
        panel = GameObject.Find("GameOver");
        pauseMusicImage = GameObject.Find("PauseMusic");
        playMusicButton = GameObject.Find("PlayPauseMusic").GetComponent<Button>();
        pauseImage = GameObject.Find("PlayPause").GetComponent<Image>();
        playImage = GameObject.Find("PlayImage").GetComponent<Image>();
        playGameButton = GameObject.Find("PlayPause").GetComponent<Button>();
    }

    private void Start() {
        button.onClick.AddListener(PlayAgain);
        panel.SetActive(false);
        playImage.enabled = false;
        playMusicButton.onClick.AddListener(PlayPauseMusic);
        playGameButton.onClick.AddListener(PlayPauseGame);
    }

    private static void PlayAgain() {
        SceneManager.LoadScene("SampleScene",  LoadSceneMode.Single);
        panel.SetActive(false);
    }

    public static void GameOver() {
        panel.SetActive(true);
    }

    public static void PlayPauseMusic() {
        AudioListener.pause = isPlaying;
        pauseMusicImage.SetActive(!isPlaying);

        if(isPlaying) {
            isPlaying = false;
        } else {
            isPlaying = true;
        }
    }

    public static void PlayPauseGame() {
        if(isGameRunning) {
            Time.timeScale = 0;
            playImage.enabled = true;
            pauseImage.enabled = false;
            isGameRunning = false;
        } else {
            Time.timeScale = 1;
            playImage.enabled = false;
            pauseImage.enabled = true;
            isGameRunning = true;
        }
    }
}
