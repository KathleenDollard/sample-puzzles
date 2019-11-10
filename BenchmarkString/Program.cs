using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis;
using System;
using System.Text;

namespace BenchmarkString
{
    // Puzzle:
    // 1. Will StringBuilder (not "Ten") variations use the same memory?
    //    - If not, rank by memory usage

    // 2. Rank memory usage of SingleLine, Multiline and your favorite string builder

    // 3. Compare memory usage of (iow, is the second ten times the usage of the first)
    //    - SingleLine vs SingleLineTen
    //    - MultiLine vs MultiLineTen
    //    - StringBulderDefault vs StringBulderDefaultTen


    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }

    [ShortRunJob]
    [CsvExporter]
    [MemoryDiagnoser]
    public class StringBenchmarks
    {
        private readonly string A = "Two ";
        private readonly string B = "roads ";
        private readonly string C = "diverged ";
        private readonly string D = "in a ";
        private readonly string E = "wood, ";
        private readonly string F = "and ";
        private readonly string G = "I ";
        private readonly string H = "took ";
        private readonly string I = "the one ";
        private readonly string J = "less traveled by;";
        private readonly string K = "And that has made all the difference";

        private void AddText(StringBuilder sb)
        {
            sb.Append(A);
            sb.Append(B);
            sb.Append(C);
            sb.Append(D);
            sb.Append(E);
            sb.Append(F);
            sb.Append(G);
            sb.Append(H);
            sb.Append(I);
            sb.Append(J);
            sb.Append(K);
        }

        internal string AddText(string x)
        {
            x += A;
            x += B;
            x += C;
            x += D;
            x += E;
            x += F;
            x += G;
            x += H;
            x += I;
            x += J;
            x += K;
            return x;
        }

        [Benchmark]
        public string StringBuilderDefault()
        {
            var sb = new StringBuilder();
            AddText(sb);
            return sb.ToString();
        }

        [Benchmark]
        public string StringBuilderSized()
        {
            var sb = new StringBuilder(110);
            AddText(sb);
            return sb.ToString();
        }

        [Benchmark]
        public string StringBuilderOverSized()
        {
            var sb = new StringBuilder(4096);
            AddText(sb);
            return sb.ToString();
        }

        [Benchmark]
        public string SingleLine()
            => A + B + C + D + E + F + G + H + I + J + K;

        [Benchmark]
        public string MultiLine()
        {
            var x = "";
            x = AddText(x);
            return x;
        }


        [Benchmark]
        public string SingleLineTen()
            => A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K +
               A + B + C + D + E + F + G + H + I + J + K;

        [Benchmark]
        public string MultiLineTen()
        {
            var x = "";
            for (int i = 0; i < 10; i++)
            {
                x = AddText(x);
            }

            return x;
        }

        [Benchmark]
        public string StringBuilderDefaultTen()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                AddText(sb);
            }
            return sb.ToString();
        }
    }
}
