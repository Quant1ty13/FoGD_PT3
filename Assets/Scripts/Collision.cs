using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private Material obstacleMaterial;
    [SerializeField] private Color matColor;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pillar"))
        {
            MeshRenderer rend = collision.gameObject.GetComponent<MeshRenderer>();
            obstacleMaterial = rend.material;
            matColor = obstacleMaterial.color;
            obstacleMaterial.color = Color.red;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("pillar"))
            transform.localScale += new Vector3(0.03f, 0.03f, 0.03f);
        else
            transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("pillar"))
        {
            MeshRenderer rend = collision.gameObject.GetComponent<MeshRenderer>();
            rend.material.color = matColor;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Containerr contain = other.GetComponent<Containerr>();
        GameObject newGameObject = contain.obstacle;
        //contain.obstacleRenderer.material.color;
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("stay on trigger obj");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit on trigger obj");
    }
}
