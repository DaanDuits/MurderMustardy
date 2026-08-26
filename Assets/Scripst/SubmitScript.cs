using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class SubmitScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string murderer;
    [SerializeField] private CircleScript circleScript;
    [SerializeField] private GameObject text;

    public void OnPointerClick(PointerEventData data)
    {
        bool winCondition = circleScript.CheckSuspectName(murderer);

        if (winCondition)
        {
            text.GetComponent<TextMeshProUGUI>().text = "You Win!";
        }
        else
        {
            text.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
    }
}