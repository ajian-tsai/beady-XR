using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class actionAsset : MonoBehaviour
{
    [SerializeField] private InputActionReference JoyStitckR;

    //宣告要用哪個動作地圖
    [SerializeField] private InputActionAsset ActionAsset;

    private void OnEnable()
    {
        if (ActionAsset != null)
        {
            ActionAsset.Enable();
        }
    }
}
