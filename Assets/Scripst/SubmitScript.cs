using UnityEngine;
using UnityEngine.EventSystems;

public class SubmitScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string murderer;
    [SerializeField] private CircleScript circleScript;

    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log(circleScript.CheckSuspectName(murderer));
    }
}