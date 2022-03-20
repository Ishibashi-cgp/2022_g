using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// �V�[���J�ڏ����p�X�N���v�g
public class SceneChanger : MonoBehaviour
{
    // �܂��ŏ��Ɏ��s
    private void Start()
    {
        // ���̃X�N���v�g���A�^�b�`���ꂽGameObject���A�V�[���J�ڎ��ɔj������Ȃ��Ȃ�
        DontDestroyOnLoad(this);
    }


    // �V�[���ύX�p�̃��\�b�h  sceneName�őJ�ڐ�Scene�w��
    public void ChangeScene(string sceneName)
    {
        switch (sceneName)
        {
            case "GameScene":
                // 1.0f�b��A���\�b�h"ChangeToGameScene"�����s
                Invoke("ChangeToGameScene", 1.0f);
                break;
            default:
                // ���O��"SceneNameError"�ƕ\��
                Debug.Log("SceneNameError");
                break;
        }

    }


    // GameScene�ɑJ�ڂ���p�̃��\�b�h
    public void ChangeToGameScene()
    {
        // �V�[��"GameScene"�ɑJ��
        SceneManager.LoadScene("GameScene");
    }

}
