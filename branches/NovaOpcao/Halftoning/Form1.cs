using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace Halftoning
{
    public partial class Form1 : Form
    {
        Bitmap minhaImagem;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog SourceImagem = new OpenFileDialog();
            SourceImagem.ShowDialog();
            minhaImagem = new Bitmap(SourceImagem.FileName);
            ImgOriginal.Image = minhaImagem;
        }

        private void Tec1_Click(object sender, EventArgs e)
        {
            FiltersSequence filter = new FiltersSequence();
            byte[,] matrix = new byte[3, 3] 
                { 
                    {  10,   30,  60 }, 
                    {  90,  120, 150 }, 
                    { 180,  210, 240 } 
                };
            filter.Add(new Grayscale(.3, .59, .11));
            filter.Add(new OrderedDithering(matrix));
            ImgFinal.Image = filter.Apply(minhaImagem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FiltersSequence filter = new FiltersSequence();
            byte[,] matrix = new byte[3, 3] 
                { 
                    {  10,   30,  60 }, 
                    {  90,  120, 150 }, 
                    { 180,  210, 240 } 
                };

            filter.Add(new Grayscale(.3, .59, .11));
            filter.Add(new FloydSteinbergDithering());
            ImgFinal.Image = filter.Apply(minhaImagem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FiltersSequence filter = new FiltersSequence();
            byte[,] matrix = new byte[3, 3] 
                { 
                    {  10,   30,  60 }, 
                    {  90,  120, 150 }, 
                    { 180,  210, 240 } 
                };

            filter.Add(new Grayscale(.3, .59, .11));
            filter.Add(new SierraDithering());
            ImgFinal.Image = filter.Apply(minhaImagem);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FiltersSequence filter = new FiltersSequence();
            byte[,] matrix = new byte[3, 3] 
                { 
                    {  10,   30,  60 }, 
                    {  90,  120, 150 }, 
                    { 180,  210, 240 } 
                };

            filter.Add(new Grayscale(.3, .59, .11));
            filter.Add(new BayerDithering());
            ImgFinal.Image = filter.Apply(minhaImagem);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            FiltersSequence filter = new FiltersSequence();
            byte[,] matrix = new byte[3, 3] 
                { 
                    {  10,   30,  60 }, 
                    {  90,  120, 150 }, 
                    { 180,  210, 240 } 
                };

            filter.Add(new Grayscale(.3, .59, .11));
            filter.Add(new BurkesDithering());
            ImgFinal.Image = filter.Apply(minhaImagem);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            FiltersSequence filter = new FiltersSequence();
            byte[,] matrix = new byte[3, 3] 
                { 
                    {  10,   30,  60 }, 
                    {  90,  120, 150 }, 
                    { 180,  210, 240 } 
                };
            filter.Add(new Grayscale(.3, .59, .11));
            filter.Add(new JarvisJudiceNinkeDithering());
            ImgFinal.Image = filter.Apply(minhaImagem);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            FiltersSequence filter = new FiltersSequence();
            byte[,] matrix = new byte[3, 3] 
                { 
                    {  10,   30,  60 }, 
                    {  90,  120, 150 }, 
                    { 180,  210, 240 } 
                };
            filter.Add(new Grayscale(.3, .59, .11));
            filter.Add(new StuckiDithering());
            ImgFinal.Image = filter.Apply(minhaImagem);



        }

        private void button8_Click(object sender, EventArgs e)
        {
            FiltersSequence filter = new FiltersSequence();
            byte[,] matrix = new byte[3, 3] 
                { 
                    {  10,   30,  60 }, 
                    {  90,  120, 150 }, 
                    { 180,  210, 240 } 
                };
            filter.Add(new Grayscale(.3, .59, .11));
            filter.Add(new ErrorDiffusionToAdjacentNeighbors(
                         new int[3][] { 
                                new int[2] { 5, 3 }, 
                                new int[5] { 2, 4, 5, 4, 2 }, 
                                new int[3] { 2, 3, 2 }}
                ));
            ImgFinal.Image = filter.Apply(minhaImagem); 

        }
    }
}
