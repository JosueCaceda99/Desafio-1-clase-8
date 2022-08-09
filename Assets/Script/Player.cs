using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float tiempo = 10f;
    public float tiempoRestante;
    public GameObject prefabBala;
    public Transform positionBazuca;
    void Start()
    {
       ResetearTemporizador(); 
    }

    
    void Update()
    {
      MovimientoJugador();
      Temporizador();
      Disparar();
    }
    
    void MovimientoJugador()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(hor,0,ver)*speed*Time.deltaTime);
    }

    void ResetearTemporizador()
    {
       tiempoRestante = tiempo;
    }

    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if(tiempoRestante <=0)
        {
            Debug.Log("Se ha acabado el tiempo");
            ResetearTemporizador();
        }
    }

    void Disparar()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabBala,positionBazuca.position,transform.rotation);
        }
    }
}
