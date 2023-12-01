using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using UnityEngine.SceneManagement;

public class EndlessRunnerGraphicsZuweisung : MonoBehaviour
{
    public List<Sprite> Jupitersprites = new List<Sprite>();
    public List<Sprite> Marssprites = new List<Sprite>();
    public List<Sprite> Merkursprites = new List<Sprite>();
    public List<Sprite> Neptunsprites = new List<Sprite>();
    public List<Sprite> Saturnsprites = new List<Sprite>();
    public List<Sprite> Uranussprites = new List<Sprite>();
    public List<Sprite> Venussprites = new List<Sprite>();

    private SpriteRenderer spriterenderer;
    private string CurrentScene;
    private bool set = false;

    private void Start()
    {
        CurrentScene = SceneManager.GetActiveScene().name;
    }
    void Update()
    {


        switch (CurrentScene)
        {
            case "EndlessRunnerMerkur":
            case "LevelMerkur":
                if (CompareTag("left_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("left_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[0];

                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[1];
                            set = true;
                        }
                    }
                }
                if (CompareTag("right_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("right_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[2];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_dirt"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_dirt"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[3];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_slope"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_slope"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[4];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grass_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grass_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[5];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grassdot"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grassdot"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[6];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[7];
                            set = true;
                        }
                    }
                }
                if (CompareTag("slope_w_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("slope_w_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[8];
                            set = true;
                        }
                    }
                }
                if (CompareTag("dirt_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("dirt_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[9];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_r"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_r"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[10];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[11];
                            set = true;
                        }
                    }
                }
                if (CompareTag("micro_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("micro_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[12];
                            set = true;
                        }
                    }
                }
                if (CompareTag("big_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("big_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[13];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Merkursprites[14];
                            set = true;
                        }
                    }
                }
                break;

            case "EndlessRunnerVenus":
            case "LevelVenus":
                if (CompareTag("left_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("left_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[0];

                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[1];
                            set = true;
                        }
                    }
                }
                if (CompareTag("right_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("right_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[2];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_dirt"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_dirt"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[3];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_slope"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_slope"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[4];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grass_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grass_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[5];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grassdot"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grassdot"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[6];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[7];
                            set = true;
                        }
                    }
                }
                if (CompareTag("slope_w_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("slope_w_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[8];
                            set = true;
                        }
                    }
                }
                if (CompareTag("dirt_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("dirt_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[9];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_r"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_r"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[10];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[11];
                            set = true;
                        }
                    }
                }
                if (CompareTag("micro_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("micro_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[12];
                            set = true;
                        }
                    }
                }
                if (CompareTag("big_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("big_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[13];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Venussprites[14];
                            set = true;
                        }
                    }
                }
                break;

            case "EndlessRunnerErde":
            case "LevelErde":
                break;

            case "EndlessRunnerMars":
            case "LevelMars":
                if (CompareTag("left_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("left_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[0];

                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[1];
                            set = true;
                        }
                    }
                }
                if (CompareTag("right_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("right_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[2];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_dirt"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_dirt"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[3];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_slope"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_slope"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[4];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grass_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grass_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[5];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grassdot"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grassdot"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[6];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[7];
                            set = true;
                        }
                    }
                }
                if (CompareTag("slope_w_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("slope_w_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[8];
                            set = true;
                        }
                    }
                }
                if (CompareTag("dirt_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("dirt_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[9];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_r"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_r"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[10];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[11];
                            set = true;
                        }
                    }
                }
                if (CompareTag("micro_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("micro_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[12];
                            set = true;
                        }
                    }
                }
                if (CompareTag("big_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("big_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[13];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Marssprites[14];
                            set = true;
                        }
                    }
                }
                break;

            case "EndlessRunnerJupiter":
            case "LevelJupiter":
                if (CompareTag("left_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("left_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[0];

                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[1];
                            set = true;
                        }
                    }
                }
                if (CompareTag("right_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("right_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[2];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_dirt"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_dirt"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[3];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_slope"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_slope"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[4];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grass_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grass_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[5];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grassdot"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grassdot"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[6];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[7];
                            set = true;
                        }
                    }
                }
                if (CompareTag("slope_w_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("slope_w_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[8];
                            set = true;
                        }
                    }
                }
                if (CompareTag("dirt_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("dirt_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[9];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_r"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_r"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[10];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[11];
                            set = true;
                        }
                    }
                }
                if (CompareTag("micro_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("micro_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[12];
                            set = true;
                        }
                    }
                }
                if (CompareTag("big_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("big_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[13];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Jupitersprites[14];
                            set = true;
                        }
                    }
                }
                break;

            case "EndlessRunnerSaturn":
            case "LevelSaturn":
                if (CompareTag("left_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("left_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[0];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[1];
                            set = true;
                        }
                    }
                }
                if (CompareTag("right_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("right_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[2];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_dirt"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_dirt"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[3];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_slope"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_slope"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[4];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grass_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grass_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[5];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grassdot"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grassdot"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[6];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[7];
                            set = true;
                        }
                    }
                }
                if (CompareTag("slope_w_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("slope_w_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[8];
                            set = true;
                        }
                    }
                }
                if (CompareTag("dirt_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("dirt_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[9];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_r"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_r"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[10];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[11];
                            set = true;
                        }
                    }
                }
                if (CompareTag("micro_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("micro_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[12];
                            set = true;
                        }
                    }
                }
                if (CompareTag("big_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("big_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[13];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Saturnsprites[14];
                            set = true;
                        }
                    }
                }
                break;

            case "EndlessRunnerUranus":
            case "LevelUranus":
                if (CompareTag("left_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("left_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[0];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[1];
                            set = true;
                        }
                    }
                }
                if (CompareTag("right_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("right_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[2];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_dirt"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_dirt"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[3];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_slope"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_slope"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[4];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grass_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grass_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[5];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grassdot"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grassdot"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[6];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[7];
                            set = true;
                        }
                    }
                }
                if (CompareTag("slope_w_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("slope_w_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[8];
                            set = true;
                        }
                    }
                }
                if (CompareTag("dirt_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("dirt_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[9];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_r"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_r"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[10];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[11];
                            set = true;
                        }
                    }
                }
                if (CompareTag("micro_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("micro_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[12];
                            set = true;
                        }
                    }
                }
                if (CompareTag("big_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("big_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[13];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Uranussprites[14];
                            set = true;
                        }
                    }
                }
                break;

            case "EndlessRunnerNeptun":
            case "LevelNeptun":
                if (CompareTag("left_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("left_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[0];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[1];
                            set = true;
                        }
                    }
                }
                if (CompareTag("right_edge"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("right_edge"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[2];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_dirt"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_dirt"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[3];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_slope"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_slope"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[4];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grass_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grass_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[5];
                            set = true;
                        }
                    }
                }
                if (CompareTag("n_grassdot"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("n_grassdot"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[6];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[7];
                            set = true;
                        }
                    }
                }
                if (CompareTag("slope_w_grass"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("slope_w_grass"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[8];
                            set = true;
                        }
                    }
                }
                if (CompareTag("dirt_w_bl_u"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("dirt_w_bl_u"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[9];
                            set = true;
                        }
                    }
                }
                if (CompareTag("grassdot_w_bl_r"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("grassdot_w_bl_r"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[10];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[11];
                            set = true;
                        }
                    }
                }
                if (CompareTag("micro_mush_plat"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("micro_mush_plat"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[12];
                            set = true;
                        }
                    }
                }
                if (CompareTag("big_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("big_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[13];
                            set = true;
                        }
                    }
                }
                if (CompareTag("small_rock"))
                {
                    if (set == false)
                    {
                        foreach (GameObject g in GameObject.FindGameObjectsWithTag("small_rock"))
                        {
                            spriterenderer = this.GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = Neptunsprites[14];
                            set = true;
                        }
                    }
                }
                break;
        }
    }
}
