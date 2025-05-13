using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public bool CompletedLevel;
    public int totalCorrect = 0;
    public int totalPiece;
    public GameObject WinGame;
    // Start is called before the first frame update
    void Start()
    {
        WinGame.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pieceCorrectPlace() {
        totalCorrect++;
        if(totalCorrect >= totalPiece) {
            WinGame.gameObject.SetActive(true);
            string SceneName = SceneManager.GetActiveScene().name;
            //CompletedLevel = true;
            PlayerPrefs.SetInt(SceneName, 1);
            PlayerPrefs.Save();
            Debug.Log("Puzzle Terselesaikan");
        }
    }

    public void pieceWrongPlace(int index) {
        Debug.Log("Posisi Salah pd slot ke-" + index);
    }

    public void ChangeScene(string nameScene) {
        SceneManager.LoadScene(nameScene);
    }

    public void ExitGame() {
        Application.Quit();
    }

    public void NextScene() {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }

    public void RetryLevel() {
        int nextScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nextScene);
    }


}
