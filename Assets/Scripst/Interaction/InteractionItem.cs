using UnityEngine;
using UnityEngine.EventSystems;

public class InteractionItem : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click");
    }    
}
