using UnityEngine;

using UnityEngine.EventSystems;              

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{  //intefraces to recognize gestures

	public Canvas canvas;                  
	RectTransform rectTransform;     

	void Start()
	{
		rectTransform = GetComponent<RectTransform>();
	}

	public void OnPointerDown(PointerEventData e)
	{
		Debug.Log("Izdarits kreisais klikskis uz velkama objekta");
	}

	public void OnBeginDrag(PointerEventData e)
	{
		Debug.Log("uzsakta vilksana");
	}
	public void OnDrag(PointerEventData e)
	{
		Debug.Log("Notiek objekta vilksana!");
		rectTransform.anchoredPosition += e.delta / canvas.scaleFactor;
	}

	public void OnEndDrag(PointerEventData e)
	{
		Debug.Log("Veikta objekta vilksana...");
	}
}