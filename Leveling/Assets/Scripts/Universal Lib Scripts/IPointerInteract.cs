using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IPointerInteract: IEventSystemHandler
{
    void OnPointerEnter(PointerEventData eventData);
    void OnPointerExit(PointerEventData eventData);
}
