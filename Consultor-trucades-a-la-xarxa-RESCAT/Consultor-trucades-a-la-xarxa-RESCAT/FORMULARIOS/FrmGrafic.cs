using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Consultor_trucades_a_la_xarxa_RESCAT.FORMULARIOS
{
    public partial class FrmGrafic : Form
    {
        List<string> etiquetasX = new List<string>();
        List<double> valoresY = new List<double>();

        public FrmGrafic(List<string> xetiquetasX, List<double> xvaloresY)
        {
            etiquetasX = xetiquetasX;
            valoresY = xvaloresY;
            InitializeComponent();
            CrearGrafico();
        }

        private void CrearGrafico()
        {
            // Configurar el gráfico
            chart1.Series.Clear();
            Series serie = new Series("Temps mitja");
            serie.ChartType = SeriesChartType.Column; // Puedes cambiar a Line, Pie, etc.

            // Agregar los puntos desde las listas
            for (int i = 0; i < etiquetasX.Count; i++)
            {
                serie.Points.AddXY(etiquetasX[i], valoresY[i]);
            }

            // Agregar la serie al gráfico
            chart1.Series.Add(serie);

            // Configurar ejes
            chart1.ChartAreas[0].AxisX.Title = "Anys";
            chart1.ChartAreas[0].AxisY.Title = "Temps cues";
        }
    }
}
