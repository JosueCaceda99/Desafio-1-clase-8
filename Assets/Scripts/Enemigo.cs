using UnityEngine;

public class Enemigo : MonoBehaviour
{
   public Transform transformPlayer;  //referecia a la pocision del player
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
      SeguirAlJugador();
      LookAt();
    }

    void ChequearDistanciaConELPlayer()
    {
        float dist = Vector3.Distance(transform.position,transformPlayer.position);
        Debug.Log("Distancia contra el enemigo : " + dist);
    
       if (dist <= 5)
       {
         Debug.Log("PONER CEJAS NEUTRALES");
         cejasNeutrales.SetActive(true);
         cejasTristes.SetActive(false);
       }
        else
       {
        Debug.Log("PONER CEJAS TRISTES");
        cejasNeutrales.SetActive(false);
        cejasTristes.SetActive(true);
      }    
    }

    void LookAt()
    {
      transform.LookAt(transformPlayer);
    }
    void SeguirAlJugador()
    {
     transform.position = Vector3.MoveTowards(transform.position,transform.position,enemySpeed * Time.deltaTime);
    
    }

}