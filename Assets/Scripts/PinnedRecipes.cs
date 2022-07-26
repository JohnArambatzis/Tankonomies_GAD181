using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinnedRecipes : MonoBehaviour
{
    public GameObject copperIngotPinButton;
    public GameObject silverIngotPinButton;
    public GameObject speedUpgradePinButton;
    public GameObject damageUpgradePinButton;
    public GameObject bulletCosmeticPinButton;

    public GameObject copperIngotPin;
    public GameObject silverIngotPin;
    public GameObject speedUpgradePin;
    public GameObject damageUpgradePin;
    public GameObject bulletCosmeticPin;



    public void CopperIngotPinned()
    {
        copperIngotPinButton.GetComponent<Button>().interactable = false;
        copperIngotPin.SetActive(true);

        silverIngotPin.SetActive(false);
        speedUpgradePin.SetActive(false);
        damageUpgradePin.SetActive(false);
        bulletCosmeticPin.SetActive(false);

        silverIngotPinButton.GetComponent<Button>().interactable = true;
        speedUpgradePinButton.GetComponent<Button>().interactable = true;
        damageUpgradePinButton.GetComponent<Button>().interactable = true;
        bulletCosmeticPinButton.GetComponent<Button>().interactable = true;
    }

    public void SilverIngotPinned()
    {
        silverIngotPinButton.GetComponent<Button>().interactable = false;
        silverIngotPin.SetActive(true);

        copperIngotPin.SetActive(false);
        speedUpgradePin.SetActive(false);
        damageUpgradePin.SetActive(false);
        bulletCosmeticPin.SetActive(false);

        copperIngotPinButton.GetComponent<Button>().interactable = true;
        speedUpgradePinButton.GetComponent<Button>().interactable = true;
        damageUpgradePinButton.GetComponent<Button>().interactable = true;
        bulletCosmeticPinButton.GetComponent<Button>().interactable = true;
    }

    public void SpeedUpgradePinned()
    {
        speedUpgradePinButton.GetComponent<Button>().interactable = false;
        speedUpgradePin.SetActive(true);

        copperIngotPin.SetActive(false);
        silverIngotPin.SetActive(false);
        damageUpgradePin.SetActive(false);
        bulletCosmeticPin.SetActive(false);

        copperIngotPinButton.GetComponent<Button>().interactable = true;
        silverIngotPinButton.GetComponent<Button>().interactable = true;
        damageUpgradePinButton.GetComponent<Button>().interactable = true;
        bulletCosmeticPinButton.GetComponent<Button>().interactable = true;
    }

    public void DamageUpgradePinned()
    {
        damageUpgradePinButton.GetComponent<Button>().interactable = false;
        damageUpgradePin.SetActive(true);

        copperIngotPin.SetActive(false);
        silverIngotPin.SetActive(false);
        speedUpgradePin.SetActive(false);
        bulletCosmeticPin.SetActive(false);

        copperIngotPinButton.GetComponent<Button>().interactable = true;
        silverIngotPinButton.GetComponent<Button>().interactable = true;
        speedUpgradePinButton.GetComponent<Button>().interactable = true;
        bulletCosmeticPinButton.GetComponent<Button>().interactable = true;
    }

    public void BulletCosmeticPinned()
    {
        bulletCosmeticPinButton.GetComponent<Button>().interactable = false;
        bulletCosmeticPin.SetActive(true);

        copperIngotPin.SetActive(false);
        silverIngotPin.SetActive(false);
        speedUpgradePin.SetActive(false);
        damageUpgradePin.SetActive(false);

        copperIngotPinButton.GetComponent<Button>().interactable = true;
        silverIngotPinButton.GetComponent<Button>().interactable = true;
        speedUpgradePinButton.GetComponent<Button>().interactable = true;
        damageUpgradePinButton.GetComponent<Button>().interactable = true;
    }
}
