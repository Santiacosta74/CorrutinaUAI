using UnityEngine;

public class SpawnAleatorio : MonoBehaviour
{
    public GameObject objetoPrefab;
    public float intervaloMinimo = 1f;
    public float intervaloMaximo = 5f;
    public float tiempoDeVida = 3f;

    void Start()
    {
        Invoke("SpawnObjeto", Random.Range(intervaloMinimo, intervaloMaximo));
    }

    void SpawnObjeto()
    {
        GameObject nuevoObjeto = Instantiate(objetoPrefab, transform.position, Quaternion.identity);
        Destroy(nuevoObjeto, tiempoDeVida);
        Invoke("SpawnObjeto", Random.Range(intervaloMinimo, intervaloMaximo));
    }
}