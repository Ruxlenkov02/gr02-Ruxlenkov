﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class Form1 : Form
    {
        int old_x, old_y;
        List<Figure> lst = new List<Figure>();
        Figure createFigure(string fig_type)
        {
            switch (fig_type)
            {
                case "circle": return new Circle();
                case "square": return new Square();
            }
            return null;
        }
        public Form1()
        {
            InitializeComponent();
        }
        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0,picture_craft.Width, picture_craft.Height);
            foreach (Figure fig in lst)
                fig.draw(e.Graphics);
        }
        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Figure fig in lst)
                fig.selected = false;
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                Figure fig = lst[i];
                fig.selected |= fig.test(e.X, e.Y);
                if (fig.selected == true) break;
            }
            picture_craft.Invalidate();
        }

         void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - old_x;
                int dy = e.Y - old_y;
                foreach (Figure fig in lst)
                {
                    if (fig.selected == false) continue;
                    fig.pos_x += dx;
                    fig.pos_y += dy;

                }
                picture_craft.Invalidate();

            }
            old_x = e.X;
            old_y = e.Y;
        }

        void button1_Click(object sender, EventArgs e)
        {
            Figure fig = createFigure(comboBox_Figure.Text);
            if (fig == null) return;
            fig.pos_x = 100.0f;
            fig.pos_y = 100.0f;
            lst.Add(fig);
            picture_craft.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i<lst.Count)
            {
                if (lst[i].selected == true) lst.RemoveAt(i);
                i++;
            }
            picture_craft.Invalidate();
        }

      

       
    }
}
