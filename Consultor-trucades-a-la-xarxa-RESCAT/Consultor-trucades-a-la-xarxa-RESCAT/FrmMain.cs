﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Consultor_trucades_a_la_xarxa_RESCAT
{
    public partial class FrmMain : Form
    {

        private string fileName;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            chkFiltre.Enabled = false;
            btExportar.Enabled = false;
            cambiEstatGP();

            if (chkFiltreDades.Checked == true)
            {
                GpDates.Enabled = false;
            }
            
        }

        private void cambiEstatGP()
        {
            bool desactivar = chkFiltre.Checked;

            gpInfo.Enabled = !desactivar;
            GpDates.Enabled = !desactivar;
            GpEspera.Enabled = !desactivar;
            lbAny.Enabled = !desactivar;
            nupAny.Enabled = !desactivar;
            btCerca.Enabled = !desactivar;
            chkFiltreDades.Enabled = !desactivar;
            chkFiltreDades.Checked = false;
            GpDates.Enabled = false;
        }

        private void chkFiltre_CheckedChanged(object sender, EventArgs e)
        {
            // Habilitar/Deshabilitar filtres
            cambiEstatGP();

            if (chkFiltreDades.Checked == true)
            {
                GpDates.Enabled = false ;
            } else
            {
                dgDades.Rows.Clear();
                omplirDataGrip();
            }

            // Ajustar la data Maxima
            DataMax();

        }

        private void DataMax()
        {
            // Cargar el documento XML
            XPathDocument document = new XPathDocument(fileName);
            XPathNavigator navegador = document.CreateNavigator();

            string fechaMaxima = "0000-00";

            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");
            expr.AddSort("data", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);
            foreach (XPathNavigator row in cursor)
            {
                string data = row.SelectSingleNode("data")?.Value;
                DateTime dataConvert = DateTime.Parse(data);
                string dataTallada = dataConvert.ToString("yyyy-MM");

                if (string.Compare(dataTallada, fechaMaxima) > 0)
                {
                    fechaMaxima = dataTallada;
                }
            }

            int any = int.Parse(fechaMaxima.Split('-')[0]);

            nupAny.Value = any;
        }

        private void btExaminar_Click(object sender, EventArgs e)
        {
            if (dlgFitxer.ShowDialog() == DialogResult.OK)
            {
                // Gestionar la ruta
                tbRuta.Text = dlgFitxer.FileName;
                fileName = dlgFitxer.FileName;
                gpRuta.Enabled = false;

                // Habilitem el check de filtrar tot o res
                chkFiltre .Enabled = true;

                btExportar.Enabled = true;

                omplirDataGrip();
            }
        }

        private void omplirDataGrip()
        {
            // Cargar el documento XML
            XPathDocument document = new XPathDocument(fileName);
            XPathNavigator navegador = document.CreateNavigator();

            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");
            expr.AddSort("data", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);
            foreach (XPathNavigator row in cursor)
            {
                string data = row.SelectSingleNode("data")?.Value;
                DateTime dataConvert = DateTime.Parse(data);
                string dataTallada = dataConvert.ToString("yyyy-MM");

                string NombreTrucades = row.SelectSingleNode("nombre_total_de_trucades")?.Value;
                string TempsTrucades = row.SelectSingleNode("temps_total_de_trucades_grup")?.Value;
                string TempsMigCua = row.SelectSingleNode("temps_mig_en_cua_segons")?.Value;
                string disponibilitatTbs = row.SelectSingleNode("disponibilitat_tbs")?.Value;
                string disponibilitatDots = row.SelectSingleNode("disponibilitat_dots_1")?.Value;
                string disponibilitatDxt = row.SelectSingleNode("disponibilitat_tbs")?.Value;

                dgDades.Rows.Add(dataTallada, NombreTrucades, TempsTrucades, TempsMigCua, disponibilitatTbs, disponibilitatDots, disponibilitatDxt);

            }
        }

        private void chkFiltreDades_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltreDades.Checked == true)
            {
                GpDates.Enabled = true;
                nupAny.Enabled = false;
                lbAny.Enabled = false;
            } else
            {
                GpDates.Enabled = false;
                nupAny.Enabled = true;
                lbAny.Enabled = true;
            }
        }

        private void btCerca_Click(object sender, EventArgs e)
        {
            if (!chkFiltreDades.Checked)
            {
                // Filtro Año

                // Cargar el documento XML
                XPathDocument document = new XPathDocument(fileName);
                XPathNavigator navegador = document.CreateNavigator();

                dgDades.Rows.Clear();

                int contador = 0;
                double mitjaCua = 0;
                int TrucadesAny = 0;
                double tbs = 0, dots = 0, dxt = 0;

                XPathNodeIterator cursor = null;
                XPathExpression expr = navegador.Compile("//row//row");
                expr.AddSort("data", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
                cursor = navegador.Select(expr);
                foreach (XPathNavigator row in cursor)
                {
                    string data = row.SelectSingleNode("data")?.Value;
                    DateTime dataConvert = DateTime.Parse(data);
                    string dataTallada = dataConvert.ToString("yyyy-MM");
                    int any = int.Parse(dataTallada.Split('-')[0]);

                    if (any == nupAny.Value)
                    {
                        contador = contador + 1;

                        string NombreTrucades = row.SelectSingleNode("nombre_total_de_trucades")?.Value;
                        string TempsTrucades = row.SelectSingleNode("temps_total_de_trucades_grup")?.Value;
                        string TempsMigCua = row.SelectSingleNode("temps_mig_en_cua_segons")?.Value;
                        string disponibilitatTbs = row.SelectSingleNode("disponibilitat_tbs")?.Value;
                        string disponibilitatDots = row.SelectSingleNode("disponibilitat_dots_1")?.Value;
                        string disponibilitatDxt = row.SelectSingleNode("disponibilitat_tbs")?.Value;

                        double Cua = Convert.ToDouble(TempsMigCua, CultureInfo.InvariantCulture);
                        mitjaCua = mitjaCua + Cua;

                        TrucadesAny = TrucadesAny + int.Parse(NombreTrucades);

                        tbs += Convert.ToDouble(disponibilitatTbs, CultureInfo.InvariantCulture);
                        dots += Convert.ToDouble(disponibilitatDots, CultureInfo.InvariantCulture);
                        dxt += Convert.ToDouble(disponibilitatDxt, CultureInfo.InvariantCulture);

                        dgDades.Rows.Add(dataTallada, NombreTrucades, TempsTrucades, TempsMigCua, disponibilitatTbs, disponibilitatDots, disponibilitatDxt);

                        lbMitjaCua.Text = contador > 0 ? Math.Round(mitjaCua / contador, 2).ToString() + " segons" : "0 segons";
                        lbMitjaTrucades.Text = contador > 0 ? (TrucadesAny / contador).ToString() : "0";
                        lbTBS.Text = contador > 0 ? Math.Round((tbs / contador)*1000, 2).ToString() + "  /  1000" : "0";
                        lbDOTS.Text = contador > 0 ? Math.Round((dots / contador)*1000, 2).ToString() + "  /  1000" : "0";
                        lbDXT.Text = contador > 0 ? Math.Round((dxt / contador)*1000, 2).ToString() + "  /  1000" : "0";

                    }

                }
            }
            else
            {
                // Filtro fechas en concreto

            }
        }
    }
}
