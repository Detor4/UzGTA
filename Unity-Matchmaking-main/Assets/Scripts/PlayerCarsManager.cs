using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarsManager : MonoBehaviour
{

    CarsDoor carDoor;

    [SerializeField] GameObject OpenCarsDoorButtonUI;
    [SerializeField] GameObject PlayerFollowCamera;
    [SerializeField] GameObject PlayerCanvas;
    [SerializeField] GameObject Player;

    public void OpenCarsDoorButton()
    {
        OpenCarsDoorButtonUI.gameObject.SetActive(true);

    }

    public void CloseCarsDoorButton()
    {
        OpenCarsDoorButtonUI.gameObject.SetActive(false);
    }

    public void GetCarsDoor(CarsDoor carsDoor)
    {

       carDoor = carsDoor;
        
    }

    public void OpenCarsDoorButtonClick()// moshinaga o'tirish knopkasi bosilganda
    {
        PlayerFollowCamera.gameObject.SetActive(false);// player kamerasi o'chadi
        PlayerCanvas.gameObject.SetActive(false);// Player canvas o'chadi
        Player.SetActive(false);// player o'chadi
        carDoor.ActivateCar();// moshina aktivlashadi
        OpenCarsDoorButtonUI.SetActive(false);
    }

    public void GetDownCars(Transform getDownCarsTransform)// moshinada tushish
    {
        GetDownCarsPlace(getDownCarsTransform);

        PlayerFollowCamera.gameObject.SetActive(true);
        PlayerCanvas.gameObject.SetActive(true);
        Player.SetActive(true);

        
    }

    private void GetDownCarsPlace(Transform point)
    {
        Player.transform.position = new Vector3(point.position.x,point.position.y,point.position.z);
        Debug.Log(point.position);
        
    }

    
}
