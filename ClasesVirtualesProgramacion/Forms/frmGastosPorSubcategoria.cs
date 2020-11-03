using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClasesVirtualesProgramacion.Forms
{
    public partial class frmGastosPorSubcategoria : Form
    {
        admConexion oConexion = new admConexion();
        public frmGastosPorSubcategoria()
        {
            InitializeComponent();
        }


        private void oGrafico_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string SQL = "Select subcategoria, count(subcategoria) as total from gastos group by subcategoria";
            if (oConexion.SelectData(SQL, dsClasesVirtuales.Totalporsubcategorias) == true)
            {
                oGrafico.Series.Clear();
                oGrafico.Titles.Clear();
                oGrafico.ChartAreas.Clear();
                oGrafico.Palette = ChartColorPalette.Excel;
                ChartArea areaGrafico = new ChartArea();
                areaGrafico.Area3DStyle.Enable3D = true;
                oGrafico.ChartAreas.Add(areaGrafico);
                Title tituloGrafico = new Title();
                tituloGrafico.Text = "Total de gastos por Subcategoria";
                tituloGrafico.Font = new Font("Tahoma", 15, FontStyle.Bold);
                oGrafico.Titles.Add(tituloGrafico);
                Series serieDatos = new Series("Subcategoria");
                serieDatos.ChartType = SeriesChartType.Column;
                serieDatos.XValueMember = "Subcategoria";
                serieDatos.YValueMembers = "Total";
                serieDatos.IsValueShownAsLabel = true;
                oGrafico.Series.Add(serieDatos);
                oGrafico.DataSource = dsClasesVirtuales.Totalporsubcategorias;
            }
        }
    }
}
