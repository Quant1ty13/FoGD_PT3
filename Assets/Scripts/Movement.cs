using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject moveObject;
    [SerializeField] private float speed = 5;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0.0f, y);
        moveObject.transform.Translate(move * Time.deltaTime * speed);
    }
}
