using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    // �V�[���ύX�p�̃��\�b�h  sceneName�őJ�ڐ�Scene�w��
    public void ChangeScene(string sceneName)
    {
        switch (sceneName)
        {
            case "GameScene":
                Invoke("ChangeToGameScene", 1.0f);
                break;
            default:
                Debug.Log("SceneNameError");
                break;
        }

    }

    // GameScene�ɑJ�ڂ���p�̃��\�b�h
    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
