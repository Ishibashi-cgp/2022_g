using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// �Q�[���������p�X�N���v�g
public class InGameManager : MonoBehaviour
{

    // [SerializeField]��t���ĕϐ���錾����ƁApublic �̕ϐ��łȂ��Ă� Unity Editor���iinspector���j���璆�g���w�肷�邱�Ƃ��o����悤�ɂȂ�B
    [SerializeField] int score = 0;     // ���݂̃X�R�A
    [SerializeField] Text scoreText;    // �X�R�A��\������e�L�X�g


    // 0.02�b��1��i�f�t�H���g�l�j�̊Ԋu�Ŏ��s����
    void FixedUpdate()
    {
        // score�𕶎���^�ɂ��ăe�L�X�g�ɔ��f������
        scoreText.text = score.ToString();
    }

}
