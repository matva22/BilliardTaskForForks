﻿using System;

namespace Billiards
{
    public static class BilliardsTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionRadians">Угол направелния движения шара</param>
        /// <param name="wallInclinationRadians">Угол</param>
        /// <returns></returns>
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            double direction = (directionRadians * 180) / Math.PI;
            double wallInclination = (wallInclinationRadians * 180) / Math.PI;

            double wallAngle = 90 + wallInclination;
            double ballAngle = 180 + direction;

            double diff = wallAngle - ballAngle;
            double angle = ballAngle + 2 * diff + 360 * 5;

            angle %= 360;
            if (angle > 180)
            {
                angle -= 360;
            }

            return (angle * Math.PI) / 180;
        }
    }
}