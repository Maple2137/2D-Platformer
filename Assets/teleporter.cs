using UnityEngine;

public class teleporter : MonoBehaviour
{
    public Transform destination;
   // public Vector3 destination;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = destination.position;
        // collision.transform.position = destination;
    }

   // private void OnDrawGizmosSelected()
}
