using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
   public Transform transformPlayer;
   public GameObject cejasNeutrales;
   public GameObject cejasTristes;

   [SerializeField]
   private float enemySpeed = 100f;
    
    void Start()
    {
        
    }


    void Update()
    {
      ChequearDistanciaConELPlayer();   
      SeguirAlPlayer();
      LookAt();
    }

    void ChequearDistanciaConELPlayer()
    {
        float dist = Vector3.Distance(transform.position,transformPlayer.position);
        Debug.Log("Distancia contra el enemigo : " + dist);
    
       if (dist <= 5)
       {
         enemySpeed = 0f;
         Debug.Log("PONER CEJAS NEUTRALES");
         cejasNeutrales.SetActive(true);
         cejasTristes.SetActive(false);
       }
        else
       {
        enemySpeed = 2f;
        Debug.Log("PONER CEJAS TRISTES");
        cejasNeutrales.SetActive(false);
        cejasTristes.SetActive(true);
      }    
    }
 
     
    void LookAt()
    {
      transform.LookAt(transformPlayer);
    }

    void SeguirAlPlayer()
    {
     transform.position = Vector3.MoveTowards(transform.position,transformPlayer.position,enemySpeed * Time.deltaTime);
    
    }

}