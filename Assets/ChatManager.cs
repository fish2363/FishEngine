using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI currentText;
    private string[] chat = { "", "좌측 상단에는 별의 총 개수가 표시됩니다","좌클릭을 눌러 별을 발사해 보세요","가지고 있는 별의 개수에 따라 보이는 블록이 달라요", "저 나무 발판은 별만 통과할 수 있는 블럭이에요" , "점프와 동시에 별을 던지는 건 어떤가요?","별을 던지면서 지나가요!", "구멍 사이에 별을 던져두고 포탈로 가요", "머리위로 별을 던지면서 지나가죠?"};
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
