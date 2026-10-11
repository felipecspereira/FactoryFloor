using UnityEngine;

public class SawTrap : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    [SerializeField] private float velocidade = 3f;
    [SerializeField] private float distancia = 5f;

    private Vector3 posInicial;

    private void Start()
    {
        // Salva a posição onde você colocou a serra no cenário
        posInicial = transform.position;
    }

    private void Update()
    {
        // Calcula o deslocamento horizontal usando a função Seno (vai de -1 a 1)
        float deslocamentoX = Mathf.Sin(Time.time * velocidade) * distancia;

        // Aplica a nova posição com base na posição inicial
        transform.position = new Vector3(posInicial.x + deslocamentoX, posInicial.y, posInicial.z);
    }
}