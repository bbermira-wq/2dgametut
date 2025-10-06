using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D body; 

    private void Awake()
    {
        body = GetComponent<Rigidbody2D> ();
    }

}
