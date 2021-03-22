
using UnityEngine;
using UnityEngine.EventSystems;

public class FireController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AnimationHero animationHero;
    public PlayerController playerController;
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        
        animationHero.Fire(true);
        playerController.statee = true;
        

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        playerController.statee = false;
        animationHero.Fire(false);
        
    }
}
