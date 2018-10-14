using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataquePlayer : MonoBehaviour {

    public int damageToGive;
    public Transform euMesmoEnemy;
    public Transform meuPlayer;
    Vector3 minhaPosicao;
    Vector3 posicaoEnemy;
    Vector3 distanciaEuEnemy;
    Vector3 direcaoPulo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
            minhaPosicao = euMesmoEnemy.position;
            posicaoEnemy = meuPlayer.position;

            distanciaEuEnemy = new Vector3(posicaoEnemy.x - minhaPosicao.x, posicaoEnemy.y - minhaPosicao.y, posicaoEnemy.z - minhaPosicao.z);
            direcaoPulo = (distanciaEuEnemy * -1);

            euMesmoEnemy.position += direcaoPulo;


        }
    }


}
