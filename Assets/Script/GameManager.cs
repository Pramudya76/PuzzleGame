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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pieceCorrectPlace() {
        totalCorrect++;
        if(totalCorrect >= totalPiece) {
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


}
