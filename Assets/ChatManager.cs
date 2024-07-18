using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI currentText;
    private string[] chat = { "", "���� ��ܿ��� ���� �� ������ ǥ�õ˴ϴ�","��Ŭ���� ���� ���� �߻��� ������","������ �ִ� ���� ������ ���� ���̴� ����� �޶��", "�� ���� ������ ���� ����� �� �ִ� ���̿���" , "������ ���ÿ� ���� ������ �� �����?","���� �����鼭 ��������!", "���� ���̿� ���� �����ΰ� ��Ż�� ����", "�Ӹ����� ���� �����鼭 ��������?"};
    private int currentTextNum;
    public void Text(int textNum , float count)
    {
        if (count != 0)
            StartCoroutine(Wait(count , textNum));
        currentText.text = chat[textNum];
        currentTextNum = textNum;
    }
    private IEnumerator Wait(float wait, float textNum)
    {
        yield return new WaitForSecondsRealtime(wait);
        if(currentTextNum == textNum)
            currentText.text = "";
    }
}
