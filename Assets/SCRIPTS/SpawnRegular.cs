using UnityEngine;

public class SpawnRegular : MonoBehaviour
{
    public GameObject objetoPrefab;
    public float intervaloDeSpawn = 2f;
    public float tiempoDeVida = 3f;

    void Start()
    {
        InvokeRepeating("SpawnObjeto", 0f, intervaloDeSpawn);
    }

    void SpawnObjeto()
    {
        GameObject nuevoObjeto = Instantiate(objetoPrefab, transform.position, Quaternion.identity);
        Destroy(nuevoObjeto, tiempoDeVida);
    }
}
