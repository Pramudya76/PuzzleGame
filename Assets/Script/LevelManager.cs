using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private GameManager GM;
    public GameObject[] LevelButtons;
    public GameObject LevelUnlock;
    public GameObject LevelLock;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        LevelSystem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSystem() {
        LevelButtons[0] = Instantiate(LevelUnlock, LevelButtons[0].transform.position, Quaternion.identity);
        for(int a = 1; a < LevelButtons.Length; a++) {
            string prevKey = "Lv" + a;
            if(PlayerPrefs.HasKey(prevKey) && GM.CompletedLevel) {
                LevelButtons[a] = Instantiate(LevelUnlock, LevelButtons[a].transform.position, Quaternion.identity);
                Button btn = LevelButtons[a].GetComponentInChildren<Button>();
                btn.onClick.AddListener(() => {
                    SceneManager.LoadScene("Lv" + a);
                });
            }else {
                LevelButtons[a] = Instantiate(LevelLock, LevelButtons[a].transform.position, Quaternion.identity);
            }

        }
    }

}
