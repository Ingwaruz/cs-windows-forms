using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace brahistohrone
{
    public partial class Form1 : Form
    {
        private double radius;
        private Timer animationTimer;
        private double animationParameter = 0;
        private bool brahistohroneBuilt = false;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.SuspendLayout();

            // Инициализация пользовательского интерфейса

            comboBoxCoordinateSystem.SelectedIndex = 0;
            this.MinimumSize = new Size(400, 200);

            comboBoxCoordinateSystem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCoordinateSystem.SelectedIndexChanged += ComboBoxCoordinateSystem_SelectedIndexChanged;

            buttonDraw.Click += ButtonDraw_Click;

            buttonStartAnimation.Click += ButtonStartAnimation_Click;
            buttonStartAnimation.Enabled = false;

            // Создание и настройка области графика
            ChartArea chartArea = new ChartArea("Brahistohrone");
            chart.ChartAreas.Add(chartArea);

            // Установка пересечения осей в центре
            chartArea.AxisX.Crossing = 0;
            chartArea.AxisY.Crossing = 0;

            // Уменьшение прозрачности сетки
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(200, 200, 200);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(200, 200, 200);

            animationTimer = new Timer();
            animationTimer.Interval = 50;
            animationTimer.Tick += AnimationTimer_Tick;

            this.Controls.Add(chart); // Добавление объекта графика на форму

            this.ResumeLayout(false);
        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            // Обработка нажатия кнопки "Построить"
            if (double.TryParse(textBoxRadius.Text, out radius))
            {
                // Удаление серии "Animation", если она существует
                Series animationSeries = chart.Series.FindByName("Animation");
                if (animationSeries != null)
                {
                    chart.Series.Remove(animationSeries);
                }

                Series series = chart.Series.FindByName("Brahistohrone");

                if (series == null)
                {
                    series = new Series("Brahistohrone");
                    series.ChartType = SeriesChartType.Spline;
                    series.BorderWidth = 2;
                    series.Color = Color.Blue;
                    chart.Series.Add(series);
                }
                else
                {
                    series.Points.Clear();
                }

                if (comboBoxCoordinateSystem.SelectedIndex == 0) // Декартовая система координат
                {
                    for (double t = 0; t <= Math.PI; t += 0.01)
                    {
                        double x = radius * (t - Math.Sin(t));
                        double y = radius * (1 - Math.Cos(t));
                        series.Points.AddXY(x, y);
                    }
                }
                else // Полярная система координат
                {
                    for (double theta = 0; theta <= Math.PI; theta += 0.01)
                    {
                        double r = radius * (1 - Math.Cos(theta));
                        double x = r * Math.Cos(theta);
                        double y = r * Math.Sin(theta);
                        series.Points.AddXY(x, y);
                    }
                }

                brahistohroneBuilt = true;
                buttonStartAnimation.Enabled = true;

                // Форматирование оси X
                if (Math.Abs(radius - 1.0) < 2) // Проверка, что радиус близок < 2
                {
                    chart.ChartAreas[0].AxisX.LabelStyle.Format = "F1"; // Один знак после запятой для радиуса 1
                }
                else
                {
                    chart.ChartAreas[0].AxisX.LabelStyle.Format = "0"; // Целые числа для остальных радиусов
                }
            }
            else
            {
                MessageBox.Show("Введите корректное значение радиуса.");
            }
        }

        private void ButtonStartAnimation_Click(object sender, EventArgs e)
        {
            // Обработка нажатия кнопки "Начать анимацию"
            if (brahistohroneBuilt)
            {
                if (comboBoxCoordinateSystem.Enabled)
                {
                    comboBoxCoordinateSystem.Enabled = false;
                    animationParameter = 0;
                    animationTimer.Start();
                }
            }
            else
            {
                MessageBox.Show("Постройте брахистохрону перед запуском анимации.");
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Обработка события таймера для анимации
            if (animationParameter > Math.PI)
            {
                animationTimer.Stop();
                comboBoxCoordinateSystem.Enabled = true;
                return;
            }

            double x, y;

            if (comboBoxCoordinateSystem.SelectedIndex == 0) // Декартовая система координат
            {
                x = radius * (animationParameter - Math.Sin(animationParameter));
                y = radius * (1 - Math.Cos(animationParameter));
            }
            else // Полярная система координат
            {
                double theta = animationParameter;
                double r = radius * (1 - Math.Cos(theta));
                x = r * Math.Cos(theta);
                y = r * Math.Sin(theta);
            }

            Series animationSeries = chart.Series.FindByName("Animation");
            if (animationSeries != null)
            {
                animationSeries.Points.Clear();
            }
            else
            {
                animationSeries = new Series("Animation");
                animationSeries.ChartType = SeriesChartType.Line;
                animationSeries.MarkerStyle = MarkerStyle.Circle;
                animationSeries.MarkerSize = 20; // Устанавливаем размер маркера
                animationSeries.Color = Color.Red;
                chart.Series.Add(animationSeries);
            }

            animationSeries.Points.AddXY(x, y);

            animationParameter += 0.1;
        }

        private void ComboBoxCoordinateSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработка изменения выбора системы координат в выпадающем списке
            if (comboBoxCoordinateSystem.SelectedIndex == 0 || comboBoxCoordinateSystem.SelectedIndex == 1)
            {
                buttonDraw.Enabled = true;
            }
            else
            {
                buttonDraw.Enabled = false;
            }

            buttonStartAnimation.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Метод, необходимый для корректной работы формы
        }
    }
}