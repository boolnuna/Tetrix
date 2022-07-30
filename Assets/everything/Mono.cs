using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class Mono : MonoBehaviour
{
    // Classes,Methods are Capitalized
    // all variables are camelCase
    // setup 2d array
    // setup texture
    // transfer over old code

    public Render render;

    public int[,] grid = new int[10, 20];

    [NonSerialized]
    public int[][][,] og = new int[][][,]{
        new int[][,]{
            new int[,]{
                {0,1,0,0},
                {0,1,0,0},
                {0,1,0,0},
                {0,1,0,0}
            },
            new int[,]{
                {0,0,0,0},
                {1,1,1,1},
                {0,0,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,1,0,0},
                {0,1,0,0},
                {0,1,0,0},
                {0,1,0,0}
            },
            new int[,]{
                {0,0,0,0},
                {1,1,1,1},
                {0,0,0,0},
                {0,0,0,0}
            }
        },
        new int[][,]{
            new int[,]{
                {0,1,0,0},
                {0,1,0,0},
                {0,1,1,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,0,0,0},
                {1,1,1,0},
                {1,0,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {1,1,0,0},
                {0,1,0,0},
                {0,1,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,0,1,0},
                {1,1,1,0},
                {0,0,0,0},
                {0,0,0,0}
            }
        },
        new int[][,]{
            new int[,]{
                {0,1,1,0},
                {0,1,0,0},
                {0,1,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,0,0,0},
                {1,1,1,1},
                {0,0,0,1},
                {0,0,0,0}
            },
            new int[,]{
                {0,1,0,0},
                {0,1,0,0},
                {1,1,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {1,0,0,0},
                {1,1,1,0},
                {0,0,0,0},
                {0,0,0,0}
            }
        },
          new int[][,]{
            new int[,]{
                {1,0,0,0},
                {1,1,0,0},
                {0,1,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,1,1,0},
                {1,1,0,0},
                {0,0,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {1,0,0,0},
                {1,1,0,0},
                {0,1,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,1,1,0},
                {1,1,0,0},
                {0,0,0,0},
                {0,0,0,0}
            }
        },
        new int[][,]{
            new int[,]{
                {0,1,0,0},
                {1,1,0,0},
                {1,0,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {1,1,0,0},
                {0,1,1,0},
                {0,0,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,1,0,0},
                {1,1,0,0},
                {1,0,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {1,1,0,0},
                {0,1,1,0},
                {0,0,0,0},
                {0,0,0,0}
            }
        },
         new int[][,]{
            new int[,]{
                {0,1,0,0},
                {0,1,1,0},
                {0,1,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,0,0,0},
                {1,1,1,0},
                {0,1,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,1,0,0},
                {1,1,0,0},
                {0,1,0,0},
                {0,0,0,0}
            },
            new int[,]{
                {0,1,0,0},
                {1,1,1,0},
                {0,0,0,0},
                {0,0,0,0}
            }
        }
    };
    [NonSerialized]
    public int[][,] pattern = new int[][,]{
        new int[,]{
            {0,0,0,0,0,0,0,0},
            {0,1,1,1,1,1,1,0},
            {0,1,0,0,0,0,1,0},
            {0,1,0,3,3,0,1,0},
            {0,1,0,3,3,0,1,0},
            {0,1,0,0,0,0,1,0},
            {0,1,1,1,1,1,1,0},
            {0,0,0,0,0,0,0,0}
        },
        new int[,]{
            {0,0,0,0,0,0,0,0},
            {0,2,2,2,2,2,2,0},
            {0,2,2,2,2,2,2,0},
            {0,2,2,0,0,2,2,0},
            {0,2,2,0,0,2,2,0},
            {0,2,2,2,2,2,2,0},
            {0,2,2,2,2,2,2,0},
            {0,0,0,0,0,0,0,0}
        },
        new int[,]{
            {0,0,0,0,0,0,0,0},
            {0,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,0},
            {0,0,0,0,0,0,0,0}
        },
        new int[,]{
            {0,0,0,0,0,0,0,0},
            {0,2,2,2,2,2,2,0},
            {0,2,3,3,3,3,2,0},
            {0,2,3,2,2,0,2,0},
            {0,2,3,2,2,0,2,0},
            {0,2,0,0,0,0,2,0},
            {0,2,2,2,2,2,2,0},
            {0,0,0,0,0,0,0,0}
        }

    };
    public Tetromino[] queue;
    public Tetromino fall;
    public Vector2Int fallPos;

    Vector2Int[] bbb = new Vector2Int[]
    {
        new Vector2Int(0,0),
        new Vector2Int(0,0),
        new Vector2Int(0,0),
        new Vector2Int(0,0)
    };
    public Vector2Int[] JustTheBlocks(int oriIndex)
    {
        int i = 0;
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if (og[fall.ogIndex][oriIndex][y, x] == 1)
                {
                    bbb[i].x = x;
                    bbb[i].y = y;
                    i++;
                }
            }
        }
        return bbb;
    }

    [Serializable]
    public class Tetromino
    {
        public int ogIndex, oriIndex, patternIndex;
        public Tetromino(int ogIndex, int oriIndex, int patternIndex)
        {
            this.ogIndex = ogIndex;
            this.oriIndex = oriIndex;
            this.patternIndex = patternIndex;
        }
    }

    // public Vector3 InBounds(Transform t)
    // {


    //     // foreach (Transform child in t)
    //     // {
    //     //     if (child.position.x < -bounds.x / 2 || child.position.x > bounds.x / 2)
    //     //     {
    //     //         // return direction
    //     //         float x = Mathf.Sign(child.position.x);
    //     //         return new Vector3(x, 0, 0);
    //     //     }

    //     //     if (child.position.y < -bounds.y / 2 || child.position.y > bounds.y / 2)
    //     //     {
    //     //         // return direction
    //     //         float y = Mathf.Sign(child.position.y);
    //     //         return new Vector3(0, y, 0);
    //     //     }
    //     // }
    //     // return Vector3.zero;
    // }
    public void Start()
    {
        queue = new Tetromino[4];
        int i = queue.Length * 2;
        while (i > 0)
        {
            Restock();
            i--;
        }
        render.Start();
    }

    float step = 0f;
    public Repeater keyLeft, keyRight, keyDown;
    [Serializable]
    public class Repeater
    {
        float delay;
        public KeyCode key;
        public Repeater(KeyCode key)
        {
            this.key = key;
        }
        public bool IsDown()
        {
            if (Input.GetKeyDown(key))
            {
                delay = 0.5f + Time.time;
                return true;
            }
            if (Input.GetKey(key) && delay < Time.time)
            {
                delay = 0.1f + Time.time;
                return true;
            }
            return false;
        }

    }
    void Update()
    {
        // Tetromino rotation
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Turn();
        }

        if (keyRight.IsDown()) { Shift(new Vector2Int(1, 0), false); }
        if (keyLeft.IsDown()) { Shift(new Vector2Int(-1, 0), false); }
        if (keyDown.IsDown()) { Shift(new Vector2Int(0, -1), true); }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int i = 0;
            while (i < 100 && Shift(new Vector2Int(0, -1), true)) { i++; }
        }

        // step loop
        step += Time.deltaTime;
        if (step > 0.4f)
        {
            step = 0f;
            Shift(new Vector2Int(0, -1), true);
        }

        // Debug Tools
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Restock();
        }


        render.Update(this);
    }

    public void Restock()
    {
        fall = queue[0];
        fallPos = new Vector2Int(4, 20);
        // shift down
        for (int i = 0; i < queue.Length; i++)
        {
            queue[i] = queue[Mathf.Clamp(i + 1, 0, queue.Length - 1)];
        }
        queue[queue.Length - 1] = new Tetromino(
            Random.Range(0, og.Length),
            Random.Range(0, 4),
            Random.Range(0, pattern.Length)
        );
    }
    public bool Turn()
    {
        int oriIndex = fall.oriIndex + 1;
        oriIndex = oriIndex >= 4 ? 0 : oriIndex;

        bool canTurn = true;

        canTurn = Shift(Vector2Int.zero, false, oriIndex);
        if (!canTurn)
        {
            canTurn = Shift(Vector2Int.left, false, oriIndex);
            if (!canTurn)
            {
                canTurn = Shift(Vector2Int.right, false, oriIndex);
                if (!canTurn)
                {
                    canTurn = Shift(Vector2Int.up, false, oriIndex);
                    if (!canTurn)
                    {
                        canTurn = Shift(Vector2Int.down, false, oriIndex);
                    }
                }
            }
        }
        if (canTurn)
        {
            fall.oriIndex = oriIndex;
        }
        return canTurn;
    }
    public bool Shift(Vector2Int v, bool place, int? oriIndex = null)
    {
        if (oriIndex == null)
        {
            oriIndex = fall.oriIndex;
        }
        bool canMove = true;
        Vector2Int[] blocks = JustTheBlocks((int)oriIndex);
        for (int i = 0; i < 4; i++)
        {
            Vector2Int b = blocks[i];
            bool under = fallPos.y + (4 - b.y) + v.y < 0;
            bool left = fallPos.x + b.x + v.x < 0;
            bool right = fallPos.x + b.x + v.x >= grid.GetLength(0);
            if (InBlock(b.x, b.y, v.x, v.y) || under || left || right)
            {
                canMove = false;
                break;
            }
        }
        if (canMove)
        {
            fallPos += v;
            return canMove;
        }

        // yo im planting
        if (place)
        {
            for (int i = 0; i < 4; i++)
            {
                Vector2Int b = blocks[i];
                grid[fallPos.x + b.x, fallPos.y + (4 - b.y)] = fall.patternIndex + 1;
            }

            // line checking
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                bool solid = true;
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    if (grid[x, y] == 0)
                    {
                        solid = false;
                        break;
                    }
                }
                if (solid)
                {
                    for (int yy = y + 1; yy < grid.GetLength(1); yy++)
                    {
                        for (int xx = 0; xx < grid.GetLength(0); xx++)
                        {
                            grid[xx, yy - 1] = grid[xx, yy];
                        }
                    }
                    y--;
                    Debug.Log(y);
                }
            }

            Restock();
        }
        return canMove;
    }


    public bool InBlock(int x, int y, int xO, int yO)
    {
        return grid[
           Mathf.Clamp(fallPos.x + x + xO, 0, grid.GetLength(0) - 1),
           Mathf.Clamp(fallPos.y + (4 - y) + yO, 0, grid.GetLength(1) - 1)
       ] > 0;
    }



}

[Serializable]
public class Render
{
    public Transform quad;
    public Material background;
    public Texture2D texture;
    public Vector2Int queueOffset;
    [NonSerialized]
    public Color[] palette = new Color[]{
        new Color(0.2f, 0.2f, 0.2f),
        new Color(0.4f, 0.4f, 0.4f),
        new Color(0.6f, 0.6f, 0.6f),
        new Color(0.8f, 0.8f, 0.8f)

    };
    public void Start()
    {
        quad.localScale = new Vector3(16, 21, 1);
        texture = new Texture2D(16 * 8, 21 * 8);
        texture.filterMode = FilterMode.Point;
        texture.wrapMode = TextureWrapMode.Clamp;
        background.mainTexture = texture;
        // background.mainTextureScale = new Vector2(1, -1);
    }
    public void Update(Mono mono)
    {
        // clear texture
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                texture.SetPixel(x, y, palette[3]);
            }
        }

        // grid border
        for (int y = gridAnchor.y - 1; y < mono.grid.GetLength(1) * 8 + gridAnchor.y + 1; y++)
        {
            for (int x = gridAnchor.x - 1; x < mono.grid.GetLength(0) * 8 + gridAnchor.x + 1; x++)
            {
                texture.SetPixel(x, y, palette[0]);
            }
        }

        for (int y = gridAnchor.y; y < mono.grid.GetLength(1) * 8 + gridAnchor.y + 1; y++)
        {
            for (int x = gridAnchor.x; x < mono.grid.GetLength(0) * 8 + gridAnchor.x; x++)
            {
                texture.SetPixel(x, y, palette[3]);
            }
        }

        // render out grid
        for (int y = 0; y < mono.grid.GetLength(1); y++)
        {
            for (int x = 0; x < mono.grid.GetLength(0); x++)
            {
                if (mono.grid[x, y] > 0)
                {
                    Block(
                        mono,
                        x,
                        y, //(mono.grid.GetLength(1) - y),
                        mono.grid[x, y] - 1
                    );
                }
            }
        }

        // draw queue vertically on the right side
        for (int i = 0; i < mono.queue.Length; i++)
        {
            Mono.Tetromino t = mono.queue[i];
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (mono.og[t.ogIndex][t.oriIndex][y, x] == 1)
                    {
                        Square(
                            x + queueOffset.x,
                            (4 - y) + queueOffset.y - (i + 1) * 4 - i,
                            0
                        );

                    }
                }
            }
        }

        // render the falling tetromino
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if (mono.og[mono.fall.ogIndex][mono.fall.oriIndex][y, x] == 1)
                {
                    Block(
                        mono,
                        x + mono.fallPos.x,
                        (4 - y) + mono.fallPos.y,
                        mono.fall.patternIndex
                    );
                }
            }
        }
        texture.Apply();
    }
    Vector2Int gridAnchor = new Vector2Int(2, 2);
    void Block(Mono mono, int x, int y, int i)
    {
        for (int yy = 0; yy < 8; yy++)
        {
            for (int xx = 0; xx < 8; xx++)
            {
                texture.SetPixel(
                    (x * 8) + yy + gridAnchor.y,
                    (y * 8) + xx + gridAnchor.x,
                    palette[mono.pattern[i][(7 - xx), yy]]
                );
            }
        }
    }
    void Square(int y, int x, int i)
    {
        for (int yy = 0; yy < 4; yy++)
        {
            for (int xx = 0; xx < 4; xx++)
            {
                texture.SetPixel(
                    (y * 4) + yy,
                    (x * 4) + xx,
                    palette[i]
                );
            }
        }
    }
}
