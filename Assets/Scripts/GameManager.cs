using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
  [SerializeField] GameObject ShootPanel;
  public GameObject WinText;
  [SerializeField]TextMeshProUGUI scoreText;
  public AudioSource Audio;
  float PopRate = 2f;
  public int Score = 0;
  public GameObject Restartbutton;
  public GameObject Exitbutton;
  private void Start()
  {
    Audio =GetComponent<AudioSource>();
    Restartbutton.SetActive(false);
    Exitbutton.SetActive(false);
    WinText.SetActive(false);
    InvokeRepeating("GetShotPanel", 6.5f,PopRate);
  }
  public void GetShotPanel()
  {
    float RandomX = Random.Range(-7.6f, 7.6f);
    float RandomY = Random.Range(-3.7f, 3.7f);
    Vector2 SpotDir = new Vector2(RandomX, RandomY);
    Instantiate(ShootPanel, SpotDir, Quaternion.identity);

  }
  public void IncreaseScore()
  {
    Score++;
    scoreText.text = Score.ToString();
  }

  public void RestartGame() 
  {
    SceneManager.LoadScene("Game");
  }
  public void QuitGame()
  {
    Application.Quit();
  }

}
