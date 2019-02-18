﻿using System;

using Towel;
using Towel.Structures;
using Towel.Mathematics;
using Towel.Measurements;

using static Towel.Mathematics.Compute;
using System.Linq.Expressions;

namespace Mathematics
{
    class Program
    {
        // Gets randomized values
        public static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("You are runnning the Mathematics example.");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("  The Towel.Mathemeatics.Compute class allows generic mathematics (you can use any type). :)");
            Console.WriteLine();

            #region Basic Operations

            Console.WriteLine("  Basics----------------------------------------------");
            Console.WriteLine();

            // Negation
            Console.WriteLine("    Negate(7): " + Negate(7));
            // Addition
            Console.WriteLine("    Add(7, 7): " + Add((decimal)7, (decimal)7));
            // Subtraction
            Console.WriteLine("    Subtract(14, 7): " + Subtract((float)14, (float)7));
            // Multiplication
            Console.WriteLine("    Multiply(7, 7): " + Multiply((long)7, (long)7));
            // Division
            Console.WriteLine("    Divide(14, 7): " + Divide((short)14, (short)7));
            // Absolute Value
            Console.WriteLine("    AbsoluteValue(-7): " + AbsoluteValue((double)-7));
            // Clamp
            Console.WriteLine("    Clamp(-123, 7, 14): " + Clamp((Fraction32)(-123), (Fraction32)7, (Fraction32)14));
            // Maximum
            Console.WriteLine("    Maximum(1, 2, 3): " + Maximum((Step<byte> step) => { step((byte)1); step((byte)2); step((byte)3); }));
            // Minimum
            Console.WriteLine("    Minimum(1, 2, 3): " + Minimum((Step<int> step) => { step(1); step(2); step(3); }));
            // Less Than
            Console.WriteLine("    LessThan(1, 2): " + LessThan((Fraction128)1, (Fraction128)2));
            // Greater Than
            Console.WriteLine("    GreaterThan(1, 2): " + GreaterThan((Fraction64)1, (Fraction64)2));
            // Compare
            Console.WriteLine("    Compare(7, 7): " + Compare((Fraction32)7, (Fraction32)7));
            // Equate
            Console.WriteLine("    Equate(7, 6): " + Equal(7, 6));
            // EqualsLeniency
            Console.WriteLine("    EqualsLeniency(2, 1, 1): " + EqualLeniency(2, 1, 1));
            Console.WriteLine();

            #endregion

            #region Number Theory

            Console.WriteLine("  Number Theory--------------------------------------");
            Console.WriteLine();

            // Prime Checking
            int prime_check = random.Next(0, 100000);
            Console.WriteLine("    IsPrime(" + prime_check + "): " + IsPrime(prime_check));

            // GCF Checking
            int[] gcf = new int[] { random.Next(0, 500) * 2, random.Next(0, 500) * 2, random.Next(0, 500) * 2 };
            Console.WriteLine("    GCF(" + gcf[0] + ", " + gcf[1] + ", " + gcf[2] + "): " + GreatestCommonFactor(gcf.Stepper()));

            // LCM Checking
            int[] lcm = new int[] { random.Next(0, 500) * 2, random.Next(0, 500) * 2, random.Next(0, 500) * 2 };
            Console.WriteLine("    LCM(" + lcm[0] + ", " + lcm[1] + ", " + lcm[2] + "): " + LeastCommonMultiple(lcm.Stepper()));
            Console.WriteLine();

            #endregion

            #region Range

            Console.WriteLine("  Range---------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("   1D int");

            {
                Range<int> range1 = new Range<int>(1, 7);
                Console.WriteLine("    range1: " + range1);
                Range<int> range2 = new Range<int>(4, 10);
                Console.WriteLine("    range2: " + range2);
                Range<int>[] range3 = range1 ^ range2;
                Console.WriteLine("    range1 ^ range2 (Complement): " + range3[0]);
                Range<int>[] range4 = range1 | range2;
                Console.WriteLine("    range1 | range2 (Union): " + range4[0]);
                Range<int> range5 = range1 & range2;
                Console.WriteLine("    range1 & range2 (Intersection): " + range5);
            }

            Console.WriteLine();

            #endregion

            #region Angles

            Console.WriteLine("  Angles--------------------------------------");
            Console.WriteLine();
            Angle<double> angle1 = Angle<double>.Factory_Degrees(90d);
            Console.WriteLine("    angle1 = " + angle1);
            Angle<double> angle2 = Angle<double>.Factory_Turns(0.5d);
            Console.WriteLine("    angle2 = " + angle2);
            Console.WriteLine("    angle1 + angle2 = " + (angle1 + angle2));
            Console.WriteLine("    angle2 - angle1 = " + (angle1 + angle2));
            Console.WriteLine("    angle1 * 2 = " + (angle1 * 2));
            Console.WriteLine("    angle1 / 2 = " + (angle1 / 2));
            Console.WriteLine("    angle1 > angle2 = " + (angle1 > angle2));
            Console.WriteLine("    angle1 == angle2 = " + (angle1 == angle2));
            Console.WriteLine("    angle1 * 2 == angle2 = " + (angle1 * 2 == angle2));
            Console.WriteLine("    angle1 != angle2 = " + (angle1 != angle2));
            Console.WriteLine();

            // examples of non-doubles
            Angle<float> angle10 = Angle<float>.Factory_Degrees(90f);
            Angle<Fraction128> angle11 = Angle<Fraction128>.Factory_Degrees(new Fraction128("90/1"));
            Angle<decimal> angle12 = Angle<decimal>.Factory_Degrees(90m);

            #endregion

            #region Fraction

            //Console.WriteLine("  Fractions-----------------------------------");
            //Console.WriteLine();
            //Fraction128 fraction1 = new Fraction128(2.5);
            //Console.WriteLine("    fraction1 = " + fraction1);
            //Fraction128 fraction2 = new Fraction128(3.75);
            //Console.WriteLine("    fraction2 = " + fraction2);
            //Console.WriteLine("    fraction1 + fraction2 = " + fraction1 + fraction2);
            //Console.WriteLine("    fraction2 - fraction1 = " + fraction1 + fraction2);
            //Console.WriteLine("    fraction1 * 2 = " + fraction1 * 2);
            //Console.WriteLine("    fraction1 / 2 = " + fraction1 / 2);
            //Console.WriteLine("    fraction1 > fraction2 = " + (fraction1 > fraction2));
            //Console.WriteLine("    fraction1 == fraction2 = " + (fraction1 == fraction2));
            //Console.WriteLine("    fraction1 * 2 == fraction2 = " + (fraction1 * 2 == fraction2));
            //Console.WriteLine("    fraction1 != fraction2 = " + (fraction1 != fraction2));
            //Console.WriteLine();

            #endregion

            #region Trigonometry

            Console.WriteLine("  Trigonometry -----------------------------------------");
            Console.WriteLine();

            Angle<double> testingAngle = Angle<double>.Factory_Degrees(90d);

            Console.WriteLine("    Sin(90degrees) = " + Sine(testingAngle));

            #endregion

            #region Statistics

            Console.WriteLine("  Statistics-----------------------------------------");
            Console.WriteLine();

            // Makin some random data...
            double mode_temp = random.NextDouble() * 100;

            double[] statistics_data = new double[random.Next(5, 7)];
            for (int i = 0; i < statistics_data.Length; i++)
            {
                if (i == 1 || i == statistics_data.Length - 1)
                {
                    statistics_data[i] = mode_temp;
                }
                else
                {
                    statistics_data[i] = random.NextDouble() * 100;
                }
            }

            // Print the data to the console...
            string stat_data_string = "    data: [" + string.Format("{0:0.00}", statistics_data[0]);
            for (int i = 1; i < statistics_data.Length; i++)
            {
                stat_data_string += ", " + string.Format("{0:0.00}", statistics_data[i]);
            }
            stat_data_string += "]";
            Console.WriteLine(stat_data_string);
            Console.WriteLine();

            // Mean
            Console.WriteLine("    Mean(data): " + string.Format("{0:0.00}", Mean(statistics_data.Stepper())));

            // Median
            Console.WriteLine("    Median(data): " + string.Format("{0:0.00}", Median(statistics_data.Stepper())));

            // Mode
            Console.WriteLine("    Mode(data): ");
            Heap<Link<double, int>> modes = Mode(statistics_data.Stepper());
            while (modes.Count > 0)
            {
                Link<double, int> link = modes.Dequeue();
                Console.WriteLine("      Point: " + string.Format("{0:0.00}", link._1) + " Occurences: " + link._2);
            }
            Console.WriteLine();

            // Geometric Mean
            Console.WriteLine("    Geometric Mean(data): " + string.Format("{0:0.00}", GeometricMean(statistics_data.Stepper())));

            // Range
            Range<double> range = Range(statistics_data.Stepper());
            Console.WriteLine("    Range(data): " + string.Format("{0:0.00}", range.Min) + "-" + string.Format("{0:0.00}", range.Max));

            // Variance
            Console.WriteLine("    Variance(data): " + string.Format("{0:0.00}", Variance(statistics_data.Stepper())));

            // Standard Deviation
            Console.WriteLine("    Standard Deviation(data): " + string.Format("{0:0.00}", StandardDeviation(statistics_data.Stepper())));

            // Mean Deviation
            Console.WriteLine("    Mean Deviation(data): " + string.Format("{0:0.00}", MeanDeviation(statistics_data.Stepper())));
            Console.WriteLine();

            // Quantiles
            //double[] quatiles = Statistics<double>.Quantiles(4, statistics_data.Stepper());
            //Console.Write("    Quartiles(data):");
            //foreach (double i in quatiles)
            //	Console.Write(string.Format(" {0:0.00}", i));
            //Console.WriteLine();
            //Console.WriteLine();

            #endregion

            #region Algebra

            Console.WriteLine("  Algebra---------------------------------------------");
            Console.WriteLine();

            // Prime Factorization
            int prime_factors = random.Next(0, 100000);
            Console.Write("    Prime Factors(" + prime_factors + "): ");
            FactorPrimes(prime_factors, (int i) => { Console.Write(i + " "); });
            Console.WriteLine();
            Console.WriteLine();

            // Logarithms
            int log_1 = random.Next(0, 11), log_2 = random.Next(0, 100000);
            Console.WriteLine("    log_" + log_1 + "(" + log_2 + "): " + string.Format("{0:0.00}", Logarithm((double)log_1, (double)log_2)));
            Console.WriteLine();

            // Summation
            double[] summation_values = new double[]
            {
                random.NextDouble(),
                random.NextDouble(),
                random.NextDouble(),
                random.NextDouble(),
            };
            double summation = Add(summation_values.Stepper());
            Console.Write("    Σ (" + string.Format("{0:0.00}", summation_values[0]));
            for (int i = 1; i < summation_values.Length; i++)
                Console.Write(", " + string.Format("{0:0.00}", summation_values[i]));
            Console.WriteLine(") = " + string.Format("{0:0.00}", summation));
            Console.WriteLine();

            #endregion

            #region Combinatorics

            Console.WriteLine("  Combinatorics--------------------------------------");
            Console.WriteLine();

            // Factorials
            Console.WriteLine("    7!: " + Factorial(7));
            Console.WriteLine();

            // Combinations
            Console.WriteLine("    7! / (3! * 4!): " + Combinations(7, new int[] { 3, 4 }));
            Console.WriteLine();

            // Choose
            Console.WriteLine("    7 choose 2: " + Choose(7, 2));
            Console.WriteLine();

            #endregion

            #region Linear Algebra

            Console.WriteLine("  Linear Algebra------------------------------------");
            Console.WriteLine();

            // Vector Construction
            Vector<double> V = new double[]
            {
                random.NextDouble(),
                random.NextDouble(),
                random.NextDouble(),
                random.NextDouble(),
            };

            Console.WriteLine("    Vector<double> V: ");
            ConsoleWrite(V);

            Console.WriteLine("    Normalize(V): ");
            ConsoleWrite(V.Normalize());

            // Vctor Negation
            Console.WriteLine("    -V: ");
            ConsoleWrite(-V);

            // Vector Addition
            Console.WriteLine("    V + V (aka 2V): ");
            ConsoleWrite(V + V);

            // Vector Multiplication
            Console.WriteLine("    V * 2: ");
            ConsoleWrite(V * 2);

            // Vector Division
            Console.WriteLine("    V / 2: ");
            ConsoleWrite(V / 2);

            // Vector Dot Product
            Console.WriteLine("    V dot V: " + Vector<double>.DotProduct(V, V));
            Console.WriteLine();

            // Vector Cross Product
            Vector<double> V3 = new double[]
            {
                random.NextDouble(),
                random.NextDouble(),
                random.NextDouble(),
            };

            Console.WriteLine("    Vector<double> V3: ");
            ConsoleWrite(V3);
            Console.WriteLine("    V3 cross V3: ");
            ConsoleWrite(Vector<double>.CrossProduct(V3, V3));

            // Matrix Construction
            Matrix<double> M = (Matrix<double>)new double[,]
            {
                { random.NextDouble(), random.NextDouble(), random.NextDouble(), random.NextDouble() },
                { random.NextDouble(), random.NextDouble(), random.NextDouble(), random.NextDouble() },
                { random.NextDouble(), random.NextDouble(), random.NextDouble(), random.NextDouble() },
                { random.NextDouble(), random.NextDouble(), random.NextDouble(), random.NextDouble() },
            };

            Console.WriteLine("    Matrix<double>.Identity(4, 4): ");
            ConsoleWrite(Matrix<double>.FactoryIdentity(4, 4));

            Console.WriteLine("    Matrix<double> M: ");
            ConsoleWrite(M);

            // Matrix Negation
            Console.WriteLine("    -M: ");
            ConsoleWrite(-M);

            // Matrix Addition
            Console.WriteLine("    M + M (aka 2M): ");
            ConsoleWrite(M + M);

            // Matrix Subtraction
            Console.WriteLine("    M - M: ");
            ConsoleWrite(M - M);

            // Matrix Multiplication
            Console.WriteLine("    M * M (aka M ^ 2): ");
            ConsoleWrite(M * M);

            // If you have a large matrix that you want to multi-thread the multiplication,
            // use the function: "LinearAlgebra.Multiply_parallel". This function will
            // automatically parrallel the multiplication to the number of cores on your
            // personal computer.

            // Matrix Power
            Console.WriteLine("    M ^ 3: ");
            ConsoleWrite(M ^ 3);

            // Matrix Multiplication
            Console.WriteLine("    minor(M, 1, 1): ");
            ConsoleWrite(M.Minor(1, 1));

            // Matrix Reduced Row Echelon
            Console.WriteLine("    rref(M): ");
            ConsoleWrite(Matrix<double>.ReducedEchelon(M));

            // Matrix Determinant
            Console.WriteLine("    determinent(M): " + string.Format("{0:0.00}", Matrix<double>.Determinent(M)));
            Console.WriteLine();

            // Matrix-Vector Multiplication
            Console.WriteLine("    M * V: ");
            ConsoleWrite(M * V);

            // Matrix Lower-Upper Decomposition
            Matrix<double> l, u;
            Matrix<double>.DecomposeLU(M, out l, out u);
            Console.WriteLine("    Lower-Upper Decomposition:");
            Console.WriteLine();
            Console.WriteLine("    	lower(M):");
            ConsoleWrite(l);
            Console.WriteLine("    	upper(M):");
            ConsoleWrite(u);

            // Quaternion Construction
            Quaternion<double> Q = new Quaternion<double>(
                random.NextDouble(),
                random.NextDouble(),
                random.NextDouble(),
                1.0d);

            Console.WriteLine("    Quaternion<double> Q: ");
            ConsoleWrite(Q);

            // Quaternion Addition
            Console.WriteLine("    Q + Q (aka 2Q):");
            ConsoleWrite(Q + Q);

            // Quaternion-Vector Rotation
            Console.WriteLine("    Q * V3 * Q':");
            // Note: the vector should be normalized on the 4th component 
            // for a proper rotation. (I did not do that)
            ConsoleWrite(V3.RotateBy(Q));

            #endregion

            #region Convex Optimization

            //Console.WriteLine("  Convex Optimization-----------------------------------");
            //Console.WriteLine();

            //double[,] tableau = new double[,]
            //{																	
            //	{ 0.0, -0.5, -3.0, -1.0, -4.0, },
            //	{ 40.0, 1.0, 1.0, 1.0, 1.0, },
            //	{ 10.0, -2.0, -1.0, 1.0, 1.0, },
            //	{ 10.0, 0.0, 1.0, 0.0, -1.0, },
            //};

            //Console.WriteLine("    tableau (double): ");
            //ConsoleWrite(tableau); Console.WriteLine();

            //Vector<double> simplex_result = LinearAlgebra.Simplex(ref tableau);

            //Console.WriteLine("    simplex(tableau): ");
            //ConsoleWrite(tableau); Console.WriteLine();

            //Console.WriteLine("    resulting maximization: ");
            //ConsoleWrite(simplex_result);

            #endregion

            #region Symbolics

            Console.WriteLine("  Symbolics---------------------------------------");
            Console.WriteLine();

            Expression<Func<double, double>> expression1 = (x) => 2 * (x / 7);
            var syntax1 = Symbolics<double>.Parse(expression1);
            Console.WriteLine("    Expression 1: " + syntax1);
            Console.WriteLine("      Simplified: " + syntax1.Simplify());
            Console.WriteLine("      Plugin(5): " + syntax1.Assign("x", 5).Simplify());

            Expression<Func<double, double>> expression2 = (x) => 2 * x / 7;
            var syntax2 = Symbolics<double>.Parse(expression2);
            Console.WriteLine("    Expression 2: " + syntax2);
            Console.WriteLine("      Simplified: " + syntax2.Simplify());
            Console.WriteLine("      Plugin(5): " + syntax2.Assign("x", 5).Simplify());

            Expression<Func<double, double>> expression3 = (x) => 2 - x + 7;
            var syntax3 = Symbolics<double>.Parse(expression3);
            Console.WriteLine("    Expression 3: " + syntax3);
            Console.WriteLine("      Simplified: " + syntax3.Simplify());
            Console.WriteLine("      Plugin(5): " + syntax3.Assign("x", 5).Simplify());

            Expression<Func<double, double>> expression4 = (x) => 2 + (x - 7);
            var syntax4 = Symbolics<double>.Parse(expression4);
            Console.WriteLine("    Expression 4: " + syntax4);
            Console.WriteLine("      Simplified: " + syntax4.Simplify());
            Console.WriteLine("      Plugin(5): " + syntax4.Assign("x", 5).Simplify());

            Expression<Func<double, double, double, double>> expression5 = (x, y, z) => Compute.Power(x, 3) + 2 * x * y * Compute.Power(z, 2) - y * z + 1;
            var syntax5 = Symbolics<double>.Parse(expression5);
            Console.WriteLine("    Expression 5: " + syntax5);
            Console.WriteLine("      Simplified: " + syntax5.Simplify());
            Console.WriteLine("      Plugin(x = 5): " + syntax5.Assign("x", 5).Simplify());

            #endregion

            var test = Symbolics<double>.Parse("less(5, 10)");
            Console.WriteLine();
            Console.WriteLine("    Parse (string) Test: " + test);

            var test2 = Symbolics<double>.Parse("less(add(5, 10), 10)");
            Console.WriteLine();
            Console.WriteLine("    Parse (string) Test: " + test2);
            Console.WriteLine("    Parse (string) Test Simplify: " + test2.Simplify());

            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Example Complete...");
            Console.ReadLine();
        }

        #region Output Helpers

        public static void ConsoleWrite(Quaternion<double> quaternion)
        {
            Console.WriteLine(
                "      [ x " +
                string.Format("{0:0.00}", quaternion.X) + ", y " +
                string.Format("{0:0.00}", quaternion.Y) + ", z " +
                string.Format("{0:0.00}", quaternion.Z) + ", w " +
                string.Format("{0:0.00}", quaternion.W) + " ]");
            Console.WriteLine();
        }

        public static void ConsoleWrite(Vector<double> vector)
        {
            Console.Write("      [ ");
            for (int i = 0; i < vector.Dimensions - 1; i++)
                Console.Write(string.Format("{0:0.00}", vector[i]) + ", ");
            Console.WriteLine(string.Format("{0:0.00}", vector[vector.Dimensions - 1] + " ]"));
            Console.WriteLine();
        }

        public static void ConsoleWrite(Matrix<double> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                Console.Write("      [ ");
                for (int j = 0; j < matrix.Columns; j++)
                    Console.Write(string.Format("{0:0.00}", matrix[i, j]) + " ");
                Console.WriteLine("]");
            }
            Console.WriteLine();
        }

        #endregion
    }
}