using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text textComponent; 
    private int coinCount;
    private void Start()
    {
        coinCount = 0;
    }
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void AddCoinCount()
    {
        coinCount++;
        Debug.Log("CoinCount : " + coinCount);
        textComponent.text = "CoinCount : " + coinCount.ToString();
    }
}
