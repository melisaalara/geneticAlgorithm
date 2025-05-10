using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GenetikAlgoritma
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        double[,] populasyon;
        int populasyonBoyutu, jenerasyonSayisi;
        double caprazlamaOrani, mutasyonOrani, seckinlikOrani;
        const double altSinir = -5.12, ustSinir = 5.12; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
                populasyonBoyutu = int.Parse(txtPopulasyon.Text);
                jenerasyonSayisi = int.Parse(txtGenerations.Text);
                caprazlamaOrani = double.Parse(txtCrossover.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                mutasyonOrani = double.Parse(txtMutation.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                seckinlikOrani = double.Parse(textBox1.Text.Replace(",", "."), CultureInfo.InvariantCulture);

                populasyon = BaslangicPopulasyonuOlustur();
                double[] enIyiFitnessDegerleri = new double[jenerasyonSayisi];

                for (int jenerasyon = 0; jenerasyon < jenerasyonSayisi; jenerasyon++)
                {
                    double[] fitnessDegerleri = FitnessHesapla(populasyon);
                    int enIyiIndex = Array.IndexOf(fitnessDegerleri, fitnessDegerleri.Min());
                    enIyiFitnessDegerleri[jenerasyon] = fitnessDegerleri[enIyiIndex];

                    lblBestSolution.Text = $"En İyi Çözüm: x={populasyon[enIyiIndex, 0]:F4}, " +
                                           $"y={populasyon[enIyiIndex, 1]:F4}, " +
                                           $"f(x)={fitnessDegerleri[enIyiIndex]:F6}";

                    populasyon = YeniNesilUret(populasyon, fitnessDegerleri);
                }

                GrafikCiz(enIyiFitnessDegerleri);
           
        }

        private double[,] BaslangicPopulasyonuOlustur()
        {
            double[,] pop = new double[populasyonBoyutu, 2];
            for (int i = 0; i < populasyonBoyutu; i++)
            {
                pop[i, 0] = random.NextDouble() * (ustSinir - altSinir) + altSinir;
                pop[i, 1] = random.NextDouble() * (ustSinir - altSinir) + altSinir;
            }
            return pop;
        }

        private double[] FitnessHesapla(double[,] pop)
        {
            double[] fitnessDegerleri = new double[populasyonBoyutu];
            for (int i = 0; i < populasyonBoyutu; i++)
            {
                fitnessDegerleri[i] = Math.Pow(pop[i, 0], 2) + Math.Pow(pop[i, 1], 2);
            }
            return fitnessDegerleri;
        }

        private double[,] YeniNesilUret(double[,] pop, double[] fitnessDegerleri)
        {
            double[,] yeniPop = new double[populasyonBoyutu, 2];

            int elitSayisi = (int)(populasyonBoyutu * seckinlikOrani);
            elitSayisi = Math.Min(elitSayisi, populasyonBoyutu);

            int[] siraliIndexler = Enumerable.Range(0, populasyonBoyutu)
                                             .OrderBy(i => fitnessDegerleri[i])
                                             .ToArray();
            for (int i = 0; i < elitSayisi; i++)
            {
                yeniPop[i, 0] = pop[siraliIndexler[i], 0];
                yeniPop[i, 1] = pop[siraliIndexler[i], 1];
            }

            for (int i = elitSayisi; i < populasyonBoyutu; i++)
            {
                double[] parent1 = TurnuvaSecimi(pop, fitnessDegerleri);
                double[] parent2 = TurnuvaSecimi(pop, fitnessDegerleri);

                (double child1, double child2) = Caprazlama(parent1[0], parent2[0]);
                (double child3, double child4) = Caprazlama(parent1[1], parent2[1]);

                yeniPop[i, 0] = Mutasyon(child1);
                yeniPop[i, 1] = Mutasyon(child3);
            }

            return yeniPop;
        }

        private (double, double) Caprazlama(double parent1, double parent2)
        {
            if (random.NextDouble() < caprazlamaOrani)
            {
                double alfa = random.NextDouble();
                double child1 = alfa * parent1 + (1 - alfa) * parent2;
                double child2 = alfa * parent2 + (1 - alfa) * parent1;
                return (child1, child2);
            }
            else
            {
                return (parent1, parent2); 
            }
        }

        private double Mutasyon(double deger)
        {
            if (random.NextDouble() < mutasyonOrani)
            {
                deger += (random.NextDouble() * 0.2) - 0.1;
            }
            return Math.Max(altSinir, Math.Min(ustSinir, deger));
        }

        private double[] TurnuvaSecimi(double[,] pop, double[] fitnessDegerleri)
        {
            int i1 = random.Next(populasyonBoyutu);
            int i2 = random.Next(populasyonBoyutu);
            return fitnessDegerleri[i1] < fitnessDegerleri[i2] ? new double[] { pop[i1, 0], pop[i1, 1] } : new double[] { pop[i2, 0], pop[i2, 1] };
        }

        private void GrafikCiz(double[] fitness)
        {
            chartGraph.Series.Clear();
            var seri = new Series { ChartType = SeriesChartType.Line, Name = "Yakınsama Grafiği" };
            for (int i = 0; i < fitness.Length; i++)
                seri.Points.AddXY(i, fitness[i]);
            chartGraph.Series.Add(seri);
        }
    }
}
