using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shutter2 : MonoBehaviour
{
    private string chars = "123456789";
    public Text[] texts;
    private int[] nows = { 0, 0, 0, 0, 0, 0, 0 };

    public Dialog password;
    public Dialog password2;
    public GameObject open;
    public GameObject open2;

    public void CheckAnswer()
    {
        string answer = "";
        foreach (Text text in texts)
        {
            answer += text.text;
        }

        if (answer == "6712345")
        {
            open.SetActive(true);
            open2.SetActive(true);
            password.CloseDialog();
            password2.CloseDialog();
            //パスワード解除成功
        }
    }
    public void ChangeText(int n)
    {
        nows[n] += 1;

        if (nows[n] >= chars.Length)
        {
            nows[n] = 0;
        }

        texts[n].text = chars[nows[n]].ToString();
    }
}