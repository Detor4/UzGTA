using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsDoor : MonoBehaviour
{
    PlayerCarsManager carsManager;
    CarsDoor carsDoor;
    //[SerializeField] CarControllerTest carController;


    [SerializeField] GameObject CarFollowCamera;
    [SerializeField] GameObject CarCanvas;
    [SerializeField] Transform CarDoorTransformPoint;

    private void Start()
    {
        carsDoor = GetComponent<CarsDoor>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            carsManager = other.GetComponent<PlayerCarsManager>();

            carsManager.OpenCarsDoorButton();
            carsManager.GetCarsDoor(carsDoor);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            carsManager.CloseCarsDoorButton();
        }
    }

    public void ActivateCar()
    {
        CarFollowCamera.SetActive(true);
        CarCanvas.SetActive(true);
        //carController.CanYouDriwing = true;
    }

    public void FinishCarDriwingButtonClick()
    {
        carsManager.GetDownCars(CarDoorTransformPoint);

        CarFollowCamera.SetActive(false);
        CarCanvas.SetActive(false);
        //carController.CanYouDriwing = false;


        
    }
}
