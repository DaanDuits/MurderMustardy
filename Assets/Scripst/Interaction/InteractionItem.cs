using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer), typeof(BoxCollider2D))]
public class InteractionItem : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TMP_Text dialogue;
    [SerializeField][TextArea(3, 10)] private string dialogueText;
    [SerializeField] private Sprite hoverSprite;
    private Sprite _defaultSprite;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _defaultSprite = _spriteRenderer.sprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _spriteRenderer.sprite = hoverSprite;
    }

    public void OnPointerExit(PointerEventData eventData) 
    {
        _spriteRenderer.sprite = _defaultSprite;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        dialogue.text = dialogueText;
    }    
}
