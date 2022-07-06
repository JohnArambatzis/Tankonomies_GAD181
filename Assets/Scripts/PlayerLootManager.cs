using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLootManager : MonoBehaviour
{
    public Text goldText;
    public Text coalText;
    public Text copperText;
    public Text copperIngotText;
    public Text silverText;

    public int gold = 0;
    public int coal = 0;
    public int copper = 0;
    public int copperIngot = 0;
    public int silver = 0;

    public GameObject player;
    public GameObject refinementTabShop1;
    public GameObject refinementTabButtonOpenShop1;
    public GameObject refinementTabButtonCloseShop1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Coal Collect")
        {
            coal = coal + 1;
            Destroy(collision.gameObject, 0.1f);
        }
        coalText.text = coal.ToString();

        if (collision.transform.tag == "Silver Collect")
        {
            silver = silver + 1;
            Destroy(collision.gameObject, 0.1f);
        }
        silverText.text = silver.ToString();
    }
    public void RefinementTabOpenShop1()
    {
        refinementTabShop1.SetActive(true);
        refinementTabButtonOpenShop1.SetActive(false);
        refinementTabButtonCloseShop1.SetActive(true);
    }
    public void RefinementTabCloseShop1()
    {
        refinementTabShop1.SetActive(false);
        refinementTabButtonOpenShop1.SetActive(true);
        refinementTabButtonCloseShop1.SetActive(false);
    }
    public void CoalSellShop1()
    {
        if (coal >= 1)
        {
            coal -= 1;
            gold += 2;
        }
        coalText.text = coal.ToString();
        goldText.text = gold.ToString();
    }
    public void SilverSellShop1()
    {
        if (silver >= 1)
        {
            silver -= 1;
            gold += 5;
        }
        silverText.text = silver.ToString();
        goldText.text = gold.ToString();
    }
    public void CopperBuyShop1()
    {
        if (gold >= 5)
        {
            gold -= 5;
            copper += 1;
        }
        copperText.text = copper.ToString();
        goldText.text = gold.ToString();
    }
    public void CopperIngotRefineShop1()
    {
        if (copper >= 5 && coal >= 1)
        {
            copper -= 5;
            coal -= 1;
            copperIngot += 1;
        }
        coalText.text = coal.ToString();
        goldText.text = gold.ToString();
        copperText.text = copper.ToString();
        copperIngotText.text = copperIngot.ToString();
    }
    public void TankFireSpeedUpgradeShop1()
    {
        if (copperIngot >= 1 && gold >= 20)
        {
            copperIngot -= 1;
            gold -= 20;

            player.GetComponent<Shooting>().shootSpeed = true;
        }
        goldText.text = gold.ToString();
        copperIngotText.text = copperIngot.ToString();
    }
}
