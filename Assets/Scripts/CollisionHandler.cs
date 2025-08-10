using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] ParticleSystem ShipDestroy;
    GameSceneManagement gameSceneManagement;

    private void Start()
    {
        gameSceneManagement = FindFirstObjectByType<GameSceneManagement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        gameSceneManagement.reloadLevel();
        Destroy(gameObject);
        Instantiate(ShipDestroy, transform.position, Quaternion.identity);
            
    }
}
