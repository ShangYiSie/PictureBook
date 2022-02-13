using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScript : MonoBehaviour
{
    GameObject Text;
    bool isAdded;
    // Start is called before the first frame update
    void Start()
    {
        Text = gameObject.transform.GetChild(0).gameObject;
        isAdded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addScriptToText()
    {
        if(isAdded = false)
        {
            Text.AddComponent<TypewriterEffect>();
            isAdded = true;
        }
    }
    public void removeScript()
    {
        if(isAdded = true)
        {
            //GetComponent<TypewriterEffect>().OnFinish();
            GetComponent<TypewriterEffect>().myText.text = GetComponent<TypewriterEffect>().text;
            Destroy(Text.GetComponent<TypewriterEffect>());
            isAdded = false;
        }
    }
}
