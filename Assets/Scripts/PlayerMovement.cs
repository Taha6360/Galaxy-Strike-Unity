using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float xPos;
    [SerializeField] float yPos;

    [SerializeField] float rollValue;
    [SerializeField] float rollSpeed;
    Vector2 movement;
     void Update()
    {
        PMovement();
        Protation();
    }

    private void PMovement()
    {
        float xOffset = movement.x * Speed * Time.deltaTime;
        float yOffset = movement.y * Speed * Time.deltaTime;
        float xRawOffset = transform.localPosition.x + xOffset;
        float yRawOffset = transform.localPosition.y + yOffset;
        float xClamped = Mathf.Clamp(xRawOffset, -xPos, xPos);
        float yClamped = Mathf.Clamp(yRawOffset, -yPos, yPos);
        transform.localPosition = new Vector3(xClamped, yClamped, 0f);
    }
    void Protation()
    {
        float Pitch = -rollValue * movement.y;
        float roll = -rollValue * movement.x;
        Quaternion targetRotation = Quaternion.Euler(Pitch, 0f,roll);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, rollSpeed * Time.deltaTime);

        
    }

    public void  OnMove(InputValue value)
    {
       movement =  value.Get<Vector2>();    
    }
}
