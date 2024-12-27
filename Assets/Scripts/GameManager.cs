using UnityEngine;
using Juvenal;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 

    }
}