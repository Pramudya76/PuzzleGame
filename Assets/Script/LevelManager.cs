using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private GameManager GM;
    public GameObject[] LevelButtons;
    public GameObject LevelUnlock;
    public GameObject LevelLock;
    public Transform ParentLocation;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        PlayerPrefs.SetInt("Lv1", 1);
        PlayerPrefs.Save();
        LevelSystem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSystem() {
        LevelButtons[0] = Instantiate(LevelUnlock, LevelButtons[0].transform.position, Quaternion.identity, ParentLocation);
        Destroy(LevelButtons[0]);
        for(int a = 1; a < LevelButtons.Length; a++) {
            int index = a + 1;
            string prevKey = "Lv" + a;
            Destroy(LevelButtons[a]);
            if(PlayerPrefs.HasKey(prevKey)) {
                LevelButtons[a] = Instantiate(LevelUnlock, LevelButtons[a].transform.position, Quaternion.identity, ParentLocation);
                Button btn = LevelButtons[a].GetComponentInChildren<Button>();
                TextMeshProUGUI buttonText = LevelButtons[a].GetComponentInChildren<TextMeshProUGUI>();
                buttonText.text = "Lv " + index;
                btn.onClick.AddListener(() => {
                    SceneManager.LoadScene("Lv" + index);
                    
                });
            }else {
                LevelButtons[a] = Instantiate(LevelLock, LevelButtons[a].transform.position, Quaternion.identity, ParentLocation);
            }

        }
    }

}
