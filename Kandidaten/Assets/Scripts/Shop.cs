using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncher;



	public void selectStandardTurret(){
		if(playerStats.money < standardTurret.cost)
		{
			print("NOT ENOUGH MONEY");
			return;
		}
		playerStats.money -= standardTurret.cost;
		GameObject turret = (GameObject)Instantiate(standardTurret.prefab, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 48f)), Quaternion.identity);
	}

	public void selectMissileTurret(){
		if(playerStats.money < standardTurret.cost)
		{
			print("NOT ENOUGH MONEY");
			return;
		}
		playerStats.money -= missileLauncher.cost;
		GameObject turret = (GameObject)Instantiate(missileLauncher.prefab, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 48f)), Quaternion.identity);
	}


}
