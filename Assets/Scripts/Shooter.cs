using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shooter : MonoBehaviour
{
  AudioSource audioClip;
  [SerializeField] TextMeshProUGUI scoretext;
  float destroyTime = 1.2f;
  GameManager manager;
  private void Awake()
  {
    manager=FindObjectOfType<GameManager>();
    audioClip=GetComponent<AudioSource>();
  }
  private void Start()
  {    
    Destroy(gameObject,destroyTime);
  }
  public void OnMouseDown()
  {
    manager.Audio.Play();
    Destroy(gameObject);
    manager.IncreaseScore();
    ShowWinText();
  }
  public void ShowWinText()
  {
    if (manager.Score >=20)
    {
      manager.CancelInvoke();
      manager.WinText.SetActive(true);
      manager.Restartbutton.SetActive(true);
      manager.Exitbutton.SetActive(true);
    }
  }

}
