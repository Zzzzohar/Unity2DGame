using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    private Head head;
    public int digitCount = 4;

    private void Awake()
    {
        head = FindObjectOfType<Head>();
    }

    // Update is called once per frame
    void Update()
    {
        string score = head.GetScore().ToString();
        // 调整字符串让最终显示总共有6位，前面是一连串的0，
        // 比如 关数 1， 最后显示 000001.
        GetComponent<Text>().text = score.PadLeft(digitCount, '0');
    }
}
