var obj : GameObject;
public var Player = new GameObject[5];

function Update() {
	if (Input.GetKeyDown("r")) {

		for (var i = 1; i < 5; i++) {
			if (Player[i].activeSelf) { 
				obj = Player[i];
				if (obj.activeSelf) {obj.SetActive(false); }
			}
		}
	
		Player[0].SetActive(true);
		//Player[0].transformation.position = obj.transformation.position;
	}

}
