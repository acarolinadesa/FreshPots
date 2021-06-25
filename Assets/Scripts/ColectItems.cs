using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColectItems : MonoBehaviour {
    public Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Start() {
        score = 0;
    }

    // Update is called once per frame
    void Update() {
        scoreText.text = "X" + score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("Coffee") == true){
            score = score+1;
            Destroy(col.gameObject);
        }
    }
}
