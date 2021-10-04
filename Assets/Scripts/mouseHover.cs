using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class mouseHover : MonoBehaviour,  IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Picture;

    void start()
    {
        Picture.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Do something
        Picture.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Do something
        Picture.SetActive(false);
    }


}
