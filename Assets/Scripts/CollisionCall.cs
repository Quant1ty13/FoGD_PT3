using UnityEngine;

public class CollisionCall : MonoBehaviour
{
    [SerializeField] private Material Pillar;
    [SerializeField] private Material Player;
    [SerializeField] private Color matColor;
    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.CompareTag("pillar"))
        { 
            MeshRenderer rend = collision.gameObject.GetComponent<MeshRenderer>();
            rend.material.color = Player.color;
            matColor = rend.material.color;
            Pillar.color = Player.color;
        } 
        if (collision.gameObject.CompareTag("Player")) 
        { 
            MeshRenderer rend = collision.gameObject.GetComponent<MeshRenderer>(); 
            rend.material.color = Pillar.color; 
            matColor = rend.material.color; 
            Player.color = Pillar.color; 
        } 
    }
}
