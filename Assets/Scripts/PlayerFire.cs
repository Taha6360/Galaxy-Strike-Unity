using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    
    [SerializeField] GameObject[] bullets;
    bool isFiring;
    [SerializeField] RectTransform crosshair;
    [SerializeField] Transform targetpoint;
    [SerializeField]float targetposition;

    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        OnFiring();
        CursorFollow();
        spherFollow();
        lasserFiring();
    }
    void OnFire(InputValue value)
    
    {
        isFiring = value.isPressed;

    }
    private void OnFiring()
    {
        foreach (GameObject bullet in bullets)
        {
            var emmissionControl = bullet.GetComponent<ParticleSystem>().emission;
            emmissionControl.enabled = isFiring;
            
        }

    }
    
    void CursorFollow()
    {
        crosshair.position = Input.mousePosition;
    }
    void spherFollow()
    {
        Vector3 targetpointPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetposition);
        targetpoint.position = Camera.main.ScreenToWorldPoint(targetpointPosition);
    }
    void lasserFiring()
    {
        foreach (GameObject bullet in bullets)
        {
            Vector3 targetposition = targetpoint.transform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(targetposition);
            bullet.transform.rotation = targetRotation;


        }
    }
}
