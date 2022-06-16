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
        textWriter.AddWriter(messageText, "The Lodge You're name is Hugo Moreno. You have just arrived at your late brothers, Eamonn, mountain lodge. Upon arrival, you have found the house delapidated and in disrepair. Brave the dangers of the broke - down house and salvage any belongings that you can. Beware of hidden dangers. Beware the tricks of the mind. Beware....", 0.01f, true);
    }
}
