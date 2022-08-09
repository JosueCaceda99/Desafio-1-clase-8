using UnityEngine;

public class Proyectil : MonoBehaviour
{
  
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(new Vector3(0,0,0.1f));
    }
}
