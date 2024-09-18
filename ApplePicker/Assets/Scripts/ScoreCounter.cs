using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// enables ugui classes

public class ScoreCounter : MonoBehaviour
{
    internal static int score;
    [Header("Dynamic")]
    public int Score = 0;

    private Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = Score.ToString("#,0"); // says this 0 is a zero
    }
}
