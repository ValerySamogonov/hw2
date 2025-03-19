using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMovementComponent : IMovementComponent
{   
    private CharacterData characterData;
    private float speed;


    public float Speed 
    {get => speed;
    
    set
    {
        if (value < 0)
        speed = 0;
        else
        speed = value;
    }
    }

    public Vector3 Position => characterData.CharacterTransform.position;
    
    public void Initialize(CharacterData characterData)
    {
        this.characterData = characterData;
        Speed = characterData.DefaultSpeed;
    }




    public void Move(Vector3 direction)
    {
        if (direction == Vector3.zero) 
        {
            return;
        }
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        Vector3 movement = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
        characterData.CharacterController.Move(movement * Speed * Time.deltaTime);

    }
    
    public void Rotation(Vector3 direction)
    {
  if (direction == Vector3.zero) 
        {
            return;
        }
        float turnSmoothTime = 0.1f;
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(characterData.CharacterTransform.eulerAngles.y, targetAngle, ref turnSmoothTime, turnSmoothTime);
        
        characterData.CharacterTransform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
