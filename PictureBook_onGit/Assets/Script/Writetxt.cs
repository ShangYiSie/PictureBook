using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;
using System;

public class Writetxt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*string Filename = "Log.txt";
        string Filepath = Application.dataPath;*/
        /*WriteFile(path, Filename);
        addFile(path, Filename);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void file()
    {
        string Filename = "Log.txt";
        addFile(Application.persistentDataPath, Filename);//追加字元
        //addFile(Application.dataPath, Filename);//追加字元
    }
    /*public void startBtn()
    {
        string Filename = "Log.txt";
        startGame(Application.persistentDataPath, Filename);
        startGame(Application.dataPath, Filename);
    }*/
    /*void WriteFile(string filePath, string fileName)
    {
        FileStream fs = new FileStream(filePath + "//" + fileName, FileMode.Create);   //開啟一個寫入流
        string str = "寫入檔案";
        byte[] bytes = Encoding.UTF8.GetBytes(str);
        fs.Write(bytes, 0, bytes.Length);
        fs.Flush();     //流會緩衝，此行程式碼指示流不要緩衝資料，立即寫入到檔案。
        /*fs.Close();     //關閉流並釋放所有資源，同時將緩衝區的沒有寫入的資料，寫入然後再關閉。
        fs.Dispose();   //釋放流所佔用的資源，Dispose()會呼叫Close(),Close()會呼叫Flush();    也會寫入緩衝區內的資料。*/
    //}
    void addFile(string path, string fileName)
    {
        //寫入流，追加文字
        FileStream fs = new FileStream(path + "//" + fileName, FileMode.Append, FileAccess.Write);  //追加流，許可權設定為可寫
        string str1 = DateTime.Now.ToString();
        string str2 = gameObject.name.ToString();
        byte[] bytes = Encoding.UTF8.GetBytes(str1 + "掃描到" + str2 + "\n");
        fs.Write(bytes, 0, bytes.Length);
        fs.Flush();     //流會緩衝，此行程式碼指示流不要緩衝資料，立即寫入到檔案。
        fs.Close();     //關閉流並釋放所有資源，同時將緩衝區的沒有寫入的資料，寫入然後再關閉。
        fs.Dispose();   //釋放流所佔用的資源，Dispose()會呼叫Close(),Close()會呼叫Flush();    也會寫入緩衝區內的資料。
    }
    /*void startGame(string path, string fileName)
    {
        FileStream fs = new FileStream(path + "//" + fileName, FileMode.Append, FileAccess.Write);  //追加流，許可權設定為可寫
        string str1 = DateTime.Now.ToString();
        byte[] bytes = Encoding.UTF8.GetBytes(str1 + "開始使用程式" + "\n");
        fs.Write(bytes, 0, bytes.Length);
        fs.Flush();     //流會緩衝，此行程式碼指示流不要緩衝資料，立即寫入到檔案。
        fs.Close();     //關閉流並釋放所有資源，同時將緩衝區的沒有寫入的資料，寫入然後再關閉。
        fs.Dispose();   //釋放流所佔用的資源，Dispose()會呼叫Close(),Close()會呼叫Flush();    也會寫入緩衝區內的資料。
    }*/
}
