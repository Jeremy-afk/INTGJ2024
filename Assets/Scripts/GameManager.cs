using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject schoolCanvas;
    [SerializeField] private GameObject plantCanvas;
    [SerializeField] private GameObject knightCanvas;

    [SerializeField] private Animator animator;

    public void schoolButton()
    {
        StartCoroutine(TurnPage());
        schoolCanvas.SetActive(true);
        plantCanvas.SetActive(false);
        knightCanvas.SetActive(false);
    }

    public void PlantButton()
    {
        StartCoroutine(TurnPage());
        TurnPage();
        schoolCanvas.SetActive(false);
        plantCanvas.SetActive(true);
        knightCanvas.SetActive(false);
    }

    public void KnightButton()
    {
        StartCoroutine(TurnPage());
        TurnPage();
        schoolCanvas.SetActive(false);
        plantCanvas.SetActive(false);
        knightCanvas.SetActive(true);
    }
    
    IEnumerator TurnPage()
    {
        animator.Play("book");
        yield return new WaitForSeconds(1);
    }
    
}
