using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class actionAsset : MonoBehaviour
{
    [SerializeField] private InputActionReference JoyStitckR;

    //�ŧi�n�έ��Ӱʧ@�a��
    [SerializeField] private InputActionAsset ActionAsset;

    private void OnEnable()
    {
        if (ActionAsset != null)
        {
            ActionAsset.Enable();
        }
    }
}
