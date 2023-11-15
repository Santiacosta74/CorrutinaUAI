using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CuentaRegresiva : MonoBehaviour
{
    public Text contadorRegresivo;
    public SpawnRegular spawnRegular;
    public SpawnAleatorio spawnAleatorio;

    void Start()
    {
        StartCoroutine(MostrarContador());
    }

    IEnumerator MostrarContador()
    {
        contadorRegresivo.text = "3";
        yield return new WaitForSeconds(1f);

        contadorRegresivo.text = "2";
        yield return new WaitForSeconds(1f);

        contadorRegresivo.text = "1";
        yield return new WaitForSeconds(1f);

        contadorRegresivo.text = "¡Spawns!";
        yield return new WaitForSeconds(1f);

        // Activa los spawns después de mostrar el mensaje.
        spawnRegular.gameObject.SetActive(true);
        spawnAleatorio.gameObject.SetActive(true);

        // Puedes agregar aquí lógica adicional para comenzar el juego.

        contadorRegresivo.gameObject.SetActive(false); // Desactiva el objeto que contiene el contador.
    }
}