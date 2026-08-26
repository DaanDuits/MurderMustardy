using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SuspectScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string subjectName;
    [SerializeField] private GameObject circleObject;

    public void OnPointerClick(PointerEventData data)
    {
        circleObject.transform.position = transform.position;
        circleObject.GetComponent<Image>().enabled = true;

        circleObject.GetComponent<CircleScript>().SetSuspectName(subjectName);
    }
}
