using UnityEngine;

public class Player : MonoBehaviour
{ 
    public float speed = 10f;
    public Transform posEnemigo;
    public float rotateSpeed = 100;
    void Start()
    {
        
    }

   
    void Update()
    {  
       MoverPersonaje();

       PlayerMoveMent();
    }

  

    void MoverPersonaje()
    {
       float hor = Input.GetAxis("Horizontal");
       float ver = Input.GetAxis("Vertical");

       transform.Translate(new Vector3(hor,0,ver) * speed * Time.deltaTime); 
    }
    void PlayerMoveMent()
    {
      float ver = Input.GetAxis("Vertical");
      transform.Translate(new Vector3(0,0,ver)*speed*Time.deltaTime);

      float hor = Input.GetAxis("Horizontal");
      transform.Rotate(new Vector3(0,hor,0)*rotateSpeed*Time.deltaTime);
    }

}
