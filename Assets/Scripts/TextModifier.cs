using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class TextModifier : MonoBehaviour
{
    [SerializeField] private TMP_Text textComponent;
    [SerializeField] private Button allerText;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private AudioSource audio;


    [SerializeField] private List<GameObject> sprites;

    [TextArea]
    [Header("Time")]
    [SerializeField] private string presentT;
    [TextArea]
    [SerializeField] private string futureT;
    [TextArea]
    [SerializeField] private string pastT;

    [TextArea]
    [Header("Period")]
    [SerializeField] private string presentP;
    [TextArea]
    [SerializeField] private string futureP;
    [TextArea]
    [SerializeField] private string pastP;


    private int whenT = 0;
    private int whenP = 0;

    void Start()
    {
        textComponent.text = presentT + presentP;
    }

    public void ButtonTClick()
    {
        whenT += 1;
        UpdateSentence();
        PlayParticule();
    }

    public void ButtonPClick()
    {
        whenP += 1;
        UpdateSentence();
        PlayParticule();

    }

    void UpdateSentence()
    {
        if (whenT % 3 == 0)
        {
            if (whenP % 3 == 0)
            {
                textComponent.text = presentT + presentP;
                SpriteToActivate(0);
            }

            else if (whenP % 3 == 1)
            {
                textComponent.text = presentT + futureP;
                SpriteToActivate(3);
            }

            else if (whenP % 3 == 2)
            {
                textComponent.text = presentT + pastP;
                SpriteToActivate(6);
            }
        }

        else if (whenT % 3 == 1)
        {
            if (whenP % 3 == 0)
            {
                textComponent.text = futureT + presentP;
                SpriteToActivate(1);
            }

            else if (whenP % 3 == 1)
            {
                textComponent.text = futureT + futureP;
                SpriteToActivate(4);
            }

            else if (whenP % 3 == 2)
            {
                textComponent.text = futureT + pastP;
                SpriteToActivate(7);
            }
        }

        else if (whenT % 3 == 2)
        {
            if (whenP % 3 == 0)
            {
                textComponent.text = pastT + presentP;
                SpriteToActivate(2);
            }

            else if (whenP % 3 == 1)
            {
                textComponent.text = pastT + futureP;
                SpriteToActivate(5);
            }

            else if (whenP % 3 == 2)
            {
                textComponent.text = pastT + pastP;
                SpriteToActivate(8);
            }
        }


    }

    void PlayParticule()
    {
        ps.Play();
        audio.Play();
    }

    void SpriteToActivate(int index)
    {
        for(int i = 0; i < sprites.Count;i++)
        {
            if(i== index)
            {
                sprites[i].SetActive(true);
            }
            else
            {
                sprites[i].SetActive(false);
            }
        }
    }

}
