using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public IHealthComponents HealthComponent {get; protected set;}




    
    public virtual void Initialize()
    {

        Debug.Log("Character initialized!");

    }
    
    void Start()
    {
        Initialize();
    }

}
