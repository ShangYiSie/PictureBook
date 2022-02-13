using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Cam : MonoBehaviour
{
    void Start()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);

    }
    void Update()
    {
        //自動對焦  
        //if (m_bIsFocus)  
#if UNITY_EDITOR
        if (Input.GetMouseButtonUp(0))
#elif UNITY_ANDROID || UNITY_IPHONE
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)  
#endif
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}
