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
    public Text silverIngotText;
    public Text crystalText;

    public int gold = 0;
    public int coal = 0;
    public int copper = 0;
    public int copperIngot = 0;
    public int silver = 0;
    public int silverIngot = 0;
    public int crystal = 0;

    public GameObject player;

    public GameObject bulletSpeedUpgradeButton;
    public GameObject bulletDamageUpgradeButton;
    public GameObject bulletCosmeticUnlockButton;

    public AudioClip[] audioClipArray;
    private AudioSource source;

    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Coal Collect") // If you collide with any object with this tag
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

        if (collision.transform.tag == "Crystal Collect")
        {
            crystal = crystal + 1;
            Destroy(collision.gameObject, 0.1f);
        }
        crystalText.text = crystal.ToString();
    }
    public void CoalSellShop1() // All of the bellow for each shop button to buy or sell items
    {
        if (coal >= 1)
        {
            coal -= 1;
            gold += 2;

            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        coalText.text = coal.ToString();
        goldText.text = gold.ToString();
    }
    public void SilverSellShop1()
    {
        if (silver >= 1)
        {
            silver -= 1;
            gold += 3;

            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        silverText.text = silver.ToString();
        goldText.text = gold.ToString();
    }
    public void CrystalSellShop1()
    {
        if (crystal >= 1)
        {
            crystal -= 1;
            gold += 6;

            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        crystalText.text = crystal.ToString();
        goldText.text = gold.ToString();
    }
    public void CopperSellShop1()
    {
        if (copper >= 1)
        {
            gold += 3;
            copper -= 1;

            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        copperText.text = copper.ToString();
        goldText.text = gold.ToString();
    }
    public void CopperBuyShop1()
    {
        if (gold >= 5)
        {
            gold -= 5;
            copper += 1;

            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        copperText.text = copper.ToString();
        goldText.text = gold.ToString();
    }
    public void CrystalBuyShop1()
    {
        if (gold >= 10)
        {
            gold -= 10;
            crystal += 1;

            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        crystalText.text = crystal.ToString();
        goldText.text = gold.ToString();
    }
    public void CopperIngotRefineShop2()
    {
        if (copper >= 5 && coal >= 1)
        {
            copper -= 5;
            coal -= 1;
            copperIngot += 1;

            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        coalText.text = coal.ToString();
        goldText.text = gold.ToString();
        copperText.text = copper.ToString();
        copperIngotText.text = copperIngot.ToString();
    }
    public void SilverIngotRefineShop2()
    {
        if (silver >= 5 && coal >= 1)
        {
            silver -= 5;
            coal -= 1;
            silverIngot += 1;

            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        coalText.text = coal.ToString();
        goldText.text = gold.ToString();
        silverText.text = silver.ToString();
        silverIngotText.text = silverIngot.ToString();
    }
    public void BulletCosmeticShop3()
    {
        if (silverIngot >= 2 && gold >= 20 && crystal >= 4)
        {
            silverIngot -= 2;
            gold -= 20;
            crystal -= 4;

            player.GetComponent<Shooting>().bulletCosmetic = true;
            bulletCosmeticUnlockButton.GetComponent<Button>().interactable = false;

            source.clip = audioClipArray[1];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        goldText.text = gold.ToString();
        silverIngotText.text = silverIngot.ToString();
        crystalText.text = crystal.ToString();
    }
    public void TankFireSpeedUpgradeShop2()
    {
        if (copperIngot >= 1 && gold >= 20)
        {
            copperIngot -= 1;
            gold -= 20;

            player.GetComponent<Shooting>().shootSpeed = true;
            player.GetComponent<Shooting>().timer = 0.1f;
            bulletSpeedUpgradeButton.GetComponent<Button>().interactable = false;

            source.clip = audioClipArray[1];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        goldText.text = gold.ToString();
        copperIngotText.text = copperIngot.ToString();
    }
    public void TankBulletDamageUpgradeShop2()
    {
        if (copperIngot >= 1 && crystal >= 5)
        {
            copperIngot -= 1;
            crystal -= 5;

            player.GetComponent<Shooting>().bulletDamage = true;
            bulletDamageUpgradeButton.GetComponent<Button>().interactable = false;

            source.clip = audioClipArray[1];
            source.PlayOneShot(source.clip);
            source.Play();
        }
        crystalText.text = crystal.ToString();
        copperIngotText.text = copperIngot.ToString();
    }




    //CHEATS

    public void GoldCheat()
    {
        gold += 10;
        goldText.text = gold.ToString();
    }

    public void CoalCheat()
    {
        coal += 10;
        coalText.text = coal.ToString();
    }

    public void CopperCheat()
    {
        copper += 10;
        copperText.text = copper.ToString();
    }

    public void SilverCheat()
    {
        silver += 10;
        silverText.text = silver.ToString();
    }
}
