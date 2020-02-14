using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSamePicture
{
    class Game
    {
        int[,] pan = new int[4, 4];
        Boolean[,] GameState = new Boolean[4, 4];

        public Game(Boolean isCPU)
        {
            for (int i=0;i<4;i++)
            {
                for(int j=0; j<4; j++)
                {
                    pan[i, j] = 5;
                    GameState[i, j] = false;
                }
            }
            Random r = new Random();

            int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0, n7 = 0, n8=0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int x = r.Next(0, 8);

                    if (x == 0 && n1 == 2) { j--; continue; }
                    else if (x == 1 && n2 == 2) { j--; continue; }
                    else if (x == 2 && n3 == 2) { j--; continue; }
                    else if (x == 3 && n4 == 2) { j--; continue; }
                    else if (x == 4 && n5 == 2) { j--; continue; }
                    else if (x == 5 && n6 == 2) { j--; continue; }
                    else if (x == 6 && n7 == 2) { j--; continue; }
                    else if (x == 7 && n8 == 2) { j--; continue; }

                    pan[i, j] = x;

                    switch(x)
                    {
                        case 0:
                            n1++;
                            break;
                        case 1:
                            n2++;
                            break;
                        case 2:
                            n3++;
                            break;
                        case 3:
                            n4++;
                            break;
                        case 4:
                            n5++;
                            break;
                        case 5:
                            n6++;
                            break;
                        case 6:
                            n7++;
                            break;
                        case 7:
                            n8++;
                            break;
                    }
                }
            }
        }

        //게임 종료 확인
        public Boolean isEnd()
        {
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    if (!GameState[i, j]) return false;
                }
            }

            return true;
        }

        //버튼 누르기
        public int doClick(int x, int y)
        {
            if (!GameState[x, y])
            {
                return pan[x, y];
            }
            return 999;
        }

        public int isCorrect(int x1, int y1, int x2, int y2)
        {
            if(!GameState[x2,y2] && pan[x1,y1] == pan[x2,y2])
            {
                GameState[x1, y1] = true;
                GameState[x2, y2] = true;
                return pan[x2, y2];
            }
            return pan[x2,y2] + 999;
        }
        
        public int getBtnType(int x, int y)
        {
            return pan[x, y];
        }
    }
}
