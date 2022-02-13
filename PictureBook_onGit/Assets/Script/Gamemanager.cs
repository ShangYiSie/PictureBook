using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Gamemanager : MonoBehaviour
{
    public GameObject Background;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    #region 切換場景
    public void GoToGame1()
    {
        SceneManager.LoadScene("Game1");
    }
    public void GoToGame2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void GoToGame3()
    {
        SceneManager.LoadScene("Game3");
    }
    public void GoToCountSheep()
    {
        SceneManager.LoadScene("CountSheepAni");
    }
    public void GoToScanScene_50Voice()
    {
        SceneManager.LoadScene("ScanScene_50Voice");
    }
    public void GoToScanScene_Book()
    {
        SceneManager.LoadScene("ScanScene_Book");
    }
    public void GoToBirdTree()
    {
        SceneManager.LoadScene("BirdTree");
    }
    public void GoStart()
    {
        SceneManager.LoadScene("Start");
    }
    #endregion
    #region UI控制
    public void SettingBtn()
    {
        Background.SetActive(true);
    }
    public void CancellBtn()
    {
        Background.SetActive(false);
    }
    #endregion
}
