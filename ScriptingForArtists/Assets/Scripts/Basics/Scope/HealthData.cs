[System.Serializable]
public class HealthData {

	//This is our players base heath data.
	public int health;
	public int strength;
	public int speed = 20;
	private int defense = 100;
	public string username;

	public int TakeDownDefense () {
		return defense -= 10;
	}

}