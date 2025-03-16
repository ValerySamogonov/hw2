using UnityEngine;

public Interface IMovementComponent 
{
    float Speed {get; set;}

    Vector3 Position{get;}

    void Move(Vector3 direction);

    void Rotation(Vector3 direction);
}
