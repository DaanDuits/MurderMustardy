using UnityEngine;
using UnityEngine.EventSystems;

public class BordScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Vector2 displayOffset;
    private Vector2 originalPos;

    private void Start()
    {
        originalPos = transform.position;
    }

    public void OnPointerEnter(PointerEventData data)
    {
        transform.position = originalPos + displayOffset;
    }

    public void OnPointerExit(PointerEventData data)
    {
        transform.position = originalPos;
    }
}