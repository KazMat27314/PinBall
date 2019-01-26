using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private int Score = 0;
	private int collisionJud = 0;


	//Scoreを表示するテキスト
	private GameObject scoreText;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");

	}

	// Update is called once per frame
	void Update () {
		
	}
	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "SmallStarTag") {
			this.Score += 5;
			this.scoreText.GetComponent<Text> ().text = "Score:"+ Score;
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.Score += 10;
			this.scoreText.GetComponent<Text> ().text = "Score:"+ Score;
		} else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag") {				
			this.Score += 20;
			this.scoreText.GetComponent<Text> ().text = "Score:"+ Score;
		}
	}
}