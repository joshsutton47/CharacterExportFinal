using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameManager gm;
    public ClockScript clock;

    public void StartGame()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        gm.timeForTimer = clock.timeRemaining;

        SceneManager.LoadScene(1);
    }
}
