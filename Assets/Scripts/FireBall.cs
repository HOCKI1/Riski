using UnityEngine;

public class FireBall : MonoBehaviour
{
    Rigidbody rb;
    [SerializeReference] float speed;
    [SerializeField] Transform player_;
    void Start()
    {
        //player_ = GameObject.FindGameObjectWithTag("Player").transform;
        //rb = GetComponent<Rigidbody>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if(other.CompareTag("Player"))
        {
            player_.position = new Vector3(104.24f, 23.12f, 4.61f);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        //rb.AddRelativeForce(Vector3.forward * speed);
    }
}
