using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countsheep : MonoBehaviour
{
    public GameObject Bg1;
    public GameObject Bg2;
    public AudioSource count;
    // Start is called before the first frame update
    void Start()
    {
        /*Bg1 = GameObject.Find("Bg1");
        Bg2 = GameObject.Find("Bg2");*/
        count = GameObject.Find("count1_10").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void switchImg()
    {
        Bg1.SetActive(false);
        Bg2.SetActive(true);
    }
    public void countplay()
    {
        count.Play();
    }
    public void Back()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void repeatBtn()
    {
        Bg1.SetActive(true);
        Bg2.SetActive(false);
    }
}
