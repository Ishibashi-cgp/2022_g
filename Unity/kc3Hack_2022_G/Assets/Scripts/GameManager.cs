using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // �Q�[�������ǂ���
    bool inGaming = false;
    [SerializeField] SceneChanger sc;

    void Start()
    {
        DontDestroyOnLoad(this);    // �V�[���ύX����GameObject�������Ȃ��悤�ɂ���
    }


    // �Q�[���X�^�[�g
    public void toGaming() {
        inGaming = true;
        sc.ChangeScene("GameScene");
    }

}
