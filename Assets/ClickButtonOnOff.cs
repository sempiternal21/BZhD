using UnityEngine;
using UnityEngine.EventSystems;

public class ClickButtonOnOff : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData){
        Debug.Log("Click log");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starrt");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
