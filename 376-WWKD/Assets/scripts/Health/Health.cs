using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.Processors;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {

        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth <= 0 && !dead)
        {
            currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
            GetComponent<PlayerController>().enabled = false;
            GetComponent<PlayerController>().Die();
            dead = true;

            StartCoroutine(DelayedRespawn());
        }
    }
    public IEnumerator DelayedRespawn()
    {
        yield return new WaitForSeconds(1.0f); // Waits 1 seconds to respawn the player
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            TakeDamage(1);
    }*/
}
