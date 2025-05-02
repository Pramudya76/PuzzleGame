using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalCorrect = 0;
    public int totalPiece = 20;
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
            Debug.Log("Puzzle Terselesaikan");
        }
    }

    public void pieceWrongPlace(int index) {
        Debug.Log("Posisi Salah pd slot ke-" + index);
    }


}
