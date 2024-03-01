using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextModifier : MonoBehaviour
{
    [SerializeField] private TMP_Text textComponent;
    [SerializeField] private Button allerText;

    [TextArea]
    [SerializeField] private string present;
    [TextArea]
    [SerializeField] private string future;
    [TextArea]
    [SerializeField] private string past;


    private int when = 0;

    void Start()
    {
        textComponent.text = present;
    }

    public void ButtonClick()
    {
        when += 1;
        if (when % 3 == 0) 
        {
            textComponent.text = present;
        }

        else if (when % 3 == 1) 
        {
            textComponent.text = future;
        }

        else if (when % 3 == 2)
        {
            textComponent.text = past;
        }
    }

}
