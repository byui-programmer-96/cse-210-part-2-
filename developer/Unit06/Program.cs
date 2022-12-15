﻿namespace Namespace
{
    using System;
    using System.Collections.Generic;

    public static class Module {
        private static object WHITE;

        public static object KEY_W { get; private set; }
        public static object KEY_S { get; private set; }
        public static object BLACK { get; private set; }

        static Module() {
            InitWindow(1000, 800, new byte[] { (byte)'C', (byte)'Y', (byte)'C', (byte)'L', (byte)'E' });
            SetTargetFPS(60);
            main();
        }

        private static void SetTargetFPS(int v)
        {
            throw new NotImplementedException();
        }

        private static void InitWindow(int v1, int v2, byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public class Position {
            
            public Position(
                object Lx = 0,
                object Ly = 400,
                object Rx = 990,
                object Ry = 400,
                object Bx = 500,
                object By = 400,
                object scoreL = 0,
                object scoreR = 0) {
                this.Lx = Lx;
                this.Ly = Ly;
                this.Rx = Rx;
                this.Ry = Ry;
                this.Bx = Bx;
                this.By = By;
                this.scoreL = scoreL;
                this.scoreR = scoreR;
            }
        }
        
        public class Ball {
            
            public object ballXspeed = 5;
            
            public object ballYspeed = new List<object> {
                random.randint(-5, 5)
            };
        }
        
        public static object main() {
            Func<object> move_left = () => {
                if (IsKeyDown(KEY_W)) {
                    P.Ly -= 5;
                }
                if (IsKeyDown(KEY_S)) {
                    P.Ly += 5;
                }
            };
            Func<object> move_right = () => {
                if (IsKeyDown(KEY_UP)) {
                    P.Ry -= 5;
                }
                if (IsKeyDown(KEY_DOWN)) {
                    P.Ry += 5;
                }
            };
            var P = Position();
            var B = Ball();
            var moverx = B.ballXspeed;
            var movery = B.ballYspeed;
            var movey = movery[-1];
            var game_over = false;
            while (!WindowShouldClose()) {
                BeginDrawing();
                ClearBackground(WHITE);
                DrawFPS(900, 25);
                while (object.ReferenceEquals(game_over, false)) {
                    BeginDrawing();
                    ClearBackground(BLACK);
                    DrawFPS(900, 25);
                    move_left();
                    move_right();
                    P.Bx += moverx;
                    P.By += movey;
                    if (P.Bx == 980 && P.Ry <= P.By <= P.Ry + 100) {
                        moverx = -5;
                        movery.append(random.randint(-5, 5));
                    }
                    if (P.Bx == 10 && P.Ly <= P.By <= P.Ly + 100) {
                        moverx = 5;
                        movery.append(random.randint(-5, 5));
                    }
                    if (P.By >= 790 || P.By <= 10) {
                        movey = -movery[-1];
                        movery.append(random.randint(-5, 5));
                    }
                    if (P.Bx >= 1000) {
                        P.scoreL += 1;
                        Console.WriteLine("Left Score: {P.scoreL}");
                        P.Bx -= 500;
                    }
                    if (P.Bx <= 0) {
                        P.scoreR += 1;
                        Console.WriteLine("Right Score: {P.scoreR}");
                        P.Bx += 500;
                    }
                    if (P.scoreL == 5) {
                        game_over = true;
                    }
                    if (P.scoreR == 5) {
                        game_over = true;
                    }
                    DrawText("{P.scoreL} to {P.scoreR}".encode("ascii"), 425, 25, 50, VIOLET);
                    DrawRectangle(P.Lx, P.Ly, 10, 100, VIOLET);
                    DrawRectangle(P.Rx, P.Ry, 10, 100, VIOLET);
                    DrawCircle(P.Bx, P.By, 10, VIOLET);
                    EndDrawing();
                }
                DrawRectangle(P.Lx, P.Ly, 10, 100, VIOLET);
                DrawRectangle(P.Rx, P.Ry, 10, 100, VIOLET);
                DrawCircle(P.Bx, P.By, 10, VIOLET);
                DrawText("Good Game".encode("ascii"), 250, 300, 100, VIOLET);
                EndDrawing();
            }
            CloseWindow();
        }

        private static void EndDrawing()
        {
            throw new NotImplementedException();
        }

        private static void DrawFPS(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private static void ClearBackground(object wHITE)
        {
            throw new NotImplementedException();
        }

        private static void BeginDrawing()
        {
            throw new NotImplementedException();
        }

        private static bool WindowShouldClose()
        {
            throw new NotImplementedException();
        }

        private static object Ball()
        {
            throw new NotImplementedException();
        }

        private static object Position()
        {
            throw new NotImplementedException();
        }

        private static bool IsKeyDown(object kEY_S)
        {
            throw new NotImplementedException();
        }
    }

    internal class random
    {
        internal static object randint(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
