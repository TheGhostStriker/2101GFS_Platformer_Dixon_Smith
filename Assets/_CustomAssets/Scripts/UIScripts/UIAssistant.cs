using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAssistant : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    private Text messageText;

    private void Awake()
    {
        messageText = transform.Find("message").Find("messageText").GetComponent<Text>();
        Application.targetFrameRate = 3;
    }

    private void Start()
    {
        messageText.text = "Hello World";
        textWriter.AddWriter(messageText, "Hello World", 0.01f);
    }
}
