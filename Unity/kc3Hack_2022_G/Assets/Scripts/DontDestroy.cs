using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);    // �V�[���ύX����GameObject�������Ȃ��悤�ɂ���
    }
}
