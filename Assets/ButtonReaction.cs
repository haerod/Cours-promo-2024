using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonReaction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource source;
    public Texture2D cursorCustom;

    public void Start()
    {
        Cursor.SetCursor(cursorCustom, Vector2.zero, CursorMode.Auto);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        source.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
