
using UnityEngine;
using UnityEngine.EventSystems;

public class FireController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AnimationHero animationHero;
    public Shoots shoots;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        
        animationHero.Fire(true);
        shoots.state = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
       
        animationHero.Fire(false);
        shoots.state = false;
    }
}
