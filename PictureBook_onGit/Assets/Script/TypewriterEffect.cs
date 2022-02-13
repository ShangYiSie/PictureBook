using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{

    public float charsPerSecond = 0.2f;//打字間隔的時間
    public string words;//儲存需要顯示的文字
    private bool isActive = false;
    private float timer;//計時器
    public TextMesh myText;
    public string text;
    private int currentPos = 0;

    public void Start()
    {
        timer = 0f;
        isActive = true;
        charsPerSecond = Mathf.Max(0.2f, charsPerSecond);
        myText = GetComponent<TextMesh>();
        text = myText.text;
        //獲取Text的文字資訊，儲存到words中，然後動態更新文字
        words = myText.text;
        //顯示的內容，實現打字機的效果
        myText.text = "";
    }

    public void Update()
    {
        OnStartWriter();
    }

    public void StartEffect()
    {
        isActive = true;
    }

    //執行打字任務
    public void OnStartWriter()
    {
        if (isActive)
        {
            timer += Time.deltaTime;
            if (timer >= charsPerSecond)
            {
                timer = 0f;
                currentPos++;
                //重新整理文字顯示內容
                myText.text = words.Substring(0, currentPos);
                if (currentPos >= words.Length)
                {
                    OnFinish();
                }
            }
        }
    }

    //結束打字，初始化資料
    private void OnFinish()
    {
        isActive = false;
        timer = 0;
        currentPos = 0;
        myText.text = words;
    }
}