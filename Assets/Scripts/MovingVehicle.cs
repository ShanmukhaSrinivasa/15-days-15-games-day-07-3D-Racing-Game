using UnityEngine;

public class MovingVehicle : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
