using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_graphics
{
    class Transformation
    {
        public static double[] RotateVectorX(double[] vector, double alpha)
        {
            double[][] RotateXMatrix = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                RotateXMatrix[i] = new double[4];
            }
            RotateXMatrix[0][0] = 1; RotateXMatrix[1][0] = 0; RotateXMatrix[2][0] = 0; RotateXMatrix[3][0] = 0;
            RotateXMatrix[0][1] = 0; RotateXMatrix[1][1] = Math.Cos(alpha); RotateXMatrix[2][1] = Math.Sin(alpha); RotateXMatrix[3][1] = 0;
            RotateXMatrix[0][2] = 0; RotateXMatrix[1][2] = -Math.Sin(alpha); RotateXMatrix[2][2] = Math.Cos(alpha); RotateXMatrix[3][2] = 0;
            RotateXMatrix[0][3] = 0; RotateXMatrix[1][3] = 0; RotateXMatrix[2][3] = 0; RotateXMatrix[3][3] = 1;

            return MultiplicationMatrixOnVector(vector, RotateXMatrix);
        }

        public static double[] RotateVectorY(double[] vector, double alpha)
        {
            double[][] RotateYMatrix = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                RotateYMatrix[i] = new double[4];
            }
            RotateYMatrix[0][0] = Math.Cos(alpha); RotateYMatrix[1][0] = 0; RotateYMatrix[2][0] = Math.Sin(alpha); RotateYMatrix[3][0] = 0;
            RotateYMatrix[0][1] = 0; RotateYMatrix[1][1] = 1; RotateYMatrix[2][1] = 0; RotateYMatrix[3][1] = 0;
            RotateYMatrix[0][2] = -Math.Sin(alpha); RotateYMatrix[1][2] = 0; RotateYMatrix[2][2] = Math.Cos(alpha); RotateYMatrix[3][2] = 0;
            RotateYMatrix[0][3] = 0; RotateYMatrix[1][3] = 0; RotateYMatrix[2][3] = 0; RotateYMatrix[3][3] = 1;

             return MultiplicationMatrixOnVector(vector, RotateYMatrix);
        }

        public static double[] RotateVectorZ(double[] vector, double alpha)
        {
            double[][] RotateZMatrix = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                RotateZMatrix[i] = new double[4];
            }
            RotateZMatrix[0][0] = Math.Cos(alpha); RotateZMatrix[1][0] = -Math.Sin(alpha); RotateZMatrix[2][0] = 0; RotateZMatrix[3][0] = 0;
            RotateZMatrix[0][1] = Math.Sin(alpha); RotateZMatrix[1][1] = Math.Cos(alpha); RotateZMatrix[2][1] = 0; RotateZMatrix[3][1] = 0;
            RotateZMatrix[0][2] = 0; RotateZMatrix[1][2] = 0; RotateZMatrix[2][2] = 1; RotateZMatrix[3][2] = 0;
            RotateZMatrix[0][3] = 0; RotateZMatrix[1][3] = 0; RotateZMatrix[2][3] = 0; RotateZMatrix[3][3] = 1;

            return MultiplicationMatrixOnVector(vector, RotateZMatrix);
        }

        public static double[] RotateVecrorXYZ(double[] vector, double alpha)
        {
            double[][] RotateZMatrix = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                RotateZMatrix[i] = new double[4];
            }
            RotateZMatrix[0][0] = Math.Cos(alpha) * Math.Cos(alpha); RotateZMatrix[1][0] = Math.Sin(alpha)* Math.Cos(alpha); RotateZMatrix[2][0] = -Math.Sin(alpha); RotateZMatrix[3][0] = 0;
            RotateZMatrix[0][1] = Math.Sin(alpha) * Math.Sin(alpha) * Math.Cos(alpha) - Math.Cos(alpha) * Math.Sin(alpha); RotateZMatrix[1][1] = Math.Sin(alpha) * Math.Sin(alpha) * Math.Sin(alpha) + Math.Cos(alpha) * Math.Cos(alpha); RotateZMatrix[2][1] = Math.Sin(alpha)* Math.Cos(alpha); RotateZMatrix[3][1] = 0;
            RotateZMatrix[0][2] = Math.Cos(alpha) * Math.Sin(alpha) * Math.Cos(alpha) + Math.Sin(alpha) * Math.Sin(alpha); RotateZMatrix[1][2] = Math.Cos(alpha) * Math.Sin(alpha) * Math.Sin(alpha) - Math.Sin(alpha) * Math.Cos(alpha); RotateZMatrix[2][2] = Math.Cos(alpha)* Math.Cos(alpha); RotateZMatrix[3][2] = 0;
            RotateZMatrix[0][3] = 0; RotateZMatrix[1][3] = 0; RotateZMatrix[2][3] = 0; RotateZMatrix[3][3] = 1;

            return MultiplicationMatrixOnVector(vector, RotateZMatrix);
        }

        public static double[] TransferVector(double[] vector, double[]TransVector)
        {
            double[][] TranferMatrix = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                TranferMatrix[i] = new double[4];
            }
            TranferMatrix[0][0] = 1; TranferMatrix[1][0] = 0; TranferMatrix[2][0] = 0; TranferMatrix[3][0] = 0;
            TranferMatrix[0][1] = 0; TranferMatrix[1][1] = 1; TranferMatrix[2][1] = 0; TranferMatrix[3][1] = 0;
            TranferMatrix[0][2] = 0; TranferMatrix[1][2] = 0; TranferMatrix[2][2] = 1; TranferMatrix[3][2] = 0;
            TranferMatrix[0][3] = TransVector[0]; TranferMatrix[1][3] = TransVector[1]; TranferMatrix[2][3] = TransVector[2]; TranferMatrix[3][3] = 1;

            return MultiplicationMatrixOnVector(vector, TranferMatrix);
        }

        public static double[] ReflectionVector(double[] vector)
        {
            double[][] ReflectionMatrix = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                ReflectionMatrix[i] = new double[4];
            }
            ReflectionMatrix[0][0] =-1; ReflectionMatrix[1][0] = 0; ReflectionMatrix[2][0] = 0; ReflectionMatrix[3][0] = 0;
            ReflectionMatrix[0][1] = 0; ReflectionMatrix[1][1] = 1; ReflectionMatrix[2][1] = 0; ReflectionMatrix[3][1] = 0;
            ReflectionMatrix[0][2] = 0; ReflectionMatrix[1][2] = 0; ReflectionMatrix[2][2] = 1; ReflectionMatrix[3][2] = 0;
            ReflectionMatrix[0][3] = 0; ReflectionMatrix[1][3] = 0; ReflectionMatrix[2][3] = 0; ReflectionMatrix[3][3] = 1;

            return MultiplicationMatrixOnVector(vector, ReflectionMatrix);
        }

        private static double[] MultiplicationMatrixOnVector(double[] vector, double[][] marix)
        {
            double[] NewVecror = new double[vector.Length];

            for (int i = 0; i < NewVecror.Length; i++)
            {
                NewVecror[i] = 0;
                for (int j = 0; j < NewVecror.Length; j++)
                {
                    NewVecror[i] += marix[i][j] * vector[j];
                }
            }
            return NewVecror;
        }

    }
    
}
