using UnityEngine.Events;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball")) {
            onTriggerEnter.Invoke();
            Debug.Log("GOALLLLLL");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
