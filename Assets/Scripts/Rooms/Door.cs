using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previusRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
            {
                cam.MoveToNewRoom(nextRoom);
                nextRoom.GetComponent<Room>().ActivateRoom(true);
                previusRoom.GetComponent<Room>().ActivateRoom(false);
            }

            else
            {
                cam.MoveToNewRoom(previusRoom);
                previusRoom.GetComponent<Room>().ActivateRoom(true);
                nextRoom.GetComponent<Room>().ActivateRoom(false);
            }

        }
    }

}
