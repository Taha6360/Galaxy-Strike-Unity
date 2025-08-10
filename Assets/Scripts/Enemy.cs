using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem EnemyDestruction;
    [SerializeField] float hits;
    [SerializeField]  int scorepoint = 10; // how many points for each enemy
    ScoreBoard Scoreboard;

    private void Start()
    {
        Scoreboard = FindFirstObjectByType<ScoreBoard>();
    }
    private void OnParticleCollision(GameObject other)
    {
        hits--;
        if(hits <= 0)
        {
           Scoreboard.IncreaseScore(scorepoint);
           Instantiate(EnemyDestruction, transform.position, Quaternion.identity);
           Destroy(gameObject);

        }
    }

}
